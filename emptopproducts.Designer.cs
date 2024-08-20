namespace CafeManagementSystem
{
    partial class emptopproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emptopproducts));
            Mainmenubtn = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            viewlebel = new Label();
            dataGridproducts = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridproducts).BeginInit();
            SuspendLayout();
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
            Mainmenubtn.TabIndex = 65;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 68;
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
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 525);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(683, 73);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 63;
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
            label1.TabIndex = 62;
            label1.Text = "Username:";
            // 
            // viewlebel
            // 
            viewlebel.AutoSize = true;
            viewlebel.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            viewlebel.Location = new Point(635, 157);
            viewlebel.Margin = new Padding(4, 0, 4, 0);
            viewlebel.Name = "viewlebel";
            viewlebel.Size = new Size(221, 36);
            viewlebel.TabIndex = 66;
            viewlebel.Text = "View Products:";
            // 
            // dataGridproducts
            // 
            dataGridproducts.BackgroundColor = Color.White;
            dataGridproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridproducts.Location = new Point(514, 198);
            dataGridproducts.Margin = new Padding(4, 5, 4, 5);
            dataGridproducts.Name = "dataGridproducts";
            dataGridproducts.RowHeadersWidth = 62;
            dataGridproducts.RowTemplate.Height = 33;
            dataGridproducts.Size = new Size(460, 285);
            dataGridproducts.TabIndex = 64;
            dataGridproducts.CellContentClick += dataGridproducts_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(958, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 29);
            label2.TabIndex = 69;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // emptopproducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(Mainmenubtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(viewlebel);
            Controls.Add(dataGridproducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "emptopproducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "emptopproducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridproducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Mainmenubtn;
        private Panel panel1;
        private Label label7;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Label viewlebel;
        private DataGridView dataGridproducts;
        private Label label2;
    }
}