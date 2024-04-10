namespace QuanLiDiemDanh
{
    partial class AttendanceReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            dgvAttendanceReport = new DataGridView();
            tbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(432, 11);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(138, 36);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAttendanceReport
            // 
            dgvAttendanceReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendanceReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvAttendanceReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendanceReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendanceReport.Location = new Point(12, 72);
            dgvAttendanceReport.Name = "dgvAttendanceReport";
            dgvAttendanceReport.RowHeadersWidth = 51;
            dgvAttendanceReport.RowTemplate.Height = 25;
            dgvAttendanceReport.Size = new Size(772, 426);
            dgvAttendanceReport.TabIndex = 27;
         
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(52, 13);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(354, 34);
            tbSearch.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(382, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // AttendanceReport
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 510);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(dgvAttendanceReport);
            Controls.Add(btnSearch);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AttendanceReport";
            Text = "AttendanceReport";
            Load += AttendanceReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private DataGridView dgvAttendanceReport;
        private TextBox tbSearch;
        private PictureBox pictureBox1;
    }
}