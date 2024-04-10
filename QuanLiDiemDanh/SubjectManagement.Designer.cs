namespace QuanLiDiemDanh
{
    partial class SubjectManagement
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
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            tbSubjectName = new TextBox();
            tbSubjectId = new TextBox();
            label17 = new Label();
            label16 = new Label();
            dgvSubject = new DataGridView();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.Location = new Point(375, 153);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 42);
            btnClear.TabIndex = 49;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(257, 153);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 42);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(144, 153);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 42);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(30, 153);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 42);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(436, 80);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(203, 43);
            btnSearch.TabIndex = 45;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSubjectName
            // 
            tbSubjectName.Location = new Point(371, 19);
            tbSubjectName.Name = "tbSubjectName";
            tbSubjectName.Size = new Size(268, 29);
            tbSubjectName.TabIndex = 43;
            // 
            // tbSubjectId
            // 
            tbSubjectId.Location = new Point(108, 19);
            tbSubjectId.Name = "tbSubjectId";
            tbSubjectId.Size = new Size(107, 29);
            tbSubjectId.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(246, 23);
            label17.Name = "label17";
            label17.Size = new Size(103, 21);
            label17.TabIndex = 40;
            label17.Text = "SubjectName";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 22);
            label16.Name = "label16";
            label16.Size = new Size(74, 21);
            label16.TabIndex = 39;
            label16.Text = "SubjectId";
            // 
            // dgvSubject
            // 
            dgvSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubject.BackgroundColor = SystemColors.Window;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(0, 241);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowTemplate.Height = 25;
            dgvSubject.Size = new Size(709, 235);
            dgvSubject.TabIndex = 51;
            dgvSubject.CellClick += dgvSubject_CellClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(385, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(17, 88);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(392, 29);
            tbSearch.TabIndex = 67;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(503, 153);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(105, 42);
            btnShowAll.TabIndex = 69;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // SubjectManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 630);
            Controls.Add(btnShowAll);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(dgvSubject);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(tbSubjectName);
            Controls.Add(tbSubjectId);
            Controls.Add(label17);
            Controls.Add(label16);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SubjectManagement";
            Text = "SubjectManagement";
            Load += SubjectManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox tbSubjectName;
        private TextBox tbSubjectId;
        private Label label17;
        private Label label16;
        private DataGridView dgvSubject;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Button btnShowAll;
    }
}