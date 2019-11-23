namespace TestingSystemClient
{
    partial class Form_EditTest
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
            this.EditTitle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.treeView_questions = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuest_bttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditQuest_button1 = new System.Windows.Forms.Button();
            this.EndEdit_button = new System.Windows.Forms.Button();
            this.DelQuest_button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditTitle_btn
            // 
            this.EditTitle_btn.Location = new System.Drawing.Point(357, 18);
            this.EditTitle_btn.Name = "EditTitle_btn";
            this.EditTitle_btn.Size = new System.Drawing.Size(309, 66);
            this.EditTitle_btn.TabIndex = 4;
            this.EditTitle_btn.Text = "Редактировать название";
            this.EditTitle_btn.UseVisualStyleBackColor = true;
            this.EditTitle_btn.Click += new System.EventHandler(this.EditTitle_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(10, 57);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(273, 27);
            this.textBox_title.TabIndex = 6;
            // 
            // treeView_questions
            // 
            this.treeView_questions.Location = new System.Drawing.Point(10, 66);
            this.treeView_questions.Name = "treeView_questions";
            this.treeView_questions.Size = new System.Drawing.Size(222, 251);
            this.treeView_questions.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вопросы";
            // 
            // addQuest_bttn
            // 
            this.addQuest_bttn.Location = new System.Drawing.Point(238, 26);
            this.addQuest_bttn.Name = "addQuest_bttn";
            this.addQuest_bttn.Size = new System.Drawing.Size(202, 66);
            this.addQuest_bttn.TabIndex = 9;
            this.addQuest_bttn.Text = "Добавить вопрос";
            this.addQuest_bttn.UseVisualStyleBackColor = true;
            this.addQuest_bttn.Click += new System.EventHandler(this.addQuest_bttn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.EditTitle_btn);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование названия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelQuest_button1);
            this.groupBox2.Controls.Add(this.EditQuest_button1);
            this.groupBox2.Controls.Add(this.treeView_questions);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addQuest_bttn);
            this.groupBox2.Location = new System.Drawing.Point(16, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 323);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование вопросов";
            // 
            // EditQuest_button1
            // 
            this.EditQuest_button1.Location = new System.Drawing.Point(238, 135);
            this.EditQuest_button1.Name = "EditQuest_button1";
            this.EditQuest_button1.Size = new System.Drawing.Size(202, 66);
            this.EditQuest_button1.TabIndex = 10;
            this.EditQuest_button1.Text = "Изменить вопрос";
            this.EditQuest_button1.UseVisualStyleBackColor = true;
            this.EditQuest_button1.Click += new System.EventHandler(this.EditQuest_button1_Click);
            // 
            // EndEdit_button
            // 
            this.EndEdit_button.Location = new System.Drawing.Point(521, 344);
            this.EndEdit_button.Name = "EndEdit_button";
            this.EndEdit_button.Size = new System.Drawing.Size(185, 95);
            this.EndEdit_button.TabIndex = 12;
            this.EndEdit_button.Text = "Закончить";
            this.EndEdit_button.UseVisualStyleBackColor = true;
            this.EndEdit_button.Click += new System.EventHandler(this.EndEdit_button_Click);
            // 
            // DelQuest_button1
            // 
            this.DelQuest_button1.Location = new System.Drawing.Point(238, 251);
            this.DelQuest_button1.Name = "DelQuest_button1";
            this.DelQuest_button1.Size = new System.Drawing.Size(202, 66);
            this.DelQuest_button1.TabIndex = 11;
            this.DelQuest_button1.Text = "Удалить вопрос";
            this.DelQuest_button1.UseVisualStyleBackColor = true;
            this.DelQuest_button1.Click += new System.EventHandler(this.DelQuest_button1_Click);
            // 
            // Form_EditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.EndEdit_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_EditTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditTest_FormClosing);
            this.Load += new System.EventHandler(this.Form_EditTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditTitle_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addQuest_bttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EndEdit_button;
        private System.Windows.Forms.Button EditQuest_button1;
        internal System.Windows.Forms.TreeView treeView_questions;
        private System.Windows.Forms.Button DelQuest_button1;
    }
}