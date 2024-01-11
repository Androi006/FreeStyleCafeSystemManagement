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
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-S8GNLDU\\SQLEXPRESS;Initial Catalog=FreeStyle;Integrated Security=True");
            con.Open();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (login_password.Text != string.Empty || login_username.Text != string.Empty)
                {
                    cmd = new SqlCommand("SELECT * FROM fsusers WHERE " +
                                        "username ='" + login_username.Text + "' " +
                                        "AND password='" + login_password.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("No user Permission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        login_username.Text = "";
                        login_password.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter valid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();

            this.Hide();
        }
    }
}
