namespace QuanLiDiemDanh
{
    partial class ClassInfor
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
            cbSubject = new ComboBox();
            tbClassName = new TextBox();
            tbClassId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClass = new DataGridView();
            tbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(391, 85);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 40);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(701, 26);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(325, 36);
            cbSubject.TabIndex = 63;
            // 
            // tbClassName
            // 
            tbClassName.Location = new Point(333, 26);
            tbClassName.Name = "tbClassName";
            tbClassName.Size = new Size(218, 34);
            tbClassName.TabIndex = 62;
            // 
            // tbClassId
            // 
            tbClassId.Location = new Point(96, 26);
            tbClassId.Name = "tbClassId";
            tbClassId.Size = new Size(78, 34);
            tbClassId.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 30);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 60;
            label3.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 30);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 59;
            label2.Text = "ClassName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 58;
            label1.Text = "ClassId";
            // 
            // dgvClass
            // 
            dgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClass.BackgroundColor = Color.White;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClass.Location = new Point(18, 161);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.RowTemplate.Height = 25;
            dgvClass.Size = new Size(1304, 489);
            dgvClass.TabIndex = 67;
            dgvClass.CellClick += dgvClass_CellClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(18, 91);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Enter search keywords";
            tbSearch.Size = new Size(354, 34);
            tbSearch.TabIndex = 68;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.icons8_search_30;
            pictureBox1.Location = new Point(338, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(545, 85);
            btnShowAll.Margin = new Padding(2);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(130, 40);
            btnShowAll.TabIndex = 70;
            btnShowAll.Text = "ShowAll";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // ClassInfor
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 662);
            Controls.Add(btnShowAll);
            Controls.Add(pictureBox1);
            Controls.Add(tbSearch);
            Controls.Add(dgvClass);
            Controls.Add(btnSearch);
            Controls.Add(cbSubject);
            Controls.Add(tbClassName);
            Controls.Add(tbClassId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ClassInfor";
            Text = "ClassInfor";
            Load += ClassInfor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private ComboBox cbSubject;
        private TextBox tbClassName;
        private TextBox tbClassId;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClass;
        private TextBox tbSearch;
        private PictureBox pictureBox1;
        private Button btnShowAll;
    }
}