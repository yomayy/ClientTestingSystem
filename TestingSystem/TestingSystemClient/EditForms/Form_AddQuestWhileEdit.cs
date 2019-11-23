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

namespace TestingSystemClient.EditForms
{
    public partial class Form_AddQuestWhileEdit : Form
    {
        public Form_AddQuestWhileEdit()
        {
            InitializeComponent();
        }

        private Form_EditTest Form_EditTest;
        public Form_AddQuestWhileEdit(Form_EditTest form_Edit)
        {
            InitializeComponent();
            this.Form_EditTest = form_Edit;
        }

        private async Task<int> AddQuestionAsync(Question q)
        {
            HttpResponseMessage response =
                await Form_EditTest.form1.client.PostAsJsonAsync(
                    "api/Questions", q);
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsAsync<Question>().Id;
        }

        private async void AddAnswer(Answer a)
        {
            HttpResponseMessage response =
                await this.Form_EditTest.form1.client.PostAsJsonAsync(
                    "api/Answers", a);
            response.EnsureSuccessStatusCode();
        }

        private Question GetLastQuestion(int testId)
        {
            HttpResponseMessage response =
                this.Form_EditTest.form1.client.GetAsync("api/Questions").Result;
            response.EnsureSuccessStatusCode();
            var question =
                response.Content.ReadAsAsync<List<Question>>().Result.Where(q => q.TestId == testId).Last();
            return question;
        }

        private void AddQuest_button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Quest_textBox1.Text) ||
                String.IsNullOrEmpty(Answ1_textBox.Text) ||
                String.IsNullOrEmpty(Answ2_textBox.Text) ||
                String.IsNullOrEmpty(Answ3_textBox.Text))
            {
                MessageBox.Show("заполните все поля");
            }
            else
            {
                // Вопрос
                Question question = new Question();
                question.TestId = this.Form_EditTest.test.Id;
                question.Text = Quest_textBox1.Text;
                try
                {
                    Task.WaitAll(Task.Run(() => AddQuestionAsync(question)));
                    int quest_id = GetLastQuestion(Form_EditTest.test.Id).Id;
                    // Ответы
                    List<Answer> answers = new List<Answer>();
                    answers.Add(new Answer
                    {
                        Text = Answ1_textBox.Text,
                        Status = checkBox1.Checked,
                        QuestionId = quest_id
                    });
                    answers.Add(new Answer
                    {
                        Text = Answ2_textBox.Text,
                        Status = checkBox2.Checked,
                        QuestionId = quest_id
                    });
                    answers.Add(new Answer
                    {
                        Text = Answ3_textBox.Text,
                        Status = checkBox3.Checked,
                        QuestionId = quest_id
                    });

                    // Добавляем ответ
                    foreach(Answer a  in answers)
                    {
                        AddAnswer(a);
                    }
                }
                catch(Exception add_ex)
                {
                    MessageBox.Show(add_ex.Message);
                }
                finally
                {
                    this.Form_EditTest.treeView_questions.Nodes.Clear();
                    this.Form_EditTest.Form_EditTest_Load(sender, e);
                    this.Close();
                }
            }
        }

        private void Form_AddQuestWhileEdit_Load(object sender, EventArgs e)
        {
            TetsTitlelabel1.Text = this.Form_EditTest.test.Title;
        }
    }
}
