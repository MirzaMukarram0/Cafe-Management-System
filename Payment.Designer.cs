namespace CafeManagementSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            credbtn = new Button();
            mobilebtn = new Button();
            Mainmenubtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            customerleb = new Label();
            pictureBox1 = new PictureBox();
            handbutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // credbtn
            // 
            credbtn.BackColor = Color.Black;
            credbtn.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            credbtn.ForeColor = Color.Transparent;
            credbtn.Location = new Point(134, 358);
            credbtn.Margin = new Padding(4, 5, 4, 5);
            credbtn.Name = "credbtn";
            credbtn.Size = new Size(225, 43);
            credbtn.TabIndex = 27;
            credbtn.Text = "Credit / debit cards";
            credbtn.UseVisualStyleBackColor = false;
            credbtn.Click += credbtn_Click;
            // 
            // mobilebtn
            // 
            mobilebtn.BackColor = Color.Black;
            mobilebtn.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            mobilebtn.ForeColor = Color.Transparent;
            mobilebtn.Location = new Point(134, 294);
            mobilebtn.Margin = new Padding(4, 5, 4, 5);
            mobilebtn.Name = "mobilebtn";
            mobilebtn.Size = new Size(225, 43);
            mobilebtn.TabIndex = 26;
            mobilebtn.Text = "Mobile Payments";
            mobilebtn.UseVisualStyleBackColor = false;
            mobilebtn.Click += mobilebtn_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(134, 411);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
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
            label6.Location = new Point(740, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
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
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(668, 154);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 83;
            label1.Text = "Payment:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(516, 190);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(448, 242);
            dataGridView2.TabIndex = 84;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(customerleb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 48);
            panel1.TabIndex = 86;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(949, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 29);
            label3.TabIndex = 1;
            label3.Text = "x";
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
            pictureBox1.Location = new Point(0, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 548);
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // handbutton1
            // 
            handbutton1.BackColor = Color.Black;
            handbutton1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            handbutton1.ForeColor = SystemColors.ButtonFace;
            handbutton1.Location = new Point(134, 243);
            handbutton1.Name = "handbutton1";
            handbutton1.Size = new Size(225, 43);
            handbutton1.TabIndex = 87;
            handbutton1.Text = "By Hand";
            handbutton1.UseVisualStyleBackColor = false;
            handbutton1.Click += handbutton1_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(handbutton1);
            Controls.Add(panel1);
            Controls.Add(credbtn);
            Controls.Add(mobilebtn);
            Controls.Add(Mainmenubtn);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button credbtn;
        private Button mobilebtn;
        private Button Mainmenubtn;
        private Label label6;
        private Label label5;
        private Label label1;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label customerleb;
        private PictureBox pictureBox1;
        private Button handbutton1;
    }
}