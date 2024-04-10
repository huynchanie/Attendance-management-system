namespace QuanLiDiemDanh
{
    partial class Login
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
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            tbPassword = new TextBox();
            pictureBox3 = new PictureBox();
            tbUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(170, 170, 170);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 655);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(tbUsername);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(193, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 497);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(192, 404);
            button1.Name = "button1";
            button1.Size = new Size(185, 50);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseCompatibleTextRendering = true;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(66, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Remember login";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.WhiteSmoke;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(122, 294);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Enter your password";
            tbPassword.Size = new Size(338, 31);
            tbPassword.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__1_1;
            pictureBox3.Location = new Point(66, 294);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.WhiteSmoke;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(122, 234);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter your username";
            tbUsername.Size = new Size(338, 31);
            tbUsername.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images1;
            pictureBox2.Location = new Point(66, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tải_xuống__1_1;
            pictureBox1.Location = new Point(199, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(219, 123, 36);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 45);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(526, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 5);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "Login your account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 656);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox tbPassword;
        private PictureBox pictureBox3;
        private TextBox tbUsername;
        private CheckBox checkBox1;
        private Button button1;
        private Label label2;
    }
}