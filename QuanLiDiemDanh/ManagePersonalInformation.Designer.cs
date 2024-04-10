namespace QuanLiDiemDanh
{
    partial class ManagePersonalInformation
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbAccountId = new TextBox();
            tbUsername = new TextBox();
            tbFullname = new TextBox();
            dateTimePickerDoB = new DateTimePicker();
            label6 = new Label();
            tbAddress = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cbRole = new ComboBox();
            cbGender = new ComboBox();
            label2 = new Label();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            tbEmail = new TextBox();
            label8 = new Label();
            dgvUM = new DataGridView();
            btnClearAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "FullName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // tbAccountId
            // 
            tbAccountId.Location = new Point(45, 26);
            tbAccountId.Name = "tbAccountId";
            tbAccountId.Size = new Size(51, 29);
            tbAccountId.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.Location = new Point(226, 26);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(176, 29);
            tbUsername.TabIndex = 6;
            // 
            // tbFullname
            // 
            tbFullname.BorderStyle = BorderStyle.FixedSingle;
            tbFullname.Location = new Point(532, 26);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(302, 29);
            tbFullname.TabIndex = 7;
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Format = DateTimePickerFormat.Short;
            dateTimePickerDoB.Location = new Point(940, 26);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(137, 29);
            dateTimePickerDoB.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(878, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 9;
            label6.Text = "DoB";
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Location = new Point(414, 93);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(302, 29);
            tbAddress.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(327, 97);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 11;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Location = new Point(13, 97);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 10;
            label10.Text = "Role";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(55, 93);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(53, 29);
            cbRole.TabIndex = 18;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(212, 93);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(93, 29);
            cbGender.TabIndex = 20;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(136, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 19;
            label2.Text = "Gender";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            tbPhoneNumber.Cursor = Cursors.IBeam;
            tbPhoneNumber.Location = new Point(878, 93);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(176, 29);
            tbPhoneNumber.TabIndex = 22;
            tbPhoneNumber.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(741, 97);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 21;
            label7.Text = "PhoneNumber";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Location = new Point(1160, 93);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(210, 29);
            tbEmail.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1091, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 23;
            label8.Text = "Email";
            // 
            // dgvUM
            // 
            dgvUM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUM.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUM.Location = new Point(7, 250);
            dgvUM.Name = "dgvUM";
            dgvUM.RowTemplate.Height = 25;
            dgvUM.Size = new Size(1562, 377);
            dgvUM.TabIndex = 25;
            dgvUM.CellClick += dgvUM_CellClick_1;
            // 
            // btnClearAll
            // 
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.Location = new Point(1214, 145);
            btnClearAll.Margin = new Padding(2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(100, 40);
            btnClearAll.TabIndex = 98;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(1106, 144);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 41);
            btnDelete.TabIndex = 97;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(991, 144);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 41);
            btnUpdate.TabIndex = 96;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(693, 144);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 41);
            btnAdd.TabIndex = 95;
            btnAdd.Text = "Add personal information";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(487, 145);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(182, 40);
            btnSearch.TabIndex = 102;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(394, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(26, 156);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(402, 29);
            tbSearch.TabIndex = 103;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(1338, 144);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(100, 40);
            btnShowAll.TabIndex = 105;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ManagePersonalInformation
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1567, 630);
            Controls.Add(btnShowAll);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvUM);
            Controls.Add(tbEmail);
            Controls.Add(label8);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label2);
            Controls.Add(cbRole);
            Controls.Add(tbAddress);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(tbFullname);
            Controls.Add(tbUsername);
            Controls.Add(tbAccountId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "ManagePersonalInformation";
            Text = "Manage personal information";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUM).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbAccountId;
        private TextBox tbUsername;
        private TextBox tbFullname;
        private DateTimePicker dateTimePickerDoB;
        private Label label6;
        private TextBox tbAddress;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private ComboBox cbRole;
        private ComboBox cbGender;
        private Label label2;
        private TextBox tbPhoneNumber;
        private Label label7;
        private TextBox tbEmail;
        private Label label8;
        private DataGridView dgvUM;
        private Button btnClearAll;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Button btnShowAll;
    }
}