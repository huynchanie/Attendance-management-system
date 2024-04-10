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

namespace QuanLiDiemDanh
{
    public partial class Login : Form
    {
        SqlConnection conn;

        public Login()
        {
            InitializeComponent();
            createConnection();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Server = LAPTOP-23FANKRJ\\MSSQLSERVER01; Database=AttendanceSystem; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createConnection");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();
            //Check if the username and password have been entered
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT TOP 1 * FROM accounts WHERE username = '" + username + "' AND password = '" + password + " ' ";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AppData.isLogined = true;
                    AppData.accountId = reader["accountId"].ToString();
                    AppData.name = reader["fullName"].ToString();
                    if (Convert.ToBoolean(reader["role"]))
                    {
                        AppData.isAdmin = true;
                        MessageBox.Show("Login successfully as Admin! Hello " + AppData.name);
                    }
                    else
                    {
                        AppData.isAdmin = false;
                        MessageBox.Show("Login successfully as User! Hello " + AppData.name);
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in btnLogin" + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
