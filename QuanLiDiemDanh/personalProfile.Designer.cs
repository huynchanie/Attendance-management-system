namespace QuanLiDiemDanh
{
    partial class personalProfile
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
            label11 = new Label();
            btnClearAll = new Button();
            btnUpdate = new Button();
            tbEmail = new TextBox();
            label8 = new Label();
            tbPhoneNumber = new TextBox();
            label7 = new Label();
            cbGender = new ComboBox();
            label2 = new Label();
            tbAddress = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            dateTimePickerDoB = new DateTimePicker();
            tbFullname = new TextBox();
            tbAccountId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvInfor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInfor).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(-134, 373);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 126;
            label11.Text = "Search";
            // 
            // btnClearAll
            // 
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.Location = new Point(577, 151);
            btnClearAll.Margin = new Padding(2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(182, 40);
            btnClearAll.TabIndex = 124;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(340, 151);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(206, 40);
            btnUpdate.TabIndex = 122;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Location = new Point(859, 86);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(210, 29);
            tbEmail.TabIndex = 120;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(790, 90);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 119;
            label8.Text = "Email";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            tbPhoneNumber.Cursor = Cursors.IBeam;
            tbPhoneNumber.Location = new Point(577, 86);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(176, 29);
            tbPhoneNumber.TabIndex = 118;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 90);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 117;
            label7.Text = "PhoneNumber";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(965, 26);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(104, 29);
            cbGender.TabIndex = 116;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(889, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 115;
            label2.Text = "Gender";
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Location = new Point(113, 86);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(302, 29);
            tbAddress.TabIndex = 113;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 90);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 112;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Location = new Point(-134, 306);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 111;
            label10.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(653, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 21);
            label6.TabIndex = 110;
            label6.Text = "DoB";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Format = DateTimePickerFormat.Short;
            dateTimePickerDoB.Location = new Point(715, 25);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(137, 29);
            dateTimePickerDoB.TabIndex = 109;
            // 
            // tbFullname
            // 
            tbFullname.BorderStyle = BorderStyle.FixedSingle;
            tbFullname.Location = new Point(326, 25);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(302, 29);
            tbFullname.TabIndex = 108;
            // 
            // tbAccountId
            // 
            tbAccountId.BorderStyle = BorderStyle.FixedSingle;
            tbAccountId.Cursor = Cursors.IBeam;
            tbAccountId.Location = new Point(122, 25);
            tbAccountId.Name = "tbAccountId";
            tbAccountId.Size = new Size(90, 29);
            tbAccountId.TabIndex = 107;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 105;
            label4.Text = "AccountId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 30);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 104;
            label3.Text = "FullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-134, 239);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 103;
            label1.Text = "ID";
            // 
            // dgvInfor
            // 
            dgvInfor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInfor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInfor.BackgroundColor = SystemColors.Window;
            dgvInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfor.Location = new Point(2, 227);
            dgvInfor.Name = "dgvInfor";
            dgvInfor.RowTemplate.Height = 25;
            dgvInfor.Size = new Size(1457, 408);
            dgvInfor.TabIndex = 130;
            
            // 
            // personalProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 647);
            Controls.Add(dgvInfor);
            Controls.Add(label11);
            Controls.Add(btnClearAll);
            Controls.Add(btnUpdate);
            Controls.Add(tbEmail);
            Controls.Add(label8);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label2);
            Controls.Add(tbAddress);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(tbFullname);
            Controls.Add(tbAccountId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "personalProfile";
            Text = "personalProfile";
            Load += personalProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Button btnClearAll;
        private Button btnUpdate;
        private TextBox tbEmail;
        private Label label8;
        private TextBox tbPhoneNumber;
        private Label label7;
        private ComboBox cbGender;
        private Label label2;

        private TextBox tbAddress;
        private Label label9;
        private Label label10;
        private Label label6;
        private DateTimePicker dateTimePickerDoB;
        private TextBox tbFullname;
        private TextBox tbAccountId;

        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgvInfor;
    }
}