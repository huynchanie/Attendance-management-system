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
    public partial class ClassInfor : Form
    {
        SqlConnection conn;

        public ClassInfor()
        {
            InitializeComponent();
            createConnection();
            getListSubject();
        }

        private void ClassInfor_Load(object sender, EventArgs e)
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
                String sql = "SELECT c.*, s.subjectName FROM classes AS c JOIN subjects AS s ON s.subjectId = c.subjectId  INNER JOIN classStudents AS cs ON c.classId = cs.classId WHERE cs.accountId =  '" + AppData.accountId + "'";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@accountId", AppData.accountId);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvClass.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi ở displayData" + ex.Message);
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
                MessageBox.Show("An error occurred in getListSubject " + ex.Message);
            }
        }

        private void searchClass(string search)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "SELECT classes.* , subjects.subjectName FROM classes " +
                     "INNER JOIN subjects ON classes.subjectId = subjects.subjectId " +
                     "INNER JOIN classStudents AS cs ON classes.classId = cs.classId " +
                     "WHERE cs.accountId = @accountId AND " +
                     "(classes.classId LIKE @search OR classes.className LIKE @search OR " +
                     "classes.room LIKE @search OR subjects.subjectName LIKE @search)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@accountId", AppData.accountId);
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
                MessageBox.Show("Please enter search keywords!");
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                tbClassId.Text = row.Cells["classId"].Value.ToString();
                tbClassName.Text = row.Cells["className"].Value.ToString();
                cbSubject.Text = row.Cells["subjectName"].Value.ToString();


            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
