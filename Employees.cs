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

namespace FastFood
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            genderComboBox.SelectedIndex = 0;
            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Getting sql server connection
             SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");

            //Insert SQL logic
            con.Open();

            //variable for adding gender data into database
            bool gender = false;
            if (genderComboBox.SelectedIndex == 0)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }


            var sqlQuery = "";
            if (IfCustomerExists(con, customerIdTextBox.Text))
            {
                sqlQuery = @"UPDATE [Customer] SET [CustomerName] = '"+ nameTextBox.Text + "',[CustomerGender] = '" + gender + "' ,[CustomerEmail] '" + emailTextBox.Text + "' WHERE [CustomerId] = '" + customerIdTextBox.Text+ "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [FastFood].[dbo].[Customer] ([CustomerId],[CustomerName],[CustomerGender],[CustomerEmail]) VALUES
                                      ('" + customerIdTextBox.Text + "','" + nameTextBox.Text + "','" + gender + "','" + emailTextBox.Text + "')";
            }


            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Reading the Data
            LoadData();
            
            }

          //Record exits or no for Updating it into field
          private bool IfCustomerExists(SqlConnection con, string customerId)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 From [Customer] WHERE [CustomerId]= '" + customerId +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
           public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * From [FastFood].[dbo].[Customer]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            customerGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = customerGridView.Rows.Add();
                customerGridView.Rows[n].Cells[0].Value = item["CustomerId"].ToString();
                customerGridView.Rows[n].Cells[1].Value = item["CustomerName"].ToString();
                if ((bool)item["CustomerGender"])
                {
                    customerGridView.Rows[n].Cells[2].Value = "Male";
                }
                else
                {
                    customerGridView.Rows[n].Cells[2].Value = "Female";
                }
                customerGridView.Rows[n].Cells[3].Value = item["CustomerEmail"].ToString();
            }
        }

        private void customerGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            customerIdTextBox.Text = customerGridView.SelectedRows[0].Cells[0].Value.ToString();
            nameTextBox.Text = customerGridView.SelectedRows[0].Cells[1].Value.ToString();
            if (customerGridView.SelectedRows[0].Cells[2].Value.ToString() == "Male")
            {
                genderComboBox.SelectedIndex = 0;
            }
            else
            {
                genderComboBox.SelectedIndex = 1;
            }

            emailTextBox.Text = customerGridView.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}
