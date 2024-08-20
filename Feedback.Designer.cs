namespace CafeManagementSystem
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            button1 = new Button();
            Mainmenubtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            close = new Label();
            panel3 = new Panel();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            customerleb = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(210, 253);
            button1.Name = "button1";
            button1.Size = new Size(225, 43);
            button1.TabIndex = 26;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(134, 411);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(225, 43);
            Mainmenubtn.TabIndex = 25;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(737, 84);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 3;
            label6.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(549, 80);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(646, 157);
            label1.Name = "label1";
            label1.Size = new Size(212, 31);
            label1.TabIndex = 93;
            label1.Text = "FeedBack Form:";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(959, 16);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(505, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(482, 356);
            panel3.TabIndex = 96;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 122);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 109);
            textBox4.TabIndex = 104;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 122);
            label9.Name = "label9";
            label9.Size = new Size(138, 27);
            label9.TabIndex = 103;
            label9.Text = "Description:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 28);
            textBox3.TabIndex = 102;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 55);
            label8.Name = "label8";
            label8.Size = new Size(105, 54);
            label8.TabIndex = 101;
            label8.Text = "Rating \r\nOut of 10";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 28);
            textBox1.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 97;
            label3.Text = "Enter Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(customerleb);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 48);
            panel1.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 8);
            label2.Name = "label2";
            label2.Padding = new Padding(6);
            label2.Size = new Size(355, 39);
            label2.TabIndex = 0;
            label2.Text = "FAST Cafe Management System";
            // 
            // customerleb
            // 
            customerleb.AutoSize = true;
            customerleb.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            customerleb.ForeColor = SystemColors.ButtonFace;
            customerleb.Location = new Point(604, 16);
            customerleb.Margin = new Padding(4, 0, 4, 0);
            customerleb.Name = "customerleb";
            customerleb.Size = new Size(229, 31);
            customerleb.TabIndex = 1;
            customerleb.Text = "Customer's Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 548);
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(panel1);
            Controls.Add(Mainmenubtn);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feedback";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button Mainmenubtn;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label close;
        private Panel panel3;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Label customerleb;
        private PictureBox pictureBox1;
    }
}