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
    public partial class AttendanceReport : Form
    {
        SqlConnection conn;

        public AttendanceReport()
        {
            InitializeComponent();
            createConnection();

        }

        private void AttendanceReport_Load(object sender, EventArgs e)
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

                String sql = "SELECT attendanceId, accounts.accountId, classes.classId, classes.className,classes.subjectId, attendanceTime,attendanceStatus,note FROM attendances INNER JOIN accounts ON attendances.accountId = accounts.accountId INNER JOIN classes ON attendances.classId = classes.classId WHERE accounts.accountId =  '" + AppData.accountId + "'";
                cmd.CommandText = sql;

                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dgvAttendanceReport.DataSource = dt;
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
        private void searchAttendance(string search)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT attendances.attendanceId, accounts.accountId, classes.classId, classes.className, classes.subjectId, attendances.attendanceTime, attendances.attendanceStatus, attendances.note " +
                             "FROM attendances " +
                             "INNER JOIN accounts ON attendances.accountId = accounts.accountId " +
                             "INNER JOIN classes ON attendances.classId = classes.classId " +
                             "WHERE accounts.accountId = @accountId AND " +
                             "(accounts.accountId LIKE @search OR classes.classId LIKE @search OR classes.className LIKE @search OR attendances.attendanceTime LIKE @search OR attendances.attendanceStatus LIKE @search OR attendances.note LIKE @search)";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@accountId", AppData.accountId);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvAttendanceReport.DataSource = dt;

                if (dt.Rows.Count == 0)
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

        
    }
}
