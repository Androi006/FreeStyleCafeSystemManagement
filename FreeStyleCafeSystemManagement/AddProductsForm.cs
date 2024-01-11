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
using System.Xml.Linq;

namespace FreeStyleCafeSystemManagement
{
    public partial class AddProductsForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dtb;
        public AddProductsForm()
        {
            InitializeComponent();
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freeStyleDataSet1.fsproducts' table. You can move, or remove it, as needed.
            this.fsproductsTableAdapter1.Fill(this.freeStyleDataSet1.fsproducts);
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
        }

        private void Product_addBtn_Click(object sender, EventArgs e)
        {
            string productName = Product_name.Text;
            int quantity = Convert.ToInt32(Product_qty.Text);
            double price = Convert.ToDouble(Product_price.Text);
            DateTime today = DateTime.Today;

            InsertProduct(productName, quantity, price, today);
        }
        private void InsertProduct(string productName, int quantity, double price, DateTime today)
        {
            try
            {
                con.Open();

                string insertQuery = "INSERT INTO fsproducts (name, qty, price, dateInsert) VALUES (@Name, @Qty, @Price, @dateInsert)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.Parameters.AddWithValue("@Qty", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@dateInsert", today);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    show();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void show()
        {
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM fsproducts", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            dataGridView1.DataSource = dtb;
            con.Close();
        }
        public void clearFields()
        {
            Product_id.Text = "";
            Product_name.Text = "";
            Product_price.Text = "";
            Product_qty.Text = "";
        }

        private void Product_updateBtn_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(Product_id.Text);
            string productName = Product_name.Text;
            int quantity = Convert.ToInt32(Product_qty.Text);
            double price = Convert.ToDouble(Product_price.Text);
            DateTime today = DateTime.Today;

            UpdateProduct(productId, productName, quantity, price, today);

        }
        private void UpdateProduct(int productId, string productName, int quantity, double price, DateTime today)
        {
            try
            {
                con.Open();

                string updateQuery = "UPDATE fsproducts SET name = @Name, qty = @Qty, price = @Price WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", productName);
                    cmd.Parameters.AddWithValue("@Qty", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.Parameters.AddWithValue("@dateInsert", today);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    show();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Product_deleteBtn_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(Product_id.Text);

            DeleteProduct(productId);
        }
        private void DeleteProduct(int productId)
        {
            try
            {
                con.Open();

                string deleteQuery = "DELETE FROM fsproducts WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", productId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    show();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Product_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Product_backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }

        private void Product_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Product_searchBtn_Click(object sender, EventArgs e)
        {
            if (Product_id.Text == "")
                show();
            else
            {
                string sql = "SELECT * FROM fsproducts WHERE id= '" + Product_id.Text + "'";
                con.Open();
                da = new SqlDataAdapter(sql, con);
                dtb = new DataTable();
                da.Fill(dtb);
                dataGridView1.DataSource = dtb;
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SelecteRow = dataGridView1.Rows[index];
            Product_id.Text = SelecteRow.Cells[0].Value.ToString();
            Product_name.Text = SelecteRow.Cells[1].Value.ToString();
            Product_price.Text = SelecteRow.Cells[2].Value.ToString();
            Product_qty.Text = SelecteRow.Cells[3].Value.ToString();
        }
    }
}
