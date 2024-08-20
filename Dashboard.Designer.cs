namespace CafeManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            close = new Label();
            logoutD_btn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Db_btn = new Button();
            empman_btn = new Button();
            proman_btn = new Button();
            cusrec_btn = new Button();
            feedana_btn = new Button();
            disbtn = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(949, 16);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // logoutD_btn
            // 
            logoutD_btn.BackColor = Color.Black;
            logoutD_btn.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutD_btn.ForeColor = SystemColors.ButtonFace;
            logoutD_btn.Location = new Point(134, 411);
            logoutD_btn.Margin = new Padding(4, 5, 4, 5);
            logoutD_btn.Name = "logoutD_btn";
            logoutD_btn.Size = new Size(243, 48);
            logoutD_btn.TabIndex = 4;
            logoutD_btn.Text = "Logout";
            logoutD_btn.UseVisualStyleBackColor = false;
            logoutD_btn.Click += logoutD_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(745, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 3;
            label6.Text = "Admin";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(539, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 36);
            label5.TabIndex = 2;
            label5.Text = "Username:";
           // label5.Click += this.label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(611, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 31);
            label4.TabIndex = 1;
            label4.Text = "Admin's Portal";
            label4.Click += label4_Click;
            // 
            // Db_btn
            // 
            Db_btn.BackColor = Color.Black;
            Db_btn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Db_btn.ForeColor = SystemColors.ButtonFace;
            Db_btn.Location = new Point(539, 280);
            Db_btn.Margin = new Padding(4, 5, 4, 5);
            Db_btn.Name = "Db_btn";
            Db_btn.Size = new Size(157, 68);
            Db_btn.TabIndex = 2;
            Db_btn.Text = "Dashboard";
            Db_btn.UseVisualStyleBackColor = false;
            Db_btn.Click += Db_btn_Click;
            // 
            // empman_btn
            // 
            empman_btn.BackColor = Color.Black;
            empman_btn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            empman_btn.ForeColor = SystemColors.ButtonFace;
            empman_btn.Location = new Point(780, 168);
            empman_btn.Margin = new Padding(4, 5, 4, 5);
            empman_btn.Name = "empman_btn";
            empman_btn.Size = new Size(157, 68);
            empman_btn.TabIndex = 5;
            empman_btn.Text = "Employees Management";
            empman_btn.UseVisualStyleBackColor = false;
            empman_btn.Click += empman_btn_Click;
            // 
            // proman_btn
            // 
            proman_btn.BackColor = Color.Black;
            proman_btn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            proman_btn.ForeColor = SystemColors.ButtonFace;
            proman_btn.Location = new Point(539, 168);
            proman_btn.Margin = new Padding(4, 5, 4, 5);
            proman_btn.Name = "proman_btn";
            proman_btn.Size = new Size(157, 68);
            proman_btn.TabIndex = 7;
            proman_btn.Text = "Products Management";
            proman_btn.UseVisualStyleBackColor = false;
            proman_btn.Click += proman_btn_Click;
            // 
            // cusrec_btn
            // 
            cusrec_btn.BackColor = Color.Black;
            cusrec_btn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cusrec_btn.ForeColor = SystemColors.ButtonFace;
            cusrec_btn.Location = new Point(780, 280);
            cusrec_btn.Margin = new Padding(4, 5, 4, 5);
            cusrec_btn.Name = "cusrec_btn";
            cusrec_btn.Size = new Size(157, 68);
            cusrec_btn.TabIndex = 9;
            cusrec_btn.Text = "Customers Records";
            cusrec_btn.UseVisualStyleBackColor = false;
            cusrec_btn.Click += cusrec_btn_Click;
            // 
            // feedana_btn
            // 
            feedana_btn.BackColor = Color.Black;
            feedana_btn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            feedana_btn.ForeColor = SystemColors.ButtonFace;
            feedana_btn.Location = new Point(539, 397);
            feedana_btn.Margin = new Padding(4, 5, 4, 5);
            feedana_btn.Name = "feedana_btn";
            feedana_btn.Size = new Size(157, 68);
            feedana_btn.TabIndex = 11;
            feedana_btn.Text = "Feedback Analysis";
            feedana_btn.UseVisualStyleBackColor = false;
            feedana_btn.Click += feedana_btn_Click;
            // 
            // disbtn
            // 
            disbtn.BackColor = Color.Black;
            disbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            disbtn.ForeColor = SystemColors.ButtonFace;
            disbtn.Location = new Point(780, 397);
            disbtn.Margin = new Padding(4, 5, 4, 5);
            disbtn.Name = "disbtn";
            disbtn.Size = new Size(157, 68);
            disbtn.TabIndex = 13;
            disbtn.Text = "Discounts\r\n";
            disbtn.UseVisualStyleBackColor = false;
            disbtn.Click += disbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 68;
           // panel1.Paint += this.panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 8);
            label7.Name = "label7";
            label7.Padding = new Padding(6);
            label7.Size = new Size(355, 39);
            label7.TabIndex = 0;
            label7.Text = "FAST Cafe Management System";
          //  label7.Click += this.label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 516);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(panel1);
            Controls.Add(logoutD_btn);
            Controls.Add(label6);
            Controls.Add(disbtn);
            Controls.Add(label5);
            Controls.Add(feedana_btn);
            Controls.Add(cusrec_btn);
            Controls.Add(proman_btn);
            Controls.Add(empman_btn);
            Controls.Add(Db_btn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Button logoutD_btn;
        private Label label6;
        private Label close;
        private Button Db_btn;
        private PictureBox pictureBox2;
        private Button empman_btn;
        private PictureBox pictureBox3;
        private Button proman_btn;
        private PictureBox pictureBox4;
        private Button cusrec_btn;
        private PictureBox pictureBox5;
        private Button feedana_btn;
        private PictureBox pictureBox6;
        private Button disbtn;
        private PictureBox pictureBox7;
        private Label label1;
        private Label label7;
        private Label label3;
    }
}