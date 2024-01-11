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

namespace FreeStyleCafeSystemManagement
{
    public partial class MainForm : Form
    {
        SqlConnection con;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
            UpdateProductCount();
            UpdateUserCount();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            AddProductsForm addProductForm = new AddProductsForm();
            addProductForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUsersForm addUsersForm = new AddUsersForm();
            addUsersForm.Show();

            this.Hide();
        }

        private void UpdateProductCount()
        {
            try
            {
                con.Open();
          

                    // Define your SQL query to get the count of products.
                    string sqlQuery = "SELECT COUNT(*) FROM fsproducts";

                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        // Execute the query and get the count.
                        int productCount = Convert.ToInt32(command.ExecuteScalar());

                    // Update the Text property of the label with the count.
                        total_product.Text = $"{productCount}";
                    }
                
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., show an error message).
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateUserCount()
        {
            try
            {
                con.Open();


                // Define your SQL query to get the count of products.
                string sqlQuery = "SELECT COUNT(*) FROM fsusers";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // Execute the query and get the count.
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // Update the Text property of the label with the count.
                    total_user.Text = $"{userCount}";
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., show an error message).
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
