namespace WinFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            EmployeeButton = new Button();
            ViewButton = new Button();
            button2 = new Button();
            label1 = new Label();
            CrossBtnHome = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // EmployeeButton
            // 
            EmployeeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmployeeButton.Location = new Point(61, 345);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(199, 40);
            EmployeeButton.TabIndex = 2;
            EmployeeButton.Text = "Employee";
            EmployeeButton.UseVisualStyleBackColor = true;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewButton.Location = new Point(296, 345);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(199, 40);
            ViewButton.TabIndex = 3;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(536, 345);
            button2.Name = "button2";
            button2.Size = new Size(199, 40);
            button2.TabIndex = 4;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(61, 5);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 5;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // CrossBtnHome
            // 
            CrossBtnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CrossBtnHome.Location = new Point(755, 1);
            CrossBtnHome.Name = "CrossBtnHome";
            CrossBtnHome.Size = new Size(44, 31);
            CrossBtnHome.TabIndex = 10;
            CrossBtnHome.Text = "X";
            CrossBtnHome.UseVisualStyleBackColor = true;
            CrossBtnHome.Click += CrossBtnHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 236);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(296, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(207, 192);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(528, 116);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 469);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CrossBtnHome);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(ViewButton);
            Controls.Add(EmployeeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmployeeButton;
        private Button ViewButton;
        private Button button2;
        private Label label1;
        private Button CrossBtnHome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}