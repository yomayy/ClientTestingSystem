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

namespace TestingSystemClient
{
    public partial class Form3AddQuestion : Form
    {
        public Form3AddQuestion()
        {
            InitializeComponent();
        }

        private Form_AddTest Form_AddTest;
        public Form3AddQuestion(Form_AddTest f2)
        {
            InitializeComponent();
            this.Form_AddTest = f2;
        }

        public int nodes = 0;
        private void AddQeest_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Question_textBox1.Text))
            {
                MessageBox.Show("Введите вопрос");
            }
            else
            {
                if (String.IsNullOrEmpty(answ1Textbox.Text) ||
                    String.IsNullOrEmpty(answ2textBox.Text) ||
                    String.IsNullOrEmpty(answ3textBox.Text))
                {
                    MessageBox.Show("Введите ответы");
                }
                else
                {
                    if (!first_checkBox.Checked &&
                        !second_checkBox.Checked &&
                        !third_checkBox.Checked)
                    {
                        MessageBox.Show("Отметьте правильный ответ");
                    }
                    else
                    { 
                        TreeNode quest = new TreeNode(Question_textBox1.Text);
                        quest.Nodes.Add(new TreeNode(answ1Textbox.Text));
                        quest.Nodes.Add(new TreeNode(answ2textBox.Text));
                        quest.Nodes.Add(new TreeNode(answ3textBox.Text));
                        quest.Nodes[0].Nodes.Add(new TreeNode(first_checkBox.Checked.ToString()));
                        quest.Nodes[1].Nodes.Add(new TreeNode(second_checkBox.Checked.ToString()));
                        quest.Nodes[2].Nodes.Add(new TreeNode(third_checkBox.Checked.ToString()));
                        this.Form_AddTest.Quest_treeView1.Nodes.Add(quest);
                        this.Form_AddTest.CategoryList_comboBox2.Enabled = false;
                        this.Form_AddTest.AddTest_button2.Enabled = true;
                        this.Close();
                    }
                }
            }
        }

        private void Form3AddQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Form_AddTest.Enabled = true;
        }
    }
}
