using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingSystem.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using TestingSystemClient.PassingTestForms;

namespace TestingSystemClient
{
    public partial class Form1 : Form
    {
        const string API_ADDR = "http://localhost:60463";
        internal HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(API_ADDR);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void GetCategories(ComboBox comboBox)
        {
            // Получаем все категории и заполняем ими комбобоксик
            HttpResponseMessage response =
                client.GetAsync("api/Categories").Result;
            response.EnsureSuccessStatusCode();
            var categories = 
                response.Content.ReadAsAsync<List<Category>>().Result.ToList();
            foreach (Category c in categories)
            {
                comboBox.Items.Add(c);
            }
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = 0;
        }

        public List<Answer> GetAnswers(int quest_id)
        {
            HttpResponseMessage answResp =
                client.GetAsync($"api/Answers").Result;
            var answers =
                answResp.Content.ReadAsAsync<List<Answer>>().Result.Where(a => a.QuestionId == quest_id).ToList();
            return answers;
        }

        internal void Form1_Load(object sender, EventArgs e)
        {
            GetCategories(categoriesList);
            StartTest_bttn.Enabled = false;
            EditTest_bttn.Enabled = false;
            DelTest_bttn.Enabled = false;
        }

        private void GetTests(int cid)
        {
            // Получаем все тесты данной категории и заполняем ими листбоксик
            HttpResponseMessage response =
                client.GetAsync("api/Tests").Result;
            response.EnsureSuccessStatusCode();
            var tests =
                response.Content.ReadAsAsync<List<Test>>().Result
                .Where(t => t.CategoryId == cid).ToList();
            testsList.Items.Clear();
            foreach(Test t in tests)
            {
                testsList.Items.Add(t);
            }
            testsList.DisplayMember = "Title";
            testsList.ValueMember = "Id";
        }

        internal List<Question> GetTestsQuestions(int testId)
        {
            HttpResponseMessage response =
                client.GetAsync("api/Questions").Result;
            response.EnsureSuccessStatusCode();
            var questions =
                response.Content.ReadAsAsync<List<Question>>().Result.Where(q => q.TestId == testId).ToList();
            return questions;
        }

        internal void categoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = (categoriesList.SelectedItem as Category).Id;
            GetTests(cid);
        }

        private void GetTest(int id)
        {
            // Получаем тест, выбранный в листбоксе
            // Получаем данные о нем
            HttpResponseMessage response =
                client.GetAsync($"api/Tests/{id}").Result;
            response.EnsureSuccessStatusCode();
            var test =
                response.Content.ReadAsAsync<Test>().Result;
            categoryDisplay.Text = (categoriesList.SelectedItem as Category).Name;
            nameDisplay.Text = test.Title;
            try
            {
                int count = GetTestsQuestions(test.Id).Count;
                numberDisplay.Value = count;
            }
            catch (NullReferenceException ex) {
                numberDisplay.Value = 0;
            }
        }
        // просто Тест по Id
        public Test GetTestForDel(int test_id)
        {
            HttpResponseMessage testResp =
                client.GetAsync($"api/Tests/{test_id}").Result;
            var test =
                testResp.Content.ReadAsAsync<Test>().Result;
            return test;
        }

        private async Task<HttpStatusCode> DeleteTest(int testId)
        {
            Test t = GetTestForDel(testId);
            // TODO УДАЛИТЬ НОРМАЛЬНО
            // ага, при удалении теста,
            // все, шо связанно ключами удаляется каскадно (вопросы и ответы)
            // поэтому удаляем только тест, остальное само удалится
            HttpResponseMessage testResponse = 
                await client.DeleteAsync($"api/Tests/{t.Id}");
            return testResponse.StatusCode;
        }

        internal void testsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (testsList.SelectedItem as Test).Id;
                GetTest(id);
                DelTest_bttn.Enabled = true;
                EditTest_bttn.Enabled = true;
                StartTest_bttn.Enabled = true;
            }
            catch(NullReferenceException nre)
            {

            }
        }

        private void StartTest_bttn_Click(object sender, EventArgs e)
        {
            int id = (testsList.SelectedItem as Test).Id;
            Test t = GetTestForDel(id);
            t.Category = (categoriesList.SelectedItem as Category);
            t.Questions = GetTestsQuestions(t.Id);
            foreach(Question q in t.Questions)
            {
                q.Answers = new List<Answer>();
                q.Answers.AddRange(GetAnswers(q.Id));
                foreach(Answer a in q.Answers)
                {
                    a.Question = q;
                }
            }
            FormPassingTest formPassingTest = new FormPassingTest(this, t);
            formPassingTest.Show();
        }

        private void AddTest_bttn_Click(object sender, EventArgs e)
        {
            Form_AddTest form2 = new Form_AddTest(this);
            form2.Show();
            this.Enabled = false;
        }

        private void EditTest_bttn_Click(object sender, EventArgs e)
        {
            if(testsList.SelectedIndex == -1)
            {
                MessageBox.Show("сначала выберите тест");
            }
            else
            {
                Form_EditTest form_EditTest = new Form_EditTest(this);
                form_EditTest.Show();
                this.Enabled = false;
            }
        }

        private void DelTest_bttn_Click(object sender, EventArgs e)
        {
            if (testsList.SelectedIndex == -1)
            {
                MessageBox.Show("сначала выберите тест");
            }
            else
            {
                int id = (testsList.SelectedItem as Test).Id;
                string title = (testsList.SelectedItem as Test).Title;
                DialogResult d = MessageBox.Show($"Удалить {title}?", "йоу",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (d == DialogResult.OK)
                {
                    try
                    {
                        Task.Run(() => DeleteTest(id));
                        MessageBox.Show($"тест \"{title}\" Успешно удален", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ошибка удаления", "oops",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        categoriesList_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }
    }
}
