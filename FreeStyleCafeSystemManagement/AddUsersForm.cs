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
    }
}
