namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoginBtn = new Button();
            labelname = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Admin = new RichTextBox();
            label3 = new Label();
            Password = new RichTextBox();
            ClearBttn = new Button();
            CrsButtton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginBtn.Location = new Point(103, 431);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(162, 49);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += button1_Click;
            // 
            // labelname
            // 
            labelname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelname.AutoSize = true;
            labelname.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelname.ForeColor = Color.WhiteSmoke;
            labelname.Location = new Point(179, 30);
            labelname.Name = "labelname";
            labelname.Size = new Size(226, 38);
            labelname.TabIndex = 2;
            labelname.Text = "The Krusty Krab";
            labelname.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(103, 326);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 4;
            label2.Text = "Admin";
            // 
            // Admin
            // 
            Admin.Location = new Point(206, 310);
            Admin.Name = "Admin";
            Admin.Size = new Size(251, 44);
            Admin.TabIndex = 5;
            Admin.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(103, 369);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Password
            // 
            Password.Location = new Point(206, 368);
            Password.Name = "Password";
            Password.Size = new Size(251, 39);
            Password.TabIndex = 7;
            Password.Text = "";
            // 
            // ClearBttn
            // 
            ClearBttn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClearBttn.Location = new Point(274, 431);
            ClearBttn.Name = "ClearBttn";
            ClearBttn.Size = new Size(183, 49);
            ClearBttn.TabIndex = 8;
            ClearBttn.Text = "Clear";
            ClearBttn.UseVisualStyleBackColor = true;
            ClearBttn.Click += ClearBtn_Click;
            // 
            // CrsButtton
            // 
            CrsButtton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CrsButtton.Location = new Point(528, 1);
            CrsButtton.Name = "CrsButtton";
            CrsButtton.Size = new Size(44, 31);
            CrsButtton.TabIndex = 9;
            CrsButtton.Text = "X";
            CrsButtton.UseVisualStyleBackColor = true;
            CrsButtton.Click += CrsButtton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(136, 68);
            label1.Name = "label1";
            label1.Size = new Size(300, 28);
            label1.TabIndex = 10;
            label1.Text = "Employee Management System";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(573, 511);
            Controls.Add(label1);
            Controls.Add(CrsButtton);
            Controls.Add(ClearBttn);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Admin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(labelname);
            Controls.Add(LoginBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private RichTextBox Admin;
        private Label label3;
        private RichTextBox Password;
        private Button ClearBttn;
        private Button CrsButtton;
        private Label labelname;
    }
}
