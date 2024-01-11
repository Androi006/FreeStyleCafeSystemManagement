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
    public partial class AddUsersForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dtb;
        public AddUsersForm()
        {
            InitializeComponent();
        }

        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'freeStyleDataSet2.fsusers' table. You can move, or remove it, as needed.
            this.fsusersTableAdapter.Fill(this.freeStyleDataSet2.fsusers);
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");

        }

        private void User_addBtn_Click(object sender, EventArgs e)
        {
            string userName = User_name.Text;
            string role = User_role.Text;
            string password = User_password.Text;

            InsertUser(userName, role, password);
        }
        private void InsertUser(string userName, string role, string password)
        {
            try
            {
                con.Open();

                string insertQuery = "INSERT INTO fsusers (username, password, role) VALUES (@Username, @Password, @Role)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    showuser();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user");
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

        void showuser()
        {
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT * FROM fsusers", con);
            da = new SqlDataAdapter(cmd);
            dtb = new DataTable();
            da.Fill(dtb);
            dataGridView2.DataSource = dtb;
            con.Close();
        }
        public void clearFields()
        {
            User_id.Text = "";
            User_name.Text = "";
            User_password.Text = "";
            User_role.Text = "";
        }

        private void User_updateBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(User_id.Text);
            string userName = User_name.Text;
            string role = User_role.Text;
            string password = User_password.Text;

            UpdateUser(userId, userName, role, password);
        }
        private void UpdateUser(int userId, string userName, string role, string password)
        {
            try
            {
                con.Open();

                string updateQuery = "UPDATE fsusers SET username = @Name, role = @Role, password = @Password WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Name", userName);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Id", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    showuser();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user");
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

        private void User_deleteBtn_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(User_id.Text);

            DeleteUser(userId);
        }
        private void DeleteUser(int userId)
        {
            try
            {
                con.Open();

                string deleteQuery = "DELETE FROM fsusers WHERE id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    clearFields();
                    showuser();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user");
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

        private void User_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void User_backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide();
        }

        private void User_searchBtn_Click(object sender, EventArgs e)
        {
            if (User_id.Text == "")
                showuser();
            else
            {
                string sql = "SELECT * FROM fsusers WHERE id= '" + User_id.Text + "'";
                con.Open();
                da = new SqlDataAdapter(sql, con);
                dtb = new DataTable();
                da.Fill(dtb);
                dataGridView2.DataSource = dtb;
                con.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow SelecteRow = dataGridView2.Rows[index];
            User_id.Text = SelecteRow.Cells[0].Value.ToString();
            User_name.Text = SelecteRow.Cells[1].Value.ToString();
            User_role.Text = SelecteRow.Cells[3].Value.ToString();
            User_password.Text = SelecteRow.Cells[2].Value.ToString();
        }
    }
}
