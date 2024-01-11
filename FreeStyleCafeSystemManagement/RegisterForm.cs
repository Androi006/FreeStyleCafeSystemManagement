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
    public partial class RegisterForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
            con.Open();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (register_username.Text != string.Empty || register_password.Text != string.Empty || register_cPassword.Text != string.Empty)
                {
                    if (register_password.Text == register_cPassword.Text)
                    {
                        cmd = new SqlCommand("SELECT * FROM fsusers WHERE username='" + register_username.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("This User Already Exits, Please use another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("Insert INTO fsUsers VALUES(@username,@password)", con);
                            cmd.Parameters.AddWithValue("username", register_username.Text);
                            cmd.Parameters.AddWithValue("password", register_password.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your account have been created", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the same passwords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please input all repuired fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
