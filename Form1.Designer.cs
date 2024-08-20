namespace CafeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            close = new Label();
            label2 = new Label();
            label3 = new Label();
            loginUsername = new TextBox();
            label4 = new Label();
            loginPassword = new TextBox();
            loginSP = new CheckBox();
            loginbtn = new Button();
            loginregbtn = new Button();
            label6 = new Label();
            Rolelebel = new Label();
            RolecomboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold, GraphicsUnit.Point);
            close.Location = new Point(764, 2);
            close.Name = "close";
            close.Size = new Size(36, 45);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(658, 9);
            label2.Name = "label2";
            label2.Size = new Size(171, 36);
            label2.TabIndex = 2;
            label2.Text = "LOGIN IN";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(681, 216);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 3;
            label3.Text = "Username:\r\n";
            label3.Click += label3_Click;
            // 
            // loginUsername
            // 
            loginUsername.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginUsername.Location = new Point(598, 246);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(307, 33);
            loginUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(681, 282);
            label4.Name = "label4";
            label4.Size = new Size(116, 27);
            label4.TabIndex = 5;
            label4.Text = "Password:\r\n";
            label4.Click += label4_Click;
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginPassword.Location = new Point(601, 312);
            loginPassword.Name = "loginPassword";
            loginPassword.PasswordChar = '*';
            loginPassword.Size = new Size(304, 33);
            loginPassword.TabIndex = 6;
            loginPassword.TextChanged += loginPassword_TextChanged;
            // 
            // loginSP
            // 
            loginSP.AutoSize = true;
            loginSP.Location = new Point(658, 351);
            loginSP.Name = "loginSP";
            loginSP.Size = new Size(158, 29);
            loginSP.TabIndex = 7;
            loginSP.Text = "See password:";
            loginSP.UseVisualStyleBackColor = true;
            loginSP.CheckedChanged += loginSP_CheckedChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Black;
            loginbtn.ForeColor = SystemColors.ButtonHighlight;
            loginbtn.Location = new Point(676, 386);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(140, 41);
            loginbtn.TabIndex = 8;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click_1;
            // 
            // loginregbtn
            // 
            loginregbtn.BackColor = Color.Black;
            loginregbtn.ForeColor = SystemColors.ButtonHighlight;
            loginregbtn.Location = new Point(676, 460);
            loginregbtn.Name = "loginregbtn";
            loginregbtn.Size = new Size(140, 41);
            loginregbtn.TabIndex = 9;
            loginregbtn.Text = "REGISTER";
            loginregbtn.UseVisualStyleBackColor = false;
            loginregbtn.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(658, 432);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 11;
            label6.Text = "Create an Account?";
            // 
            // Rolelebel
            // 
            Rolelebel.AutoSize = true;
            Rolelebel.BackColor = Color.Transparent;
            Rolelebel.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Rolelebel.ForeColor = SystemColors.ActiveCaptionText;
            Rolelebel.Location = new Point(658, 150);
            Rolelebel.Name = "Rolelebel";
            Rolelebel.Size = new Size(186, 27);
            Rolelebel.TabIndex = 12;
            Rolelebel.Text = "Select Your Role:\r\n";
            Rolelebel.Click += Rolelebel_Click;
            // 
            // RolecomboBox1
            // 
            RolecomboBox1.FormattingEnabled = true;
            RolecomboBox1.Items.AddRange(new object[] { "Administrator", "Employee", "Customer" });
            RolecomboBox1.Location = new Point(598, 180);
            RolecomboBox1.Name = "RolecomboBox1";
            RolecomboBox1.Size = new Size(307, 33);
            RolecomboBox1.TabIndex = 13;
            RolecomboBox1.SelectedIndexChanged += RolecomboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 521);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Padding = new Padding(6);
            label1.Size = new Size(355, 39);
            label1.TabIndex = 0;
            label1.Text = "FAST Cafe Management System";
            label1.Click += label1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(958, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 29);
            label5.TabIndex = 16;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(panel1);
            Controls.Add(RolecomboBox1);
            Controls.Add(Rolelebel);
            Controls.Add(label6);
            Controls.Add(loginregbtn);
            Controls.Add(loginbtn);
            Controls.Add(loginSP);
            Controls.Add(loginPassword);
            Controls.Add(label4);
            Controls.Add(loginUsername);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label close;
        private Label label2;
        private Label label3;
        private TextBox loginUsername;
        private Label label4;
        private TextBox loginPassword;
        private CheckBox loginSP;
        private Button loginbtn;
        private Button loginregbtn;
        private Label label6;
        private Label Rolelebel;
        private ComboBox RolecomboBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label5;
    }
}