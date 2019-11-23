namespace TestingSystemClient
{
    partial class Form_AddTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoryList_comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTest_button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TestName_textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestName_label3 = new System.Windows.Forms.Label();
            this.AddQuestion_button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CategoryName_label3 = new System.Windows.Forms.Label();
            this.Quest_treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryList_comboBox2
            // 
            this.CategoryList_comboBox2.FormattingEnabled = true;
            this.CategoryList_comboBox2.Location = new System.Drawing.Point(7, 47);
            this.CategoryList_comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryList_comboBox2.Name = "CategoryList_comboBox2";
            this.CategoryList_comboBox2.Size = new System.Drawing.Size(342, 28);
            this.CategoryList_comboBox2.TabIndex = 0;
            this.CategoryList_comboBox2.SelectedIndexChanged += new System.EventHandler(this.CategoryList_comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите категорию:";
            // 
            // AddTest_button2
            // 
            this.AddTest_button2.Location = new System.Drawing.Point(607, 399);
            this.AddTest_button2.Name = "AddTest_button2";
            this.AddTest_button2.Size = new System.Drawing.Size(170, 69);
            this.AddTest_button2.TabIndex = 2;
            this.AddTest_button2.Text = "Добавить тест";
            this.AddTest_button2.UseVisualStyleBackColor = true;
            this.AddTest_button2.Click += new System.EventHandler(this.AddTest_button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название:";
            // 
            // TestName_textBox1
            // 
            this.TestName_textBox1.Location = new System.Drawing.Point(7, 119);
            this.TestName_textBox1.Name = "TestName_textBox1";
            this.TestName_textBox1.Size = new System.Drawing.Size(338, 27);
            this.TestName_textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryName_label3);
            this.groupBox1.Controls.Add(this.TestName_label3);
            this.groupBox1.Controls.Add(this.AddQuestion_button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TestName_textBox1);
            this.groupBox1.Controls.Add(this.CategoryList_comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 468);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тест";
            // 
            // TestName_label3
            // 
            this.TestName_label3.AutoSize = true;
            this.TestName_label3.Location = new System.Drawing.Point(23, 279);
            this.TestName_label3.Name = "TestName_label3";
            this.TestName_label3.Size = new System.Drawing.Size(145, 20);
            this.TestName_label3.TabIndex = 7;
            this.TestName_label3.Text = "Название теста";
            // 
            // AddQuestion_button1
            // 
            this.AddQuestion_button1.Location = new System.Drawing.Point(7, 354);
            this.AddQuestion_button1.Name = "AddQuestion_button1";
            this.AddQuestion_button1.Size = new System.Drawing.Size(339, 79);
            this.AddQuestion_button1.TabIndex = 6;
            this.AddQuestion_button1.Text = "Добавить вопрос";
            this.AddQuestion_button1.UseVisualStyleBackColor = true;
            this.AddQuestion_button1.Click += new System.EventHandler(this.AddQuestion_button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quest_treeView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(366, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 315);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вопросы";
            // 
            // CategoryName_label3
            // 
            this.CategoryName_label3.AutoSize = true;
            this.CategoryName_label3.Location = new System.Drawing.Point(23, 244);
            this.CategoryName_label3.Name = "CategoryName_label3";
            this.CategoryName_label3.Size = new System.Drawing.Size(183, 20);
            this.CategoryName_label3.TabIndex = 8;
            this.CategoryName_label3.Text = "Название категории";
            // 
            // Quest_treeView1
            // 
            this.Quest_treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Quest_treeView1.Location = new System.Drawing.Point(3, 23);
            this.Quest_treeView1.Name = "Quest_treeView1";
            this.Quest_treeView1.Size = new System.Drawing.Size(408, 289);
            this.Quest_treeView1.TabIndex = 0;
            // 
            // Form_AddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddTest_button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_AddTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_AddTest_FormClosing);
            this.Load += new System.EventHandler(this.Form_AddTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestName_textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddQuestion_button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TestName_label3;
        private System.Windows.Forms.Label CategoryName_label3;
        internal System.Windows.Forms.TreeView Quest_treeView1;
        internal System.Windows.Forms.ComboBox CategoryList_comboBox2;
        internal System.Windows.Forms.Button AddTest_button2;
    }
}