using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Kim\OneDrive\Documents\EMS.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=False");

        private void CatchEmp()
        {
            try
            {
                Con.Open();
                string query = "select * from ETBL WHERE EmpId= '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    data1.Text = dr["EmpId"].ToString();
                    data2.Text = dr["EmpName"].ToString();
                    data3.Text = dr["EmpGen"].ToString();
                    data4.Text = dr["EmpAdd"].ToString();
                    data5.Text = dr["EmpDob"].ToString();
                    data6.Text = dr["EmpPos"].ToString();
                    data7.Text = dr["EmpPhone"].ToString();
                    data8.Text = dr["EmpEdu"].ToString();

                }
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            CatchEmp();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Close();
        }
    }
}
