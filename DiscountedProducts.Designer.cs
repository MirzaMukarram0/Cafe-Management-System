namespace CafeManagementSystem
{
    partial class DiscountedProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountedProducts));
            totalprice = new TextBox();
            label3 = new Label();
            quantitybox = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            quantity = new Label();
            viewlebel = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            addbtn = new Button();
            coutbtn = new Button();
            checkbtn = new Button();
            removebtn = new Button();
            label6 = new Label();
            label5 = new Label();
            clearbtn = new Button();
            dataGridView3 = new DataGridView();
            label8 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            customerleb = new Label();
            pictureBox1 = new PictureBox();
            Mainmenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // totalprice
            // 
            totalprice.Location = new Point(888, 471);
            totalprice.Margin = new Padding(4, 5, 4, 5);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(75, 31);
            totalprice.TabIndex = 76;
            totalprice.TextChanged += totalprice_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(741, 470);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 31);
            label3.TabIndex = 75;
            label3.Text = "Total Price:";
            label3.Click += label3_Click;
            // 
            // quantitybox
            // 
            quantitybox.Location = new Point(629, 470);
            quantitybox.Margin = new Padding(4, 5, 4, 5);
            quantitybox.Name = "quantitybox";
            quantitybox.Size = new Size(67, 31);
            quantitybox.TabIndex = 74;
            quantitybox.TextChanged += quantitybox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(658, 317);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 73;
            label1.Text = "Cart Items:";
            label1.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(511, 353);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(452, 112);
            dataGridView2.TabIndex = 72;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            quantity.Location = new Point(511, 470);
            quantity.Margin = new Padding(4, 0, 4, 0);
            quantity.Name = "quantity";
            quantity.Size = new Size(125, 31);
            quantity.TabIndex = 71;
            quantity.Text = "Quantity:";
            quantity.Click += quantity_Click;
            // 
            // viewlebel
            // 
            viewlebel.AutoSize = true;
            viewlebel.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            viewlebel.Location = new Point(755, 131);
            viewlebel.Margin = new Padding(4, 0, 4, 0);
            viewlebel.Name = "viewlebel";
            viewlebel.Size = new Size(213, 25);
            viewlebel.TabIndex = 70;
            viewlebel.Text = "Discounted Products:";
            viewlebel.Click += viewlebel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(755, 155);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(213, 155);
            dataGridView1.TabIndex = 68;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(949, 16);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(25, 29);
            label7.TabIndex = 2;
            label7.Text = "x";
            label7.Click += label7_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = SystemColors.ActiveCaptionText;
            addbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.ForeColor = SystemColors.ButtonFace;
            addbtn.Location = new Point(257, 353);
            addbtn.Margin = new Padding(4, 5, 4, 5);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(225, 43);
            addbtn.TabIndex = 26;
            addbtn.Text = "Add to Cart";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // coutbtn
            // 
            coutbtn.BackColor = SystemColors.ActiveCaptionText;
            coutbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            coutbtn.ForeColor = SystemColors.ButtonFace;
            coutbtn.Location = new Point(776, 509);
            coutbtn.Margin = new Padding(4, 5, 4, 5);
            coutbtn.Name = "coutbtn";
            coutbtn.Size = new Size(190, 43);
            coutbtn.TabIndex = 29;
            coutbtn.Text = "Check out";
            coutbtn.UseVisualStyleBackColor = false;
            coutbtn.Click += coutbtn_Click_1;
            // 
            // checkbtn
            // 
            checkbtn.BackColor = SystemColors.ActiveCaptionText;
            checkbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkbtn.ForeColor = SystemColors.ButtonFace;
            checkbtn.Location = new Point(13, 353);
            checkbtn.Margin = new Padding(4, 5, 4, 5);
            checkbtn.Name = "checkbtn";
            checkbtn.Size = new Size(225, 43);
            checkbtn.TabIndex = 28;
            checkbtn.Text = "Check Products";
            checkbtn.UseVisualStyleBackColor = false;
            checkbtn.Click += checkbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = SystemColors.ActiveCaptionText;
            removebtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removebtn.ForeColor = SystemColors.ButtonFace;
            removebtn.Location = new Point(13, 411);
            removebtn.Margin = new Padding(4, 5, 4, 5);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(225, 43);
            removebtn.TabIndex = 27;
            removebtn.Text = "Remove from Cart";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click_1;
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
            label6.Click += label6_Click;
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
            label5.Click += label5_Click;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = SystemColors.ActiveCaptionText;
            clearbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearbtn.ForeColor = SystemColors.ButtonFace;
            clearbtn.Location = new Point(511, 511);
            clearbtn.Margin = new Padding(4, 5, 4, 5);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(109, 38);
            clearbtn.TabIndex = 69;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(511, 155);
            dataGridView3.Margin = new Padding(4, 5, 4, 5);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(213, 155);
            dataGridView3.TabIndex = 77;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(511, 131);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(229, 25);
            label8.TabIndex = 78;
            label8.Text = "Avg for Discount Type:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(customerleb);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 48);
            panel1.TabIndex = 80;
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
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 548);
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(257, 411);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(225, 43);
            Mainmenubtn.TabIndex = 81;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // DiscountedProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(Mainmenubtn);
            Controls.Add(label6);
            Controls.Add(coutbtn);
            Controls.Add(label5);
            Controls.Add(checkbtn);
            Controls.Add(removebtn);
            Controls.Add(label8);
            Controls.Add(addbtn);
            Controls.Add(dataGridView3);
            Controls.Add(totalprice);
            Controls.Add(label3);
            Controls.Add(quantitybox);
            Controls.Add(label1);
            Controls.Add(quantity);
            Controls.Add(viewlebel);
            Controls.Add(dataGridView1);
            Controls.Add(clearbtn);
            Controls.Add(dataGridView2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DiscountedProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountedProducts";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalprice;
        private Label label3;
        private TextBox quantitybox;
        private Label label1;
        private DataGridView dataGridView2;
        private Label quantity;
        private Label viewlebel;
        private DataGridView dataGridView1;
        private Button addbtn;
        private Button coutbtn;
        private Button checkbtn;
        private Button removebtn;
        private Label label6;
        private Label label5;
        private Button clearbtn;
        private Label label7;
        private DataGridView dataGridView3;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private Label customerleb;
        private PictureBox pictureBox1;
        private Button Mainmenubtn;
    }
}