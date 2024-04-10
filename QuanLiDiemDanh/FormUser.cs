using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDiemDanh
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPersonalInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalProfile personalProfile = new personalProfile();
            personalProfile.FormClosed += (s, args) => this.Show();
            personalProfile.Show();
        }

        private void btnClassInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassInfor classInfor = new ClassInfor();
            classInfor.FormClosed += (s, args) => this.Show();
            classInfor.Show();
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceReport attendanceReport = new AttendanceReport();
            attendanceReport.FormClosed += (s, args) => this.Show();
            attendanceReport.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
