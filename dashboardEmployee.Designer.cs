namespace CafeManagementSystem
{
    partial class Reciptgenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reciptgenerate));
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            Orderbtn = new Button();
            ByhandPayment = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            logoutD_btn = new Button();
            toporder = new Button();
            empprofile = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(685, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 5;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(516, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(611, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 31);
            label2.TabIndex = 3;
            label2.Text = "Employee's Portal";
            label2.Click += label2_Click;
            // 
            // Orderbtn
            // 
            Orderbtn.BackColor = Color.Black;
            Orderbtn.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Orderbtn.ForeColor = SystemColors.ButtonFace;
            Orderbtn.Location = new Point(539, 168);
            Orderbtn.Margin = new Padding(4, 5, 4, 5);
            Orderbtn.Name = "Orderbtn";
            Orderbtn.Size = new Size(157, 88);
            Orderbtn.TabIndex = 8;
            Orderbtn.Text = "Orders";
            Orderbtn.UseVisualStyleBackColor = false;
            Orderbtn.Click += button3_Click;
            // 
            // ByhandPayment
            // 
            ByhandPayment.BackColor = Color.Black;
            ByhandPayment.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ByhandPayment.ForeColor = SystemColors.ButtonFace;
            ByhandPayment.Location = new Point(761, 168);
            ByhandPayment.Margin = new Padding(4, 5, 4, 5);
            ByhandPayment.Name = "ByhandPayment";
            ByhandPayment.Size = new Size(157, 88);
            ByhandPayment.TabIndex = 9;
            ByhandPayment.Text = "By Hand Payments";
            ByhandPayment.UseVisualStyleBackColor = false;
            ByhandPayment.Click += ByhandPayment_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(539, 301);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(157, 88);
            button1.TabIndex = 10;
            button1.Text = "Generate Recipt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 35;
            panel1.Paint += panel1_Paint;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 525);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
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
            logoutD_btn.TabIndex = 36;
            logoutD_btn.Text = "Logout";
            logoutD_btn.UseVisualStyleBackColor = false;
            logoutD_btn.Click += logoutD_btn_Click;
            // 
            // toporder
            // 
            toporder.BackColor = Color.Black;
            toporder.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            toporder.ForeColor = SystemColors.ButtonFace;
            toporder.Location = new Point(761, 301);
            toporder.Margin = new Padding(4, 5, 4, 5);
            toporder.Name = "toporder";
            toporder.Size = new Size(157, 88);
            toporder.TabIndex = 37;
            toporder.Text = "Products/ Orders";
            toporder.UseVisualStyleBackColor = false;
            toporder.Click += toporder_Click;
            // 
            // empprofile
            // 
            empprofile.BackColor = Color.Black;
            empprofile.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            empprofile.ForeColor = SystemColors.ButtonFace;
            empprofile.Location = new Point(648, 425);
            empprofile.Margin = new Padding(4, 5, 4, 5);
            empprofile.Name = "empprofile";
            empprofile.Size = new Size(157, 88);
            empprofile.TabIndex = 38;
            empprofile.Text = "Emp Profile";
            empprofile.UseVisualStyleBackColor = false;
            empprofile.Click += empprofile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(958, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 29);
            label3.TabIndex = 70;
            label3.Text = "x";
            label3.Click += label3_Click;
            // 
            // Reciptgenerate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(empprofile);
            Controls.Add(toporder);
            Controls.Add(logoutD_btn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(ByhandPayment);
            Controls.Add(label1);
            Controls.Add(Orderbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reciptgenerate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardEmployee";
            Load += Reciptgenerate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label4;
        private Button Orderbtn;
        private Button ByhandPayment;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Button logoutD_btn;
        private Button toporder;
        private Button empprofile;
        private Label label3;
    }
}