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
    public partial class Form_EditQuest : Form
    {
        public Form_EditQuest()
        {
            InitializeComponent();
        }

        private Form_EditTest form_EditTest;
        private Question currentQuestion;
        public Form_EditQuest(Form_EditTest f, Question q)
        {
            InitializeComponent();
            this.form_EditTest = f;
            this.currentQuestion = q;
        }

        private void Form_EditQuest_Load(object sender, EventArgs e)
        {
            string title = this.form_EditTest.treeView_questions.SelectedNode.Text;
            this.Text += $" \"{title}\"";

            // Вопрос
            textBox_QuestTitle.Text = title;

            // Ответы
            answ1_textBox1.Text = currentQuestion.Answers[0].Text;
            answ2_textBox2.Text = currentQuestion.Answers[1].Text;
            answ3_textBox3.Text = currentQuestion.Answers[2].Text;

            // Статусы
            checkBox1.Checked = (currentQuestion.Answers[0].Status == true) ? true : false;
            checkBox2.Checked = (currentQuestion.Answers[1].Status == true) ? true : false;
            checkBox3.Checked = (currentQuestion.Answers[2].Status == true) ? true : false;
        }
   
        private void Form_EditQuest_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form_EditTest.Enabled = true;
            this.form_EditTest.treeView_questions.Nodes.Clear();
            this.form_EditTest.Form_EditTest_Load(sender, e);
        }

        internal async void UpdateQuest(Question q)
        {
            HttpResponseMessage response =
                await form_EditTest.form1.client.PutAsJsonAsync(
                    $"api/Questions/{q.Id}", q);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body
            q = await response.Content.ReadAsAsync<Question>();
        }

        private void EditQuestTitle_button_Click(object sender, EventArgs e)
        {
            if(textBox_QuestTitle.Text != currentQuestion.Text)
            {
                currentQuestion.Text = textBox_QuestTitle.Text;
                try
                {
                    Question q = currentQuestion;
                    q.Answers = null;
                    q.Test = null;
                    UpdateQuest(q);
                }
                catch(Exception qe)
                {
                    MessageBox.Show(qe.Message);
                }
                finally
                {
                    this.form_EditTest.treeView_questions.Nodes.Clear();
                    MessageBox.Show("Вопрос изменен");
                }
            }
            else
            {
                MessageBox.Show("вопрос не изменился");
            }
        }

        internal async void UpdateAswer(Answer answer)
        {
            HttpResponseMessage response = 
                await form_EditTest.form1.client.PutAsJsonAsync(
                    $"api/Answers/{answer.Id}", answer);
                response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body
            answer = await response.Content.ReadAsAsync<Answer>();
        }

        private void Edit_answ_button_Click(object sender, EventArgs e)
        {
            if(answ1_textBox1.Text == currentQuestion.Answers[0].Text &&
                answ2_textBox2.Text == currentQuestion.Answers[1].Text &&
                answ3_textBox3.Text == currentQuestion.Answers[2].Text &&
                checkBox1.Checked == currentQuestion.Answers[0].Status &&
                checkBox2.Checked == currentQuestion.Answers[1].Status &&
                checkBox3.Checked == currentQuestion.Answers[2].Status)
            {
                MessageBox.Show("ничего не поменялось");
            }
            else
            {
                // Ответ
                currentQuestion.Answers[0].Text = answ1_textBox1.Text;
                currentQuestion.Answers[1].Text = answ2_textBox2.Text;
                currentQuestion.Answers[2].Text = answ3_textBox3.Text;

                // Статус
                currentQuestion.Answers[0].Status = checkBox1.Checked;
                currentQuestion.Answers[1].Status = checkBox2.Checked;
                currentQuestion.Answers[2].Status = checkBox3.Checked;
                try
                {
                    List<Answer> ans = currentQuestion.Answers;
                    // Убираем виртуальные свойтсва
                    foreach(Answer a in ans)
                    {
                        a.Question = null;
                        UpdateAswer(a);
                    }
                }
                catch (Exception ans_e)
                {
                    MessageBox.Show(ans_e.Message);
                }
                finally
                {
                    this.form_EditTest.treeView_questions.Nodes.Clear();
                    MessageBox.Show("ответы изменены");
                }
            }
        }
    }
}
