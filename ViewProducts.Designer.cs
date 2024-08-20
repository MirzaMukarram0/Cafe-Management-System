namespace CafeManagementSystem
{
    partial class ViewProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            clearbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            coutbtn = new Button();
            checkbtn = new Button();
            removebtn = new Button();
            addbtn = new Button();
            close = new Label();
            viewlebel = new Label();
            dataGridView1 = new DataGridView();
            quantity = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            quantitybox = new TextBox();
            label3 = new Label();
            totalprice = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            customerleb = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // clearbtn
            // 
            clearbtn.BackColor = SystemColors.ActiveCaptionText;
            clearbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            clearbtn.ForeColor = SystemColors.ButtonFace;
            clearbtn.Location = new Point(539, 493);
            clearbtn.Margin = new Padding(4, 5, 4, 5);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(109, 43);
            clearbtn.TabIndex = 56;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(740, 72);
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
            label5.Location = new Point(549, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(256, 410);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(226, 43);
            button1.TabIndex = 30;
            button1.Text = "Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // coutbtn
            // 
            coutbtn.BackColor = SystemColors.ActiveCaptionText;
            coutbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            coutbtn.ForeColor = SystemColors.ButtonFace;
            coutbtn.Location = new Point(721, 493);
            coutbtn.Margin = new Padding(4, 5, 4, 5);
            coutbtn.Name = "coutbtn";
            coutbtn.Size = new Size(226, 43);
            coutbtn.TabIndex = 29;
            coutbtn.Text = "Check out";
            coutbtn.UseVisualStyleBackColor = false;
            coutbtn.Click += coutbtn_Click;
            // 
            // checkbtn
            // 
            checkbtn.BackColor = SystemColors.ActiveCaptionText;
            checkbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            checkbtn.ForeColor = SystemColors.ButtonFace;
            checkbtn.Location = new Point(256, 342);
            checkbtn.Margin = new Padding(4, 5, 4, 5);
            checkbtn.Name = "checkbtn";
            checkbtn.Size = new Size(226, 43);
            checkbtn.TabIndex = 28;
            checkbtn.Text = "Check Products";
            checkbtn.UseVisualStyleBackColor = false;
            checkbtn.Click += checkbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = SystemColors.ActiveCaptionText;
            removebtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            removebtn.ForeColor = SystemColors.ButtonFace;
            removebtn.Location = new Point(13, 410);
            removebtn.Margin = new Padding(4, 5, 4, 5);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(226, 43);
            removebtn.TabIndex = 27;
            removebtn.Text = "Remove from Cart";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ActiveCaptionText;
            addbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = SystemColors.ButtonFace;
            addbtn.Location = new Point(13, 342);
            addbtn.Margin = new Padding(4, 5, 4, 5);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(226, 43);
            addbtn.TabIndex = 26;
            addbtn.Text = "Add to Cart";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(959, 17);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // viewlebel
            // 
            viewlebel.AutoSize = true;
            viewlebel.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            viewlebel.Location = new Point(637, 117);
            viewlebel.Margin = new Padding(4, 0, 4, 0);
            viewlebel.Name = "viewlebel";
            viewlebel.Size = new Size(194, 31);
            viewlebel.TabIndex = 58;
            viewlebel.Text = "View Products:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(539, 157);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(409, 128);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quantity.Location = new Point(539, 297);
            quantity.Margin = new Padding(4, 0, 4, 0);
            quantity.Name = "quantity";
            quantity.Size = new Size(109, 27);
            quantity.TabIndex = 60;
            quantity.Text = "Quantity:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(539, 377);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(409, 108);
            dataGridView2.TabIndex = 61;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(666, 342);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 62;
            label1.Text = "Cart Items:";
            // 
            // quantitybox
            // 
            quantitybox.Location = new Point(641, 297);
            quantitybox.Margin = new Padding(4, 5, 4, 5);
            quantitybox.Name = "quantitybox";
            quantitybox.Size = new Size(67, 31);
            quantitybox.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(744, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 27);
            label3.TabIndex = 64;
            label3.Text = "Total Price:";
            // 
            // totalprice
            // 
            totalprice.Location = new Point(880, 298);
            totalprice.Margin = new Padding(4, 5, 4, 5);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(67, 31);
            totalprice.TabIndex = 65;
            totalprice.TextChanged += totalprice_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(close);
            panel1.Controls.Add(customerleb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 48);
            panel1.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(0, 8);
            label7.Name = "label7";
            label7.Padding = new Padding(6, 7, 6, 7);
            label7.Size = new Size(355, 41);
            label7.TabIndex = 0;
            label7.Text = "FAST Cafe Management System";
            // 
            // customerleb
            // 
            customerleb.AutoSize = true;
            customerleb.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            customerleb.ForeColor = SystemColors.ButtonFace;
            customerleb.Location = new Point(604, 17);
            customerleb.Margin = new Padding(4, 0, 4, 0);
            customerleb.Name = "customerleb";
            customerleb.Size = new Size(229, 31);
            customerleb.TabIndex = 1;
            customerleb.Text = "Customer's Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 513);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(button1);
            Controls.Add(coutbtn);
            Controls.Add(totalprice);
            Controls.Add(checkbtn);
            Controls.Add(label3);
            Controls.Add(removebtn);
            Controls.Add(quantitybox);
            Controls.Add(addbtn);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(quantity);
            Controls.Add(clearbtn);
            Controls.Add(viewlebel);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ViewProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProducts";
            Load += ViewProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button clearbtn;
        private Label label6;
        private Label label5;
        private Button removebtn;
        private Button addbtn;
        private Label close;
        private Label viewlebel;
        private DataGridView dataGridView1;
        private Button checkbtn;
        private Label quantity;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox quantitybox;
        private Label label3;
        private TextBox totalprice;
        private Button coutbtn;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private Label customerleb;
        private PictureBox pictureBox1;
    }
}