namespace CafeManagementSystem
{
    partial class recipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recipt));
            reciptbtn = new Button();
            Mainmenubtn = new Button();
            label4 = new Label();
            label1 = new Label();
            ReciptGrid = new DataGridView();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            close = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ReciptGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // reciptbtn
            // 
            reciptbtn.BackColor = Color.Black;
            reciptbtn.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reciptbtn.ForeColor = SystemColors.ButtonFace;
            reciptbtn.Location = new Point(611, 311);
            reciptbtn.Margin = new Padding(4, 5, 4, 5);
            reciptbtn.Name = "reciptbtn";
            reciptbtn.Size = new Size(243, 48);
            reciptbtn.TabIndex = 28;
            reciptbtn.Text = "Generate Recipt";
            reciptbtn.UseVisualStyleBackColor = false;
            reciptbtn.Click += reciptbtn_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = SystemColors.ButtonFace;
            Mainmenubtn.Location = new Point(134, 411);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(243, 48);
            Mainmenubtn.TabIndex = 26;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(678, 69);
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
            label1.Location = new Point(514, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // ReciptGrid
            // 
            ReciptGrid.BackgroundColor = Color.White;
            ReciptGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReciptGrid.Location = new Point(538, 157);
            ReciptGrid.Margin = new Padding(4, 5, 4, 5);
            ReciptGrid.Name = "ReciptGrid";
            ReciptGrid.RowHeadersWidth = 62;
            ReciptGrid.RowTemplate.Height = 33;
            ReciptGrid.Size = new Size(409, 144);
            ReciptGrid.TabIndex = 8;
            ReciptGrid.CellContentClick += dataGridOrders_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(687, 116);
            label5.Name = "label5";
            label5.Size = new Size(108, 36);
            label5.TabIndex = 9;
            label5.Text = "Orders";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(538, 421);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(409, 108);
            dataGridView1.TabIndex = 62;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(678, 373);
            label6.Name = "label6";
            label6.Size = new Size(117, 36);
            label6.TabIndex = 63;
            label6.Text = "Recipts";
            label6.Click += label6_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(958, 8);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 64;
            close.Text = "x";
            close.UseWaitCursor = true;
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 66;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(611, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(232, 31);
            label3.TabIndex = 3;
            label3.Text = "Employee's Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 525);
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // recipt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(reciptbtn);
            Controls.Add(Mainmenubtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(ReciptGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "recipt";
            Load += recipt_Load;
            ((System.ComponentModel.ISupportInitialize)ReciptGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Mainmenubtn;
        private Label label4;
        private Label label1;
        private DataGridView ReciptGrid;
        private Button reciptbtn;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label close;
        private Panel panel1;
        private Label label7;
        private Label label3;
        private PictureBox pictureBox1;
    }
}