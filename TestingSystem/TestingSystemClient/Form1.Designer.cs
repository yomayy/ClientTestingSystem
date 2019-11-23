namespace TestingSystemClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testsList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelTest_bttn = new System.Windows.Forms.Button();
            this.AddTest_bttn = new System.Windows.Forms.Button();
            this.EditTest_bttn = new System.Windows.Forms.Button();
            this.StartTest_bttn = new System.Windows.Forms.Button();
            this.numberDisplay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.TextBox();
            this.categoryDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDisplay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testsList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoriesList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление каталогом";
            // 
            // testsList
            // 
            this.testsList.FormattingEnabled = true;
            this.testsList.ItemHeight = 20;
            this.testsList.Location = new System.Drawing.Point(16, 128);
            this.testsList.Name = "testsList";
            this.testsList.ScrollAlwaysVisible = true;
            this.testsList.Size = new System.Drawing.Size(426, 344);
            this.testsList.TabIndex = 3;
            this.testsList.SelectedIndexChanged += new System.EventHandler(this.testsList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тесты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категории:";
            // 
            // categoriesList
            // 
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(16, 55);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(426, 28);
            this.categoriesList.TabIndex = 0;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.categoriesList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelTest_bttn);
            this.groupBox2.Controls.Add(this.AddTest_bttn);
            this.groupBox2.Controls.Add(this.EditTest_bttn);
            this.groupBox2.Controls.Add(this.StartTest_bttn);
            this.groupBox2.Controls.Add(this.numberDisplay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nameDisplay);
            this.groupBox2.Controls.Add(this.categoryDisplay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(448, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление тестами";
            // 
            // DelTest_bttn
            // 
            this.DelTest_bttn.Location = new System.Drawing.Point(210, 191);
            this.DelTest_bttn.Name = "DelTest_bttn";
            this.DelTest_bttn.Size = new System.Drawing.Size(224, 46);
            this.DelTest_bttn.TabIndex = 9;
            this.DelTest_bttn.Text = "Удалить тест";
            this.DelTest_bttn.UseVisualStyleBackColor = true;
            this.DelTest_bttn.Click += new System.EventHandler(this.DelTest_bttn_Click);
            // 
            // AddTest_bttn
            // 
            this.AddTest_bttn.Location = new System.Drawing.Point(210, 136);
            this.AddTest_bttn.Name = "AddTest_bttn";
            this.AddTest_bttn.Size = new System.Drawing.Size(224, 46);
            this.AddTest_bttn.TabIndex = 8;
            this.AddTest_bttn.Text = "Добавить тест";
            this.AddTest_bttn.UseVisualStyleBackColor = true;
            this.AddTest_bttn.Click += new System.EventHandler(this.AddTest_bttn_Click);
            // 
            // EditTest_bttn
            // 
            this.EditTest_bttn.Location = new System.Drawing.Point(11, 191);
            this.EditTest_bttn.Name = "EditTest_bttn";
            this.EditTest_bttn.Size = new System.Drawing.Size(193, 46);
            this.EditTest_bttn.TabIndex = 7;
            this.EditTest_bttn.Text = "Редактировать тест";
            this.EditTest_bttn.UseVisualStyleBackColor = true;
            this.EditTest_bttn.Click += new System.EventHandler(this.EditTest_bttn_Click);
            // 
            // StartTest_bttn
            // 
            this.StartTest_bttn.Location = new System.Drawing.Point(11, 136);
            this.StartTest_bttn.Name = "StartTest_bttn";
            this.StartTest_bttn.Size = new System.Drawing.Size(193, 46);
            this.StartTest_bttn.TabIndex = 6;
            this.StartTest_bttn.Text = "Пройти тест";
            this.StartTest_bttn.UseVisualStyleBackColor = true;
            this.StartTest_bttn.Click += new System.EventHandler(this.StartTest_bttn_Click);
            // 
            // numberDisplay
            // 
            this.numberDisplay.Enabled = false;
            this.numberDisplay.Location = new System.Drawing.Point(210, 106);
            this.numberDisplay.Name = "numberDisplay";
            this.numberDisplay.Size = new System.Drawing.Size(224, 27);
            this.numberDisplay.TabIndex = 5;
            this.numberDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество вопросов:";
            // 
            // nameDisplay
            // 
            this.nameDisplay.Location = new System.Drawing.Point(150, 64);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(284, 27);
            this.nameDisplay.TabIndex = 3;
            // 
            // categoryDisplay
            // 
            this.categoryDisplay.Location = new System.Drawing.Point(150, 20);
            this.categoryDisplay.Name = "categoryDisplay";
            this.categoryDisplay.Size = new System.Drawing.Size(284, 27);
            this.categoryDisplay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Категория:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(448, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Йоу!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TestingSystemClient.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestingSystemClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDisplay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DelTest_bttn;
        private System.Windows.Forms.Button AddTest_bttn;
        private System.Windows.Forms.Button EditTest_bttn;
        private System.Windows.Forms.Button StartTest_bttn;
        private System.Windows.Forms.NumericUpDown numberDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameDisplay;
        private System.Windows.Forms.TextBox categoryDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ListBox testsList;
        protected internal System.Windows.Forms.ComboBox categoriesList;
    }
}

