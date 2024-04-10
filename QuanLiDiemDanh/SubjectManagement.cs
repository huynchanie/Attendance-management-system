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
    public partial class SubjectManagement : Form
    {
        SqlConnection conn;

        public SubjectManagement()
        {
            InitializeComponent();
            createConnection();

        }

        private void SubjectManagement_Load(object sender, EventArgs e)
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

                String sql = "SELECT * FROM subjects ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvSubject.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in displayData" + ex.Message);
            }
        }
        private void createNewSubject()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO subjects " + "VALUES (@subjectId, @subjectName)";
                cmd.CommandText = sql;
                //Declare parameters and assign values to them
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar).Value = tbSubjectId.Text.Trim(); ;
                cmd.Parameters.Add("@subjectName", SqlDbType.VarChar).Value = tbSubjectName.Text.Trim(); ;
                // Execute the SQL statement
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createNewSubject" + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewSubject();
            displayData();
        }
        private void updateSubject()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE subjects SET subjectId = @subjectId, subjectName = @subjectName WHERE subjectId = @subjectId";
                cmd.CommandText = sql;
                //  Declare parameters and assign values to them
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar).Value = tbSubjectId.Text.Trim(); ;
                cmd.Parameters.Add("@subjectName", SqlDbType.VarChar).Value = tbSubjectName.Text.Trim(); ;
                // Execute the SQL statement
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in UpdateSubject" + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateSubject();
            displayData();
        }
        private void dgvSubject_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubject.Rows[e.RowIndex];
                tbSubjectId.Text = row.Cells["subjectId"].Value.ToString();
                tbSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                btnDelete.Enabled = true;
            }
        }
        private void deleteSubject()
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(tbSubjectId.Text.Trim()))
                {
                    MessageBox.Show("Please select the cell to delete.");
                    return;
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE subjects WHERE subjectId = @subjectId ";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar);
                cmd.Parameters["@subjectId"].Value = tbSubjectId.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in deleteSubject" + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String subjectId = tbSubjectId.Text.Trim();
            DialogResult re = MessageBox.Show("Are you sure you want to delete this " + subjectId + " record", "Confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                deleteSubject();
                displayData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSubjectId.Clear();
            tbSubjectName.Clear();
            tbSearch.Clear();
            tbSubjectId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormAdmin admin = new FormAdmin();
                admin.Show();
                this.Hide();
            }
        }


        private void searchSubject(string search)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "SELECT * FROM Subjects WHERE subjectId LIKE @search OR subjectName LIKE @search ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvSubject.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvSubject.DataSource = dt;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Trim();
            if (!string.IsNullOrEmpty(search))
            {
                searchSubject(search);

            }
            else
            {
                MessageBox.Show("Please enter search keywords");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
