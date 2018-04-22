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
    public partial class chef : Form
    {
        public chef()
        {
            InitializeComponent();
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chef_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void chef_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void foodImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            food foodPage = new food();
            foodPage.ShowDialog();
            this.Close();

        }

        private void chefImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            chef chefPage = new chef();
            chefPage.ShowDialog();
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Getting sql server connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");

            //Insert SQL logic
            con.Open();


            var sqlQuery = "";
            if (IfEmployeeExists(con, employeeIdTextBox.Text))
            {
                sqlQuery = @"UPDATE [Employee] SET [EmployeeName] = '" + employeeNameTextBox.Text + "', [EmployeePhone] '" + employeePhoneTextBox.Text + "' WHERE [EmployeeId] = '" + employeeIdTextBox.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [FastFood].[dbo].[Employee]
                         ([EmployeeId],[EmployeeName],[EmployeePhone])
                         VALUES
                                   ('" + employeeIdTextBox.Text + "','" +
                                   employeeNameTextBox.Text + "','" +
                                   employeePhoneTextBox.Text + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Reading the Data
            LoadData();
        }

        //Record exits or no for Updating it into field
        private bool IfEmployeeExists(SqlConnection con, string employeeId)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 From [Employee] WHERE [EmployeeId]= '" + employeeId + "'", con);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * From [FastFood].[dbo].[Employee]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            employeeGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = employeeGridView.Rows.Add();
                employeeGridView.Rows[n].Cells[0].Value = item["EmployeeId"].ToString();
                employeeGridView.Rows[n].Cells[1].Value = item["EmployeeName"].ToString();
                employeeGridView.Rows[n].Cells[2].Value = item["EmployeePhone"].ToString();
            }
        }

        private void employeeGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            employeeIdTextBox.Text = employeeGridView.SelectedRows[0].Cells[0].Value.ToString();
            employeeNameTextBox.Text = employeeGridView.SelectedRows[0].Cells[1].Value.ToString();
            employeePhoneTextBox.Text = employeeGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");



            var sqlQuery = "";
            if (IfEmployeeExists(con, employeeIdTextBox.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Employee] WHERE [EmployeeId] = '" + employeeIdTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Not Exists....");
            }

            //Reading the Data
            LoadData();
        }
    }
}
