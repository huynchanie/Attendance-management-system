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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

            this.Hide();
            ManagePersonalInformation userManagement = new ManagePersonalInformation();
            userManagement.FormClosed += (s, args) => this.Show();
            userManagement.Show();
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassManagement classManagement = new ClassManagement();
            classManagement.FormClosed += (s, args) => this.Show();
            classManagement.Show();
        }

        private void btnSubjectManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectManagement subjectManagement = new SubjectManagement();
            subjectManagement.FormClosed += (s, args) => this.Show();
            subjectManagement.Show();
        }

        private void btnAttendanceManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttedanceManagement attedanceManagement = new AttedanceManagement();
            attedanceManagement.FormClosed += (s, args) => this.Show();
            attedanceManagement.Show();
        }

        private void btnManageClassForStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageClassInformationForStudentss manageClassInformationForStudentss = new ManageClassInformationForStudentss();
            manageClassInformationForStudentss.FormClosed += (s, args) => this.Show();
            manageClassInformationForStudentss.Show();
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
