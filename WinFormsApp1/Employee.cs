using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            DisplayEmp();
        }

        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Kim\OneDrive\Documents\EMS.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=False");

        private void DisplayEmp()
        {
            try
            {
                Con.Open();
                string Query = "select * from ETBL";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing values is not allowed.");
                }
                else
                {
                    Con.Open();
                    string query = "insert into ETBL values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + comboBox2.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date + "', '" + textBox6.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + comboBox4.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Succesfuly");
                    DisplayEmp();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Con.Close(); }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DisplayEmp();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Must input Employee id");
                }
                else
                {
                    Con.Open();
                    string query = "delete from etbl where EmpId= '" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record has been succesfully deleted");
                    DisplayEmp();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox6.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox4.Text = " ";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); ;
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); ;
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); ;
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); ;
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); ;
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString(); ;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("Missing values is not allowed.");
                }
                else
                {
                    Con.Open();
                    string query = "update ETBL set EmpId='" + textBox1.Text + "', EmpName = '" + textBox2.Text + "', EmpAdd= '" + textBox3.Text + "', EmpPos= '" + comboBox2.SelectedItem.ToString() + "', EmpDob= '" + dateTimePicker1.Value.Date + "', EmpPhone='" + textBox6.Text + "', EmpGen= '" + comboBox1.SelectedItem.ToString() + "', EmpEdu= '" + comboBox4.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Update Succesfuly");
                    DisplayEmp();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
