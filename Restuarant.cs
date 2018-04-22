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
    public partial class Restuarant : Form
    {
        public Restuarant()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void homeCloseImage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clearing the fields in username and password fields
            userTextBox.Clear();
            passwordTextBox.Clear();

            userTextBox.Focus();

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            //Sign in to Home Page

            //Getting sql server connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [FastFood].[dbo].[Login] Where UserName='"+ userTextBox.Text +"' and Password='" +passwordTextBox.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                HomePage main = new HomePage();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clearButton_Click(sender, e);
            }
            
        }

        
    }
}
