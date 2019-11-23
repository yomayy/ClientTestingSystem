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

namespace TestingSystemClient.PassingTestForms
{
    public partial class FormPassingTest : Form
    {
        private Test test;
        public FormPassingTest()
        {
            InitializeComponent();
        }

        private Form1 form1;
        public FormPassingTest(Form1 f1, Test t)
        {
            InitializeComponent();
            this.form1 = f1;
            this.test = t;
        }

        List<Answer> myansw = new List<Answer>();
        List<Answer> trueAnswers = new List<Answer>();
        private void FormPassingTest_Load(object sender, EventArgs e)
        {
            // Список выбранных ответов
            foreach (Question q in test.Questions)
            {
                foreach (Answer a in q.Answers)
                {
                    // неизменяемый список
                    trueAnswers.Add(a);

                    // записываем кол-во правильных ответов
                    if (a.Status == true)
                    {
                        trueAnsw++;
                    }

                    // Работаем с этим списком
                    Answer ans = new Answer();
                    ans.Id = a.Id;
                    ans.Text = a.Text;
                    ans.Status = false;
                    ans.Question = a.Question;
                    ans.QuestionId = a.QuestionId;
                    myansw.Add(ans);
                }
            }
            //
            this.form1.Enabled = false;
            Title_label.Text = test.Title;
            Category_label.Text = test.Category.Name;
            int i = 1;
            int qx = 10;
            int ax = 30;
            int y = 40;
            foreach(Question q in test.Questions)
            {
                Label qlabel = new Label();
                qlabel.Name = $"quest{i}_label";
                qlabel.Text = $"{i}) " + q.Text;
                qlabel.Font = new Font("Arial", 12, FontStyle.Bold);
                qlabel.Location = new Point(qx, y);
                qlabel.Width = 500;
                //
                //y += 50;
                flowLayoutPanel1.Controls.Add(qlabel);
                int j = 1;
                foreach(Answer a in q.Answers)
                {
                    CheckBox alabel = new CheckBox();
                    alabel.Tag = a.Question;
                    alabel.Name = $"{i}answ{j}_label";
                    alabel.Text = a.Text;
                    alabel.Location = new Point(40, y);
                    alabel.Width = 200;
                    alabel.Click += chooseAnswCheckBox_Click;
                    flowLayoutPanel1.Controls.Add(alabel);
                    //
                    j++;
                    answCount++;
                }
                i++;
            }
        }

        private void chooseAnswCheckBox_Click(object sender, EventArgs e)
        {
            var checkbox = (sender as CheckBox);
            myansw.Where(a => a.Question == checkbox.Tag).ToList().
                Where(a => a.Text == checkbox.Text).First().
                Status = checkbox.Checked;
        }

        private void FormPassingTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form1.Enabled = true;
        }

        int countOfTrueAnsw = 0;
        int answCount = 0;
        int trueAnsw = 0;
        private void EndTest_button_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Answer a in myansw)
            {
                if(a.Status == true && a.Status != trueAnswers[i].Status)
                {
                    countOfTrueAnsw--;
                }
                else if(a.Status == trueAnswers[i].Status)
                {
                    if (a.Status != false)
                    {
                        countOfTrueAnsw++;
                    }
                }
                i++;
            }
            MessageBox.Show($"{countOfTrueAnsw}/{trueAnsw} Правильных ответов");
            this.Close();
        }
    }
}
