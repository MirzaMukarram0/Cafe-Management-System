namespace CafeManagementSystem
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            totalprice = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            Mainmenubtn = new Button();
            Orderbtn = new Button();
            addbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            clearbtn = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label2 = new Label();
            customerleb = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // totalprice
            // 
            totalprice.Location = new Point(887, 459);
            totalprice.Margin = new Padding(4, 5, 4, 5);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(88, 31);
            totalprice.TabIndex = 76;
            totalprice.TextChanged += totalprice_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(768, 463);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 75;
            label3.Text = "Total Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(670, 140);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 73;
            label1.Text = "View Cart:";
            label1.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(515, 174);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(460, 203);
            dataGridView2.TabIndex = 72;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(958, 19);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(25, 29);
            label7.TabIndex = 80;
            label7.Text = "x";
            label7.Click += label7_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(134, 411);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(251, 48);
            Mainmenubtn.TabIndex = 25;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // Orderbtn
            // 
            Orderbtn.BackColor = Color.Black;
            Orderbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Orderbtn.ForeColor = Color.Transparent;
            Orderbtn.Location = new Point(768, 493);
            Orderbtn.Margin = new Padding(4, 5, 4, 5);
            Orderbtn.Name = "Orderbtn";
            Orderbtn.Size = new Size(215, 43);
            Orderbtn.TabIndex = 27;
            Orderbtn.Text = "Order Now";
            Orderbtn.UseVisualStyleBackColor = false;
            Orderbtn.Click += Orderbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Black;
            addbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = Color.Transparent;
            addbtn.Location = new Point(134, 353);
            addbtn.Margin = new Padding(4, 5, 4, 5);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(251, 48);
            addbtn.TabIndex = 26;
            addbtn.Text = "Edit Cart";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(741, 80);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
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
            // clearbtn
            // 
            clearbtn.BackColor = Color.Black;
            clearbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            clearbtn.ForeColor = SystemColors.ButtonFace;
            clearbtn.Location = new Point(515, 491);
            clearbtn.Margin = new Padding(4, 5, 4, 5);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(123, 43);
            clearbtn.TabIndex = 69;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(515, 389);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 27);
            label8.TabIndex = 77;
            label8.Text = "Order Type:";
            label8.Click += label8_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Online Delivery", "Table Reservation" });
            comboBox1.Location = new Point(658, 387);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(customerleb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 48);
            panel1.TabIndex = 82;
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
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 548);
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(Orderbtn);
            Controls.Add(addbtn);
            Controls.Add(comboBox1);
            Controls.Add(Mainmenubtn);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(totalprice);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(clearbtn);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalprice;
        private Label label3;
        private Label label1;
        private DataGridView dataGridView2;
        private Button Mainmenubtn;
        private Button Orderbtn;
        private Button addbtn;
        private Label label6;
        private Label label5;
        private Button clearbtn;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label2;
        private Label customerleb;
        private PictureBox pictureBox1;
    }
}