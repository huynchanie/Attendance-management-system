namespace QuanLiDiemDanh
{
    partial class AttedanceManagement
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
            btnAdd = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            tbNote = new TextBox();
            cbClassId = new ComboBox();
            tbAccountId = new TextBox();
            tbAttendanceId = new TextBox();
            label25 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            dateTimePickerTime = new DateTimePicker();
            label24 = new Label();
            cbStatus = new ComboBox();
            dgvAttendance = new DataGridView();
            pictureBox1 = new PictureBox();
            btnClearAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(483, 102);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 40);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(367, 102);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 40);
            btnSearch.TabIndex = 57;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(11, 102);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(301, 29);
            tbSearch.TabIndex = 56;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(1307, 25);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(228, 29);
            tbNote.TabIndex = 55;
            // 
            // cbClassId
            // 
            cbClassId.FormattingEnabled = true;
            cbClassId.Location = new Point(546, 25);
            cbClassId.Name = "cbClassId";
            cbClassId.Size = new Size(236, 29);
            cbClassId.TabIndex = 52;
            // 
            // tbAccountId
            // 
            tbAccountId.BorderStyle = BorderStyle.FixedSingle;
            tbAccountId.Location = new Point(371, 26);
            tbAccountId.Name = "tbAccountId";
            tbAccountId.Size = new Size(80, 29);
            tbAccountId.TabIndex = 51;
            // 
            // tbAttendanceId
            // 
            tbAttendanceId.Location = new Point(163, 29);
            tbAttendanceId.Name = "tbAttendanceId";
            tbAttendanceId.Size = new Size(80, 29);
            tbAttendanceId.TabIndex = 50;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(1240, 28);
            label25.Name = "label25";
            label25.Size = new Size(44, 21);
            label25.TabIndex = 48;
            label25.Text = "Note";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(812, 28);
            label22.Name = "label22";
            label22.Size = new Size(44, 21);
            label22.TabIndex = 46;
            label22.Text = "Time";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(467, 28);
            label21.Name = "label21";
            label21.Size = new Size(59, 21);
            label21.TabIndex = 45;
            label21.Text = "ClassId";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(270, 29);
            label20.Name = "label20";
            label20.Size = new Size(79, 21);
            label20.TabIndex = 44;
            label20.Text = "AccountId";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 35);
            label19.Name = "label19";
            label19.Size = new Size(101, 21);
            label19.TabIndex = 43;
            label19.Text = "AttendanceId";
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.Location = new Point(869, 25);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(127, 29);
            dateTimePickerTime.TabIndex = 63;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1022, 28);
            label24.Name = "label24";
            label24.Size = new Size(52, 21);
            label24.TabIndex = 47;
            label24.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(1086, 25);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 29);
            cbStatus.TabIndex = 64;
            // 
            // dgvAttendance
            // 
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAttendance.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(-5, 174);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 25;
            dgvAttendance.Size = new Size(1557, 444);
            dgvAttendance.TabIndex = 65;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(288, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // btnClearAll
            // 
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.Location = new Point(836, 103);
            btnClearAll.Margin = new Padding(2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(120, 40);
            btnClearAll.TabIndex = 61;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(714, 102);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 40);
            btnDelete.TabIndex = 60;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(599, 102);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 40);
            btnUpdate.TabIndex = 59;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(993, 103);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(120, 40);
            btnShowAll.TabIndex = 67;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // AttedanceManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 630);
            Controls.Add(btnShowAll);
            Controls.Add(pictureBox1);
            Controls.Add(dgvAttendance);
            Controls.Add(cbStatus);
            Controls.Add(dateTimePickerTime);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(tbNote);
            Controls.Add(cbClassId);
            Controls.Add(tbAccountId);
            Controls.Add(tbAttendanceId);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AttedanceManagement";
            Text = "AttedanceManagement";
            Load += AttedanceManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnSearch;
        private TextBox tbSearch;
        private TextBox tbNote;
        private ComboBox cbClassId;
        private TextBox tbAccountId;
        private TextBox tbAttendanceId;
        private Label label25;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private DateTimePicker dateTimePickerTime;
        private Label label24;
        private ComboBox cbStatus;
        private DataGridView dgvAttendance;
        private PictureBox pictureBox1;
        private Button btnClearAll;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnShowAll;
    }
}