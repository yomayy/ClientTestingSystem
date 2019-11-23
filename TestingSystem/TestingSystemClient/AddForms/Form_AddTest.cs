using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingSystem.Models;
using Newtonsoft.Json;

namespace TestingSystemClient
{
    public partial class Form_AddTest : Form
    {
        public Form_AddTest()
        {
            InitializeComponent();
        }

        private Form1 form1;
        public Form_AddTest(Form1 f1)
        {
            InitializeComponent();
            this.form1 = f1;
        }

        public Category GetCategory(int id)
        {
            HttpResponseMessage response =
               this.form1.client.GetAsync($"api/Categories/{id}").Result;
            response.EnsureSuccessStatusCode();
            var category =
                response.Content.ReadAsAsync<Category>().Result;
            return category;
        }

        
        public Test GetTest(int id)
        {
            HttpResponseMessage response =
                this.form1.client.GetAsync($"api/Tests/{id}").Result;
            response.EnsureSuccessStatusCode();
            var test = response.Content.ReadAsAsync<Test>().Result;
            return test;
        }
        
        public List<Test> GetTest()
        {
            HttpResponseMessage response =
                this.form1.client.GetAsync("api/Tests").Result;
            response.EnsureSuccessStatusCode();
            var tests =
                response.Content.ReadAsAsync<List<Test>>().Result.ToList();
            return tests;
        }
        
        public List<Question> GetQuestions()
        {
            HttpResponseMessage response =
                this.form1.client.GetAsync("api/Questions").Result;
            response.EnsureSuccessStatusCode();
            var questions =
                response.Content.ReadAsAsync<List<Question>>().Result.ToList();
            return questions;
        }

        public int AddTest(Test t)
        {
            Task<HttpResponseMessage> response =
               form1.client.PostAsJsonAsync("api/Tests", t);
            //response.Exception.Message;
            var testId = response.Result.Content.ReadAsAsync<Test>().Result.Id;//ReadAsAsync<Test>().Result
            return testId;
        }

        public async void AddQuestion(Question q)
        {
            HttpResponseMessage response =
                await this.form1.client.PostAsJsonAsync("api/Questions", q);
            response.EnsureSuccessStatusCode();
        }

        public async void AddAnswer(Answer a)
        {
            HttpResponseMessage response =
                await this.form1.client.PostAsJsonAsync("api/Answers", a);
            response.EnsureSuccessStatusCode();
        }

        private void AddTest_button2_Click(object sender, EventArgs e)
        {
            //
            int cid = (CategoryList_comboBox2.SelectedItem as Category).Id;
            Test test = new Test()
            {
                Title = TestName_label3.Text,
                CategoryId = GetCategory(cid).Id
            };
            int testId = AddTest(test);
            //Task.Run(() => AddTest(test));
            ////////////////////////////////
            //TODO: добавить вопрос и ответ
            for (int i = 0; i < Quest_treeView1.Nodes.Count; i++)
            {
                // Добавляем вопрос
                try
                {
                    Question question = new Question()
                    {
                        Text = Quest_treeView1.Nodes[i].Text,
                        TestId = testId
                    };
                    AddQuestion(question);
                    //Task.Run(() => AddQuestion(question));
                    //MessageBox.Show("Вопрос: " + Quest_treeView1.Nodes[i].Text + " добавлен");
                    // Добавляем ответы
                    for (int j = 0; j < 3; j++)
                    {
                        Answer answer = new Answer()
                        {
                            Text = Quest_treeView1.Nodes[i].Nodes[j].Text,
                            Status = (Quest_treeView1.Nodes[i].Nodes[j].Nodes[0].Text == "False") ? false : true,
                            QuestionId = GetQuestions().Last().Id
                        };
                        //Task.Run(() => AddAnswer(answer));
                        //MessageBox.Show(Quest_treeView1.Nodes[i].Nodes[j].Text + " статус: " + ((Quest_treeView1.Nodes[i].Nodes[j].Nodes[0].Text == "False") ? "неверный" : "верный") + " добавлен");
                        AddAnswer(answer);
                    }                   
                }
                catch (Exception ioe)
                {
                    //Task.WaitAll();
                    MessageBox.Show(ioe.Message);
                }
                
            }

            ////////////////////////////////
            CategoryList_comboBox2.Enabled = true;
            TestName_textBox1.Clear();
            TestName_label3.Text = "Название";
            TestName_textBox1.Enabled = true;
            Quest_treeView1.Nodes.Clear();
            AddTest_button2.Enabled = false;
        }

        public string TestTitle = "";
        public string TestCategory = "";

        private void AddQuestion_button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TestName_textBox1.Text))
            {
                Form3AddQuestion form3 = new Form3AddQuestion(this);
                form3.Show();
                TestName_label3.Text = TestName_textBox1.Text;
                TestName_textBox1.Enabled = false;
                this.Enabled = false;
                this.TestTitle = TestName_textBox1.Text;
                this.TestCategory = CategoryList_comboBox2.Text;
            }
            else
            {
                MessageBox.Show("Введите название теста");
            }
        }

        private void Form_AddTest_Load(object sender, EventArgs e)
        {
            form1.GetCategories(CategoryList_comboBox2);
            AddTest_button2.Enabled = false;
        }

        private void Form_AddTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form1.Enabled = true;
            this.form1.categoriesList_SelectedIndexChanged(sender, e);
        }

        private void CategoryList_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestName_textBox1.Clear();
            TestName_textBox1.Enabled = true;
            TestName_label3.Text = "Название";
            CategoryName_label3.Text = CategoryList_comboBox2.Text;
        }
    }
}
