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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLiDiemDanh
{
    public partial class AttedanceManagement : Form
    {
        SqlConnection conn;

        public AttedanceManagement()
        {
            createConnection();
            InitializeComponent();
            getListClass();
            cbStatus.Items.Add("Present");
            cbStatus.Items.Add("Absent");
        }



        private void AttedanceManagement_Load(object sender, EventArgs e)
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
                String sql = "SELECT attendanceId, accounts.accountId,accounts.fullName, classes.classId, classes.className,classes.subjectId, attendanceTime,attendanceStatus,note FROM attendances INNER JOIN accounts ON attendances.accountId = accounts.accountId INNER JOIN classes ON attendances.classId = classes.classId ";
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dgvAttendance.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in displayData" + ex.Message);
            }
        }
        public class Classes
        {
            public String classId { get; set; }
            public String className { get; set; }

            public Classes(String _classId, String _className)
            {
                classId = _classId;
                className = _className;
            }
        }

        private void getListClass()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT classId, className FROM classes";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                List<Classes> listClass = new List<Classes>();
                while (reader.Read())
                {
                    Classes c = new Classes(reader["classId"].ToString(), reader["className"].ToString());
                    listClass.Add(c);
                }
                cbClassId.DataSource = listClass;
                cbClassId.DisplayMember = "className";
                cbClassId.ValueMember = "classId";

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in getListClass " + ex.Message);
            }

        }
        private void createNewAttendance()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO attendances VALUES (@classId, @accountId, @attendanceTime, @attendanceStatus, @note)";
                cmd.CommandText = sql;
                //Declare parameters and assign values to them
                cmd.Parameters.Add("@classId", SqlDbType.VarChar).Value = cbClassId.SelectedValue.ToString();
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim();
                cmd.Parameters.Add("@attendanceTime", SqlDbType.Date).Value = dateTimePickerTime.Value.ToString();
                cmd.Parameters.Add("@attendanceStatus", SqlDbType.VarChar).Value = cbStatus.SelectedItem.ToString();
                cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = tbNote.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createNewAttendance" + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewAttendance();
            displayData();
        }

        private void updateAttendance()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE attendances SET  classId = @classId, accountId= @accountId, attendanceTime = @attendanceTime, attendanceStatus = @attendanceStatus, note = @note WHERE attendanceId = @attendanceId";
                cmd.CommandText = sql;
                //  Declare parameters and assign values to them
                cmd.Parameters.Add("@attendanceId", SqlDbType.Int).Value = int.Parse(tbAttendanceId.Text.Trim());
                cmd.Parameters.Add("@classId", SqlDbType.VarChar).Value = cbClassId.SelectedValue.ToString();
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim();
                cmd.Parameters.Add("@attendanceTime", SqlDbType.Date).Value = dateTimePickerTime.Value.ToString();
                cmd.Parameters.Add("@attendanceStatus", SqlDbType.VarChar).Value = cbStatus.SelectedItem.ToString();
                cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = tbNote.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated data successfully");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in UpdateClass" + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAttendance();
            displayData();
        }
        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];
                tbAttendanceId.Text = row.Cells["attendanceId"].Value.ToString();
                tbAccountId.Text = row.Cells["accountId"].Value.ToString();
                cbClassId.Text = row.Cells["classId"].Value.ToString();
                dateTimePickerTime.Value = Convert.ToDateTime(row.Cells["attendanceTime"].Value);
                cbStatus.Text = row.Cells["attendanceStatus"].Value.ToString();
                tbNote.Text = row.Cells["note"].Value.ToString();
                btnDelete.Enabled = true;
            }
        }
        private void deleteAttedance()
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(tbAttendanceId.Text.Trim()))
                {
                    MessageBox.Show("Please select the cell to delete.");
                    return;
                }
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE attendances WHERE attendanceId = @attendanceId ";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@attendanceId", SqlDbType.Int);
                cmd.Parameters["@attendanceId"].Value = int.Parse(tbAttendanceId.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted data successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in deleteAttendance" + ex.Message);

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String attendanceId = tbAttendanceId.Text.ToString();
            DialogResult re = MessageBox.Show("Are you sure you want to delete this " + attendanceId + " record", "Confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                deleteAttedance();
                displayData();

            }
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

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbAttendanceId.Clear();
            cbClassId.Text = "";
            tbAccountId.Clear();
            tbNote.Clear();
            cbStatus.Text = "";
            tbSearch.Clear();
            tbAttendanceId.Focus();
        }
        private void searchAttendance(string search)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT attendances.attendanceId, accounts.accountId, accounts.fullName, classes.classId, classes.className, classes.subjectId, attendances.attendanceTime, attendances.attendanceStatus, attendances.note FROM attendances INNER JOIN accounts ON attendances.accountId = accounts.accountId  INNER JOIN classes ON attendances.classId = classes.classId WHERE attendances.attendanceId LIKE @search OR accounts.accountId LIKE @search  OR accounts.fullName LIKE @search OR classes.classId LIKE @search OR classes.className LIKE @search OR attendances.attendanceTime LIKE @search OR attendances.attendanceStatus LIKE @search OR attendances.note LIKE @search";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvAttendance.DataSource = dt;
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
                searchAttendance(search);

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
