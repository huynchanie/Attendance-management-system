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
    public partial class ClassManagement : Form
    {
        SqlConnection conn;

        public ClassManagement()
        {
            InitializeComponent();
            createConnection();
            getListSubject();
        }

        private void ClassManagement_Load(object sender, EventArgs e)
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
                String sql = "SELECT * FROM classes ";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvClass.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in displayData" + ex.Message);
            }
        }
        public class subject
        {
            public String subjectId { get; set; }
            public String subjectName { get; set; }
            public subject(String _subjectId, String _subjectName)
            {
                subjectId = _subjectId;
                subjectName = _subjectName;
            }
        }
        private void getListSubject()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT * FROM subjects";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                List<subject> listSubject = new List<subject>();
                while (reader.Read())
                {
                    subject s = new subject(reader["subjectId"].ToString(), reader["subjectName"].ToString());
                    listSubject.Add(s);
                }
                cbSubject.DataSource = listSubject;
                cbSubject.DisplayMember = "subjectName";
                cbSubject.ValueMember = "subjectId";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in ở getListSubject " + ex.Message);
            }
        }
        private void createNewClass()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO classes VALUES (@classId, @className,@room,@subjectId)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@classId", SqlDbType.VarChar).Value = tbClassId.Text.Trim();
                cmd.Parameters.Add("@className", SqlDbType.VarChar).Value = tbClassName.Text.Trim();
                cmd.Parameters.Add("@room", SqlDbType.VarChar).Value = tbRoom.Text.Trim();
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar).Value = cbSubject.SelectedValue.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createNewClass" + ex.Message);
            }
        }
        private void updateClass()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE classes SET classId = @classId, className = @className, room =@room, subjectId = @subjectId WHERE classId = @classId";
                cmd.CommandText = sql;
                // Declare parameters and assign values to them
                cmd.Parameters.Add("@classId", SqlDbType.VarChar).Value = tbClassId.Text.Trim();
                cmd.Parameters.Add("@className", SqlDbType.VarChar).Value = tbClassName.Text.Trim();
                cmd.Parameters.Add("@room", SqlDbType.VarChar).Value = tbRoom.Text.Trim();
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar).Value = cbSubject.SelectedValue.ToString();
                // Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in UpdateClass" + ex.Message);
            }
        }
        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                tbClassId.Text = row.Cells["classId"].Value.ToString();
                tbClassName.Text = row.Cells["className"].Value.ToString();
                tbRoom.Text = row.Cells["room"].Value.ToString();
                btnDelete.Enabled = true;
            }
        }
        private void deleteClass()
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(tbClassId.Text.Trim()))
                {
                    MessageBox.Show("Please select the cell to delete .");
                    return;
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE classes WHERE classId = @classId ";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@classId", SqlDbType.VarChar);
                cmd.Parameters["@classId"].Value = tbClassId.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in deleteClass" + ex.Message);

            }
        }
        private void searchClass(string search)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "SELECT * FROM classes " + "INNER JOIN subjects ON classes.subjectId = subjects.subjectId " + "WHERE classId LIKE @search OR " + "className LIKE @search OR " + "room LIKE @search OR " + "subjectName LIKE @search ";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvClass.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvClass.DataSource = dt;
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
                searchClass(search);
            }
            else
            {
                MessageBox.Show("Please enter search keywords");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewClass();
            displayData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateClass();
            displayData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String classId = tbClassId.Text.ToString();
            DialogResult re = MessageBox.Show("Are you sure you want to delete this " + classId + " record", "Confirm", MessageBoxButtons.YesNo);

            if (re == DialogResult.Yes)
            {
                deleteClass();
                displayData();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbClassId.Clear();
            tbClassName.Clear();
            tbRoom.Clear();
            cbSubject.Text = "";
            tbClassId.Focus();
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
