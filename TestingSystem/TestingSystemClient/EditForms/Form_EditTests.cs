using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingSystem.Models;
using TestingSystemClient.EditForms;

namespace TestingSystemClient
{
    public partial class Form_EditTest : Form
    {
        public Form_EditTest()
        {
            InitializeComponent();
        }

        internal Form1 form1;
        public Form_EditTest(Form1 f1)
        {
            InitializeComponent();
            this.form1 = f1;
        }

        internal Test test;
        List<Question> questions;
        List<Answer> answers = new List<Answer>();
        internal void Form_EditTest_Load(object sender, EventArgs e)
        {
            int id = (form1.testsList.SelectedItem as Test).Id;
            test = form1.GetTestForDel(id);
            questions = form1.GetTestsQuestions(test.Id);
            textBox_title.Text = test.Title;
            foreach(Question q in questions)
            {
                // добавляем виртуальные свойства
                q.TestId = test.Id;
                q.Test = test;
                /////////////////////////////////
                
                TreeNode quest = new TreeNode(q.Text);
                var quest_answers = form1.GetAnswers(q.Id);

                ////
                q.Answers = quest_answers;
                ////
                int i = 0;
                foreach (Answer a in quest_answers)
                {
                    ////
                    a.QuestionId = q.Id;
                    a.Question = q;
                    answers.Add(a);
                    ////
                    quest.Nodes.Add(new TreeNode(a.Text));
                    quest.Nodes[i++].Nodes.Add(new TreeNode(a.Status.ToString()));
                }
                ////
                test.Questions = new List<Question>();
                test.Questions.Add(q);
                ////
                treeView_questions.Nodes.Add(quest);
            }
        }

        internal async void UpdateTest(Test t)
        {
            HttpResponseMessage response =
                await form1.client.PutAsJsonAsync(
                    $"api/Tests/{t.Id}", t);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body
            t = await response.Content.ReadAsAsync<Test>();
        }

        private void EditTitle_btn_Click(object sender, EventArgs e)
        {
            if (test.Title != textBox_title.Text)
            {
                //edit
                try
                {
                    test.Title = textBox_title.Text;
                    // Без обнуления виртуальных свойств - ошибка (рекурсия?)
                    test.Questions = null;
                    UpdateTest(this.test);
                    MessageBox.Show("тест отредактирован успешно");
                    ///

                }catch(Exception ue)
                {
                    MessageBox.Show(ue.Message);
                }
                finally
                {
                    //this.form1.categoriesList_SelectedIndexChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show("название не поменялось");
            }
        }

        private void addQuest_bttn_Click(object sender, EventArgs e)
        {
            Form_AddQuestWhileEdit form_AddQuestWhileEdit = new Form_AddQuestWhileEdit(this);
            form_AddQuestWhileEdit.Show();
        }

        private void EditQuest_button1_Click(object sender, EventArgs e)
        {
            if(treeView_questions.SelectedNode == null)
            {
                MessageBox.Show("Выберите вопрос");
            }
            else
            {
                var quest = questions.Where(q => q.Text == treeView_questions.SelectedNode.Text).First();
                Form_EditQuest form = new Form_EditQuest(this, quest);
                form.Show();
                this.Enabled = false;
            }
        }

        private void Form_EditTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form1.Enabled = true;
            this.form1.categoriesList.Items.Clear();
            this.form1.Form1_Load(sender, e);
            form1.testsList_SelectedIndexChanged(sender, e);
        }

        private void EndEdit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task<HttpStatusCode> DeleteQuestion(Question q)
        {
            HttpResponseMessage questResponse =
                await form1.client.DeleteAsync($"api/Questions/{q.Id}");
            return questResponse.StatusCode;
        }

        private void DelQuest_button1_Click(object sender, EventArgs e)
        {
            if (treeView_questions.SelectedNode == null)
            {
                MessageBox.Show("Выберите вопрос");
            }
            else
            {
                DialogResult d = MessageBox.Show($"Удалить {treeView_questions.SelectedNode.Text}?", "йоу",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (d == DialogResult.OK)
                {
                    Question question = questions.Where(q => q.Text == treeView_questions.SelectedNode.Text).First();
                    try
                    {
                        Task.Run(() => DeleteQuestion(question));
                        MessageBox.Show($"вопрос \"{question.Text}\" Успешно удален", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ошибка удаления", "oops",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        treeView_questions.Nodes.Clear();
                        Form_EditTest_Load(sender, e);
                    }
                }
            }
        }
    }
}
