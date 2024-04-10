using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemDanh
{
    public partial class ManagePersonalInformation : Form
    {
        SqlConnection conn;
        public ManagePersonalInformation()
        {
            InitializeComponent();
            createConnection();
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Male");
            cbRole.Items.Add("1");
            cbRole.Items.Add("0");
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            displayData();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                MessageBox.Show("An error occurred in createConnection " + ex.Message);
            }
        }
        private void displayData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT accountId,username,role,fullName, gender,dateOfBirth,address,phoneNumber,email FROM Accounts ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvUM.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in displayData" + ex.Message);
            }
        }
        private void createNewAccount()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO accounts (accountId, username, role, fullName, gender, dateOfBirth, address, phoneNumber, email) VALUES (@accountId, @username, @role, @fullName, @gender, @dateOfBirth, @address, @phoneNumber, @email)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim(); ;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tbUsername.Text.Trim();
                cmd.Parameters.Add("@role", SqlDbType.Bit).Value = cbRole.SelectedItem.ToString();
                cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = tbFullname.Text.Trim();
                cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = cbGender.SelectedItem.ToString();
                cmd.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateTimePickerDoB.Value;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = tbAddress.Text.Trim();
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = tbPhoneNumber.Text.Trim();
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text.Trim();
                //  Handles the value of the role 
                bool roleValue;
                if (cbRole.Text.Trim() == "1")
                {
                    roleValue = true;
                }
                else
                {
                    roleValue = false;
                }
                cmd.Parameters["@role"].Value = roleValue;
                //Execute the SQL statement
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createNewAccount" + ex.Message);
            }
        }
        private void updateAccount()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE accounts SET username = @username, fullName = @fullName, gender = @gender, dateOfBirth=@dateOfBirth, address = @address, phoneNumber =@phoneNumber, email=@email WHERE accountId = @accountId ";
                cmd.CommandText = sql;
                // Declare parameters and assign values to them
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim(); ;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tbUsername.Text.Trim();
                cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = tbFullname.Text.Trim();
                cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = cbGender.SelectedItem.ToString();
                cmd.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateTimePickerDoB.Value;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = tbAddress.Text.Trim();
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = tbPhoneNumber.Text.Trim();
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text.Trim();
                //Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in updateAccount" + ex.Message);

            }
        }
     
        private void deleteAccount()
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(tbAccountId.Text.Trim()))
                {
                    MessageBox.Show("Please select the cell to delete to delete.");
                    return;
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE accounts WHERE accountId = @accountId ";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in deleteAccount" + ex.Message);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewAccount();
            displayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAccount();
            displayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String AccountId = tbAccountId.Text.ToString();
            DialogResult re = MessageBox.Show("Are you sure you want to delete this " + AccountId + " record", "Confirm", MessageBoxButtons.YesNo);

            if (re == DialogResult.Yes)
            {
                deleteAccount();
                displayData();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbAccountId.Clear();
            tbUsername.Clear();
            cbRole.Text = "";
            tbFullname.Clear();
            tbAddress.Clear();
            tbPhoneNumber.Clear();
            tbEmail.Clear();
            tbSearch.Clear();
            tbAccountId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormAdmin admin = new FormAdmin();
                admin.Show();
            }
        }
        private void searchAccount(string search)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT accountId, username, role, fullName, gender, dateOfBirth, address, phoneNumber, email FROM Accounts WHERE accountId LIKE @search OR username LIKE @search OR fullName LIKE @search OR gender LIKE @search OR dateOfBirth LIKE @search OR address LIKE @search OR phoneNumber LIKE @search OR email LIKE @search";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%"); // Find any row containing the search

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvUM.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvUM.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No matching results were found");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                searchAccount(search);

            }
            else
            {
                MessageBox.Show("Please enter search keywords");
            }
        }

        private void dgvUM_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUM.Rows[e.RowIndex];
                tbAccountId.Text = row.Cells["accountId"].Value.ToString();
                tbUsername.Text = row.Cells["username"].Value.ToString();
                tbFullname.Text = row.Cells["fullName"].Value.ToString();
                cbGender.Text = row.Cells["gender"].Value.ToString();
                dateTimePickerDoB.Value = Convert.ToDateTime(row.Cells["dateOfBirth"].Value);
                tbAddress.Text = row.Cells["address"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
                tbPhoneNumber.Text = row.Cells["phoneNumber"].Value.ToString();
                btnDelete.Enabled = true;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
