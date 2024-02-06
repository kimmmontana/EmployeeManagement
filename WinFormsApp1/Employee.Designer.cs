namespace WinFormsApp1
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox4 = new ComboBox();
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            CrossBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(69, 14);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 6;
            label1.Text = "Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 14;
            label2.Text = "EmployeeID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(24, 128);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(24, 172);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(24, 218);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 17;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(24, 260);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 18;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(24, 306);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 19;
            label7.Text = "Position";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(24, 349);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 20;
            label8.Text = "Contact Number";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(24, 394);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 21;
            label9.Text = "Education";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSlateGray;
            textBox1.Location = new Point(183, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSlateGray;
            textBox2.Location = new Point(183, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSlateGray;
            textBox3.Location = new Point(183, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightSlateGray;
            textBox6.Location = new Point(183, 350);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(161, 27);
            textBox6.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.BackColor = Color.LightSlateGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Intersex" });
            comboBox1.Location = new Point(183, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 28);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LightSlateGray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cashier", "Fry Cook", "Manager", "Waitstaff", "Accountant", "Janitor" });
            comboBox2.Location = new Point(183, 306);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 28);
            comboBox2.TabIndex = 31;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.LightSlateGray;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "BS Computer Science", "BS Human Resource Management", "BS Accountancy", "BS Business Administration", "High School Graduate" });
            comboBox4.Location = new Point(183, 395);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(161, 28);
            comboBox4.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 341);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.Location = new Point(382, 445);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(130, 33);
            AddBtn.TabIndex = 35;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UpdateBtn.Location = new Point(533, 445);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(124, 33);
            UpdateBtn.TabIndex = 36;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeleteBtn.Location = new Point(682, 445);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(129, 33);
            DeleteBtn.TabIndex = 37;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ResetBtn.Location = new Point(833, 445);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(102, 33);
            ResetBtn.TabIndex = 38;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HomeBtn.Location = new Point(382, 497);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(553, 33);
            HomeBtn.TabIndex = 39;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CrossBtn.Location = new Point(939, -1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(44, 31);
            CrossBtn.TabIndex = 40;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = true;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(181, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(163, 27);
            dateTimePicker1.TabIndex = 41;
            dateTimePicker1.Value = new DateTime(2024, 3, 6, 0, 0, 0, 0);
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(983, 603);
            Controls.Add(dateTimePicker1);
            Controls.Add(CrossBtn);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox4;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private Button CrossBtn;
        private DateTimePicker dateTimePicker1;
    }
}