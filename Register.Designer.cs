namespace CafeManagementSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            rsubtn = new Button();
            rcp = new CheckBox();
            passwordbox = new TextBox();
            label4 = new Label();
            fnbox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            cpasswordbox = new TextBox();
            rsibtn = new Button();
            label8 = new Label();
            label9 = new Label();
            Rolelebel = new Label();
            RolecomboBox = new ComboBox();
            label10 = new Label();
            lnbox = new TextBox();
            label11 = new Label();
            emailbox = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // rsubtn
            // 
            rsubtn.BackColor = Color.Black;
            rsubtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rsubtn.ForeColor = SystemColors.ButtonFace;
            rsubtn.Location = new Point(567, 472);
            rsubtn.Margin = new Padding(4, 5, 4, 5);
            rsubtn.Name = "rsubtn";
            rsubtn.Size = new Size(140, 55);
            rsubtn.TabIndex = 20;
            rsubtn.Text = "REGISTER";
            rsubtn.UseVisualStyleBackColor = false;
            rsubtn.Click += rsubtn_Click;
            // 
            // rcp
            // 
            rcp.AutoSize = true;
            rcp.Location = new Point(653, 422);
            rcp.Margin = new Padding(4, 5, 4, 5);
            rcp.Name = "rcp";
            rcp.Size = new Size(152, 29);
            rcp.TabIndex = 19;
            rcp.Text = "See password:";
            rcp.UseVisualStyleBackColor = true;
            rcp.CheckedChanged += rcp_CheckedChanged;
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordbox.Location = new Point(653, 331);
            passwordbox.Margin = new Padding(4, 5, 4, 5);
            passwordbox.Name = "passwordbox";
            passwordbox.PasswordChar = '*';
            passwordbox.Size = new Size(296, 33);
            passwordbox.TabIndex = 18;
            passwordbox.TextChanged += rpassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(509, 331);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 27);
            label4.TabIndex = 17;
            label4.Text = "Password:\r\n";
            // 
            // fnbox
            // 
            fnbox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fnbox.Location = new Point(653, 161);
            fnbox.Margin = new Padding(4, 5, 4, 5);
            fnbox.Name = "fnbox";
            fnbox.Size = new Size(296, 33);
            fnbox.TabIndex = 16;
            fnbox.TextChanged += firstbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(282, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 15;
            label3.Text = "First Name:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1117, -38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 31);
            label1.TabIndex = 13;
            label1.Text = "x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(504, 382);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 27);
            label5.TabIndex = 21;
            label5.Text = "Confirm\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // cpasswordbox
            // 
            cpasswordbox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cpasswordbox.Location = new Point(653, 390);
            cpasswordbox.Margin = new Padding(4, 5, 4, 5);
            cpasswordbox.Name = "cpasswordbox";
            cpasswordbox.PasswordChar = '*';
            cpasswordbox.Size = new Size(296, 33);
            cpasswordbox.TabIndex = 22;
            cpasswordbox.TextChanged += rconfirmpassword_TextChanged;
            // 
            // rsibtn
            // 
            rsibtn.BackColor = Color.Black;
            rsibtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rsibtn.ForeColor = SystemColors.ButtonFace;
            rsibtn.Location = new Point(779, 472);
            rsibtn.Margin = new Padding(4, 5, 4, 5);
            rsibtn.Name = "rsibtn";
            rsibtn.Size = new Size(140, 55);
            rsibtn.TabIndex = 24;
            rsibtn.Text = "LOGIN";
            rsibtn.UseVisualStyleBackColor = false;
            rsibtn.Click += rsibtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(715, 483);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 31);
            label8.TabIndex = 25;
            label8.Text = "OR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(1120, 0);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 27);
            label9.TabIndex = 26;
            label9.Text = "x";
            label9.Click += label9_Click;
            // 
            // Rolelebel
            // 
            Rolelebel.AutoSize = true;
            Rolelebel.BackColor = Color.Transparent;
            Rolelebel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Rolelebel.ForeColor = SystemColors.ActiveCaptionText;
            Rolelebel.Location = new Point(509, 103);
            Rolelebel.Margin = new Padding(4, 0, 4, 0);
            Rolelebel.Name = "Rolelebel";
            Rolelebel.Size = new Size(75, 27);
            Rolelebel.TabIndex = 27;
            Rolelebel.Text = "Roles:\r\n";
            // 
            // RolecomboBox
            // 
            RolecomboBox.FormattingEnabled = true;
            RolecomboBox.Items.AddRange(new object[] { "Administrator", "Customer" });
            RolecomboBox.Location = new Point(653, 102);
            RolecomboBox.Margin = new Padding(4, 5, 4, 5);
            RolecomboBox.Name = "RolecomboBox";
            RolecomboBox.Size = new Size(296, 33);
            RolecomboBox.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(504, 216);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(132, 27);
            label10.TabIndex = 29;
            label10.Text = "Last Name:\r\n";
            // 
            // lnbox
            // 
            lnbox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnbox.Location = new Point(653, 216);
            lnbox.Margin = new Padding(4, 5, 4, 5);
            lnbox.Name = "lnbox";
            lnbox.Size = new Size(296, 33);
            lnbox.TabIndex = 30;
            lnbox.TextChanged += lastbox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(422, 274);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 27);
            label11.TabIndex = 31;
            label11.Text = "Email:\r\n";
            // 
            // emailbox
            // 
            emailbox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailbox.Location = new Point(653, 270);
            emailbox.Margin = new Padding(4, 5, 4, 5);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(296, 33);
            emailbox.TabIndex = 32;
            emailbox.TextChanged += Emailbox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(-9, 9);
            label7.Name = "label7";
            label7.Padding = new Padding(6);
            label7.Size = new Size(355, 39);
            label7.TabIndex = 0;
            label7.Text = "FAST Cafe Management System";
            label7.Click += label7_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(609, 9);
            label12.Name = "label12";
            label12.Size = new Size(262, 36);
            label12.TabIndex = 35;
            label12.Text = "Resgister Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 515);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(504, 161);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(135, 27);
            label13.TabIndex = 36;
            label13.Text = "First Name:\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(504, 409);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(116, 27);
            label14.TabIndex = 37;
            label14.Text = "Password:\r\n";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(509, 276);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(80, 27);
            label15.TabIndex = 38;
            label15.Text = "Email:\r\n";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(958, 14);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 39;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(emailbox);
            Controls.Add(label11);
            Controls.Add(lnbox);
            Controls.Add(label10);
            Controls.Add(RolecomboBox);
            Controls.Add(Rolelebel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(rsibtn);
            Controls.Add(cpasswordbox);
            Controls.Add(label5);
            Controls.Add(rsubtn);
            Controls.Add(rcp);
            Controls.Add(passwordbox);
            Controls.Add(label4);
            Controls.Add(fnbox);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button rsubtn;
        private CheckBox rcp;
        private TextBox passwordbox;
        private Label label4;
        private TextBox fnbox;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox cpasswordbox;
        private Button rsibtn;
        private Label label8;
        private Label label9;
        private Label Rolelebel;
        private ComboBox RolecomboBox;
        private Label label10;
        private TextBox lnbox;
        private Label label11;
        private TextBox emailbox;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label close;
    }
}