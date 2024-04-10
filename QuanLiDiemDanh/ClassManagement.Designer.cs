namespace QuanLiDiemDanh
{
    partial class ClassManagement
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
            cbSubject = new ComboBox();
            btnClearAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            tbRoom = new TextBox();
            tbClassName = new TextBox();
            tbClassId = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            dgvClass = new DataGridView();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbSubject
            // 
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(965, 26);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(223, 29);
            cbSubject.TabIndex = 54;
            // 
            // btnClearAll
            // 
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.Location = new Point(910, 103);
            btnClearAll.Margin = new Padding(2);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(100, 40);
            btnClearAll.TabIndex = 52;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(786, 103);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 40);
            btnDelete.TabIndex = 51;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Location = new Point(656, 103);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 40);
            btnUpdate.TabIndex = 50;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(534, 103);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 40);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(410, 103);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 40);
            btnSearch.TabIndex = 48;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbRoom
            // 
            tbRoom.BorderStyle = BorderStyle.FixedSingle;
            tbRoom.Location = new Point(737, 26);
            tbRoom.Name = "tbRoom";
            tbRoom.Size = new Size(95, 29);
            tbRoom.TabIndex = 47;
            // 
            // tbClassName
            // 
            tbClassName.BorderStyle = BorderStyle.FixedSingle;
            tbClassName.Location = new Point(367, 26);
            tbClassName.Name = "tbClassName";
            tbClassName.Size = new Size(271, 29);
            tbClassName.TabIndex = 46;
            // 
            // tbClassId
            // 
            tbClassId.BorderStyle = BorderStyle.FixedSingle;
            tbClassId.Location = new Point(120, 26);
            tbClassId.Margin = new Padding(5);
            tbClassId.Name = "tbClassId";
            tbClassId.Size = new Size(113, 29);
            tbClassId.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(858, 30);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 44;
            label14.Text = "Subject";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(656, 30);
            label13.Name = "label13";
            label13.Size = new Size(52, 21);
            label13.TabIndex = 43;
            label13.Text = "Room";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(259, 30);
            label12.Name = "label12";
            label12.Size = new Size(88, 21);
            label12.TabIndex = 42;
            label12.Text = "ClassName";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 30);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 41;
            label11.Text = "ClassID";
            // 
            // dgvClass
            // 
            dgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(1, 195);
            dgvClass.Name = "dgvClass";
            dgvClass.RowTemplate.Height = 25;
            dgvClass.Size = new Size(1382, 395);
            dgvClass.TabIndex = 57;
            dgvClass.CellClick += dgvClass_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(334, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(36, 110);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(322, 29);
            tbSearch.TabIndex = 67;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(1041, 103);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(120, 40);
            btnShowAll.TabIndex = 69;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 630);
            Controls.Add(btnShowAll);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(dgvClass);
            Controls.Add(cbSubject);
            Controls.Add(btnClearAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(tbRoom);
            Controls.Add(tbClassName);
            Controls.Add(tbClassId);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ClassManagement";
            Text = "ClassManagement";
            Load += ClassManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSubject;
        private Button btnClearAll;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox tbRoom;
        private TextBox tbClassName;
        private TextBox tbClassId;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridView dgvClass;
        private PictureBox pictureBox1;
        private TextBox tbSearch;
        private Button btnShowAll;
    }
}