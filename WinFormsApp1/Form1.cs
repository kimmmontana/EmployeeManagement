namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Admin.Text == "Admin" && Password.Text == "Password")
            {
                Home H = new Home();
                H.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CrsButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Admin.Text = "";
            Password.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
