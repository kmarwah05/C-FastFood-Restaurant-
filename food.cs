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
    public partial class food : Form
    {
        public food()
        {
            InitializeComponent();
        }

        private void closePicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void food_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void food_Load(object sender, EventArgs e)
        {
            foodTypeComboBox.SelectedIndex = 0;
            LoadData();

        }
        private void chefImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            chef chefPage = new chef();
            chefPage.ShowDialog();
            this.Close();
        }

        private void foodImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            food foodPage = new food();
            foodPage.ShowDialog();
            this.Close();
        }

        private void customerImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Getting sql server connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");

            //Insert SQL logic
            con.Open();

            //variable for adding gender data into database
            bool foodType = false;
            if (foodTypeComboBox.SelectedIndex == 0)
            {
                foodType = true;
            }
            else
            {
                foodType = false;
            }

            var sqlQuery = "";
            if (IfFoodExists(con, foodIdTextBox.Text))
            {
                sqlQuery = @"UPDATE [Food] SET [FoodName] = '" + foodNameTextBox.Text + "',[SetPrice] = '" + setPriceTextBox.Text + "',[FoodType] = '" + foodType + "' WHERE [FoodId] = '" + foodIdTextBox.Text + "'";
                
            }
            else
            {
                sqlQuery = @"INSERT INTO [FastFood].[dbo].[Food] ([FoodId],[FoodName],[SetPrice],[FoodType]) VALUES
                                      ('" + foodIdTextBox.Text + "','" + foodNameTextBox.Text + "','" + setPriceTextBox.Text + "','" + foodType + "')";
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Reading the Data
            LoadData();
        }

        //Record exits or no for Updating it into field
        private bool IfFoodExists(SqlConnection con, string foodId)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 From [Food] WHERE [FoodId]= '" + foodId + "'", con);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * From [FastFood].[dbo].[Food]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foodGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = foodGridView.Rows.Add();
                foodGridView.Rows[n].Cells[0].Value = item["FoodId"].ToString();
                foodGridView.Rows[n].Cells[1].Value = item["FoodName"].ToString();
                foodGridView.Rows[n].Cells[2].Value = item["SetPrice"].ToString();
                if ((bool)item["FoodType"])
                {
                    foodGridView.Rows[n].Cells[3].Value = "Veg";
                }
                else
                {
                    foodGridView.Rows[n].Cells[3].Value = "Non Veg";
                }    
            }
        }

        private void foodGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foodIdTextBox.Text = foodGridView.SelectedRows[0].Cells[0].Value.ToString();
            foodNameTextBox.Text = foodGridView.SelectedRows[0].Cells[1].Value.ToString();
            setPriceTextBox.Text = foodGridView.SelectedRows[0].Cells[2].Value.ToString();
            if (foodGridView.SelectedRows[0].Cells[3].Value.ToString() == "Veg")
            {
                foodTypeComboBox.SelectedIndex = 0;
            }
            else
            {
                foodTypeComboBox.SelectedIndex = 1;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TF40D04;Initial Catalog=FastFood;Integrated Security=True");



            var sqlQuery = "";
            if (IfFoodExists(con, foodIdTextBox.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Food] WHERE [FoodId] = '" + foodIdTextBox.Text + "'";
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
