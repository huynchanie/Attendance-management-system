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
    public partial class personalProfile : Form
    {
        SqlConnection conn;

        public personalProfile()
        {
            InitializeComponent();
            createConnection();
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Male");
        }

        private void personalProfile_Load(object sender, EventArgs e)
        {
            displayData();

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
                String sql = "SELECT accountId,fullName, gender,dateOfBirth,address,phoneNumber,email FROM Accounts WHERE accounts.accountId =  '" + AppData.accountId + "'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvInfor.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in displayData" + ex.Message);
            }

        }
        private void updateInfor()
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE accounts SET fullName= @fullName,gender = @gender,dateOfBirth = @dateOfBirth,address = @address, phoneNumber =@phoneNumber, email =@email WHERE accountId =  @accountId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim();
                cmd.Parameters.Add("@fullName", SqlDbType.VarChar).Value = tbFullname.Text.Trim();
                cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = cbGender.SelectedItem.ToString();
                cmd.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateTimePickerDoB.Value;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = tbAddress.Text.Trim();
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = tbPhoneNumber.Text.Trim();
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEmail.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated data successfully");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in updateInfor" + ex.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfor();
            displayData();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            tbAccountId.Clear();
            tbFullname.Clear();
            tbPhoneNumber.Clear();
            cbGender.Text = "";
            tbEmail.Clear();
            tbAddress.Clear();
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
                FormUser user = new FormUser();
                user.Show();
            }
        }
        private void searchAccount(string search)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT accountId, fullName, gender, dateOfBirth, address, phoneNumber, email FROM Accounts " +
                     "WHERE (accountId LIKE @search OR fullName LIKE @search OR gender LIKE @search OR dateOfBirth LIKE @search OR address LIKE @search OR phoneNumber LIKE @search OR email LIKE @search) " +
                     "AND accountId = @accountId";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                cmd.Parameters.AddWithValue("@accountId", AppData.accountId);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvInfor.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvInfor.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No matching results were found");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        
    }
}
