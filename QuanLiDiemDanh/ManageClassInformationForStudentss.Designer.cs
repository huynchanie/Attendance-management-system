namespace QuanLiDiemDanh
{
    partial class ManageClassInformationForStudentss
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
            label2 = new Label();
            tbAccountId = new TextBox();
            label3 = new Label();
            cbClassId = new ComboBox();
            dgv = new DataGridView();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            tbID = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "AccountId";
            // 
            // tbAccountId
            // 
            tbAccountId.Location = new Point(299, 29);
            tbAccountId.Margin = new Padding(4);
            tbAccountId.Name = "tbAccountId";
            tbAccountId.Size = new Size(97, 29);
            tbAccountId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 5;
            label3.Text = "ClassID";
            // 
            // cbClassId
            // 
            cbClassId.FormattingEnabled = true;
            cbClassId.Location = new Point(526, 30);
            cbClassId.Margin = new Padding(4);
            cbClassId.Name = "cbClassId";
            cbClassId.Size = new Size(355, 29);
            cbClassId.TabIndex = 4;
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = SystemColors.ButtonFace;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(8, 164);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(1285, 435);
            dgv.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(326, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(28, 100);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(322, 29);
            tbSearch.TabIndex = 74;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(526, 93);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 40);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(402, 93);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 40);
            btnSearch.TabIndex = 69;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(56, 26);
            tbID.Margin = new Padding(4);
            tbID.Name = "tbID";
            tbID.Size = new Size(108, 29);
            tbID.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 78;
            label4.Text = "ID";
            // 
            // ManageClassInformationForStudentss
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 639);
            Controls.Add(tbID);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(dgv);
            Controls.Add(label3);
            Controls.Add(cbClassId);
            Controls.Add(tbAccountId);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ManageClassInformationForStudentss";
            Text = "ManageClassInformationForStudentss";
            Load += ManageClassInformationForStudentss_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbAccountId;
        private Label label3;
        private ComboBox cbClassId;
        private DataGridView dgv;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox tbID;
        private Label label4;
    }
}