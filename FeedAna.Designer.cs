namespace CafeManagementSystem
{
    partial class FeedAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedAna));
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            close = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(284, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 3;
            label6.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 36);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(134, 411);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(243, 48);
            button1.TabIndex = 5;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(949, 17);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(442, 55);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 588);
            panel3.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 319);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 31);
            label3.TabIndex = 88;
            label3.Text = "Rating Count\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 86;
            label1.Text = "Feedback Analysis";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 143);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 161);
            dataGridView1.TabIndex = 87;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(68, 356);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(468, 114);
            dataGridView2.TabIndex = 85;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(611, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 1;
            label2.Text = "Admin's Portal";
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
            pictureBox1.Location = new Point(0, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 516);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // FeedAna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FeedAna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FeedAna";
            Load += FeedAna_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button button1;
        private Label close;
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox1;
    }
}