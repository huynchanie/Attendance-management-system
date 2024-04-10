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
    public partial class ManageClassInformationForStudentss : Form
    {
        SqlConnection conn;
        public ManageClassInformationForStudentss()
        {
            InitializeComponent();
            createConnection();
            getListClass();


        }

        private void ManageClassInformationForStudentss_Load(object sender, EventArgs e)
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
                MessageBox.Show("Có lỗi xảy ra ở createConnection " + ex.Message);
            }
        }
        private void displayData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT ClassStudents.*, classes.className, classes.subjectId FROM ClassStudents INNER JOIN classes ON classes.classId = ClassStudents.classId ";
                cmd.CommandText = sql;
                DataTable dt = new DataTable();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    dgv.DataSource = dt;
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


        private void AddStudentToClass()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO ClassStudents (classId, accountId) VALUES (@classId, @accountId)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@classId", SqlDbType.VarChar).Value = cbClassId.SelectedValue.ToString();
                cmd.Parameters.Add("@accountId", SqlDbType.VarChar).Value = tbAccountId.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added to class successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding student to class: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentToClass();
            displayData();
        }
        private void searchAttendance(string search)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT ClassStudents.*, classes.className, classes.subjectId FROM ClassStudents INNER JOIN classes ON classes.classId = ClassStudents.classId WHERE ClassStudents.classStudentId LIKE @search OR ClassStudents.classId LIKE @search OR ClassStudents.accountId LIKE @search OR classes.className LIKE @search\r\n";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgv.DataSource = dt;
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
    }
}
