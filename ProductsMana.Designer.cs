namespace CafeManagementSystem
{
    partial class ProductsMana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsMana));
            procatbtn = new Label();
            dataGridView1 = new DataGridView();
            PriceBox = new TextBox();
            Descbox = new TextBox();
            Namebox = new TextBox();
            Idbox = new TextBox();
            proprice = new Label();
            ProDescbtn = new Label();
            pronamebtn = new Label();
            productIDbtn = new Label();
            closebtn = new Label();
            Searchbtn = new Button();
            Editbtn = new Button();
            removebtn = new Button();
            Addbtn = new Button();
            Mainmenubtn = new Button();
            countbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            clearbtn = new Button();
            comboBox1 = new ComboBox();
            inventorybox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            close = new Label();
            label2 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // procatbtn
            // 
            procatbtn.AutoSize = true;
            procatbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            procatbtn.Location = new Point(506, 287);
            procatbtn.Margin = new Padding(4, 0, 4, 0);
            procatbtn.Name = "procatbtn";
            procatbtn.Size = new Size(182, 25);
            procatbtn.TabIndex = 41;
            procatbtn.Text = "Product Category:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(506, 426);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 109);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PriceBox
            // 
            PriceBox.Location = new Point(700, 202);
            PriceBox.Margin = new Padding(4, 5, 4, 5);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(274, 31);
            PriceBox.TabIndex = 38;
            // 
            // Descbox
            // 
            Descbox.Location = new Point(701, 327);
            Descbox.Margin = new Padding(4, 5, 4, 5);
            Descbox.Multiline = true;
            Descbox.Name = "Descbox";
            Descbox.Size = new Size(273, 49);
            Descbox.TabIndex = 37;
            // 
            // Namebox
            // 
            Namebox.Location = new Point(700, 160);
            Namebox.Margin = new Padding(4, 5, 4, 5);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(274, 31);
            Namebox.TabIndex = 36;
            // 
            // Idbox
            // 
            Idbox.Location = new Point(700, 118);
            Idbox.Margin = new Padding(4, 5, 4, 5);
            Idbox.Name = "Idbox";
            Idbox.Size = new Size(274, 31);
            Idbox.TabIndex = 35;
            // 
            // proprice
            // 
            proprice.AutoSize = true;
            proprice.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            proprice.Location = new Point(506, 205);
            proprice.Margin = new Padding(4, 0, 4, 0);
            proprice.Name = "proprice";
            proprice.Size = new Size(146, 25);
            proprice.TabIndex = 34;
            proprice.Text = "Product Price:";
            proprice.Click += proprice_Click;
            // 
            // ProDescbtn
            // 
            ProDescbtn.AutoSize = true;
            ProDescbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ProDescbtn.Location = new Point(506, 325);
            ProDescbtn.Margin = new Padding(4, 0, 4, 0);
            ProDescbtn.Name = "ProDescbtn";
            ProDescbtn.Size = new Size(126, 50);
            ProDescbtn.TabIndex = 33;
            ProDescbtn.Text = "Product \r\nDescription:";
            // 
            // pronamebtn
            // 
            pronamebtn.AutoSize = true;
            pronamebtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            pronamebtn.Location = new Point(506, 160);
            pronamebtn.Margin = new Padding(4, 0, 4, 0);
            pronamebtn.Name = "pronamebtn";
            pronamebtn.Size = new Size(157, 25);
            pronamebtn.TabIndex = 32;
            pronamebtn.Text = "Product Name:";
            // 
            // productIDbtn
            // 
            productIDbtn.AutoSize = true;
            productIDbtn.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            productIDbtn.Location = new Point(506, 123);
            productIDbtn.Margin = new Padding(4, 0, 4, 0);
            productIDbtn.Name = "productIDbtn";
            productIDbtn.Size = new Size(124, 25);
            productIDbtn.TabIndex = 31;
            productIDbtn.Text = "Product ID:";
            // 
            // closebtn
            // 
            closebtn.AutoSize = true;
            closebtn.ForeColor = SystemColors.ButtonFace;
            closebtn.Location = new Point(1386, 8);
            closebtn.Margin = new Padding(4, 0, 4, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(23, 25);
            closebtn.TabIndex = 2;
            closebtn.Text = "X";
            closebtn.Click += closebtn_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.Black;
            Searchbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Searchbtn.ForeColor = Color.Transparent;
            Searchbtn.Location = new Point(256, 304);
            Searchbtn.Margin = new Padding(4, 5, 4, 5);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(226, 43);
            Searchbtn.TabIndex = 29;
            Searchbtn.Text = "View Product";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.Black;
            Editbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Editbtn.ForeColor = Color.Transparent;
            Editbtn.Location = new Point(13, 357);
            Editbtn.Margin = new Padding(4, 5, 4, 5);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(226, 43);
            Editbtn.TabIndex = 28;
            Editbtn.Text = "Edit Product";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Black;
            removebtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removebtn.ForeColor = Color.Transparent;
            removebtn.Location = new Point(256, 357);
            removebtn.Margin = new Padding(4, 5, 4, 5);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(226, 43);
            removebtn.TabIndex = 27;
            removebtn.Text = "Remove Product\r\n";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Black;
            Addbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.Transparent;
            Addbtn.Location = new Point(13, 410);
            Addbtn.Margin = new Padding(4, 5, 4, 5);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(226, 43);
            Addbtn.TabIndex = 26;
            Addbtn.Text = "Add Product";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(13, 304);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(226, 43);
            Mainmenubtn.TabIndex = 25;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // countbtn
            // 
            countbtn.BackColor = Color.Black;
            countbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            countbtn.ForeColor = Color.Transparent;
            countbtn.Location = new Point(256, 410);
            countbtn.Margin = new Padding(4, 5, 4, 5);
            countbtn.Name = "countbtn";
            countbtn.Size = new Size(226, 43);
            countbtn.TabIndex = 30;
            countbtn.Text = "Count Products";
            countbtn.UseVisualStyleBackColor = false;
            countbtn.Click += countbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(739, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 27);
            label6.TabIndex = 3;
            label6.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(539, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 31);
            label5.TabIndex = 2;
            label5.Text = "Username:";
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.Black;
            clearbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearbtn.ForeColor = SystemColors.ButtonFace;
            clearbtn.Location = new Point(129, 463);
            clearbtn.Margin = new Padding(4, 5, 4, 5);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(226, 43);
            clearbtn.TabIndex = 40;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            clearbtn.Click += clearbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Coffee", "Tea", "Sandwiches", "Smoothies", "Juices", "Desserts", "Breakfast Items", "Snacks" });
            comboBox1.Location = new Point(701, 283);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 33);
            comboBox1.TabIndex = 44;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // inventorybox
            // 
            inventorybox.Location = new Point(700, 242);
            inventorybox.Margin = new Padding(4, 5, 4, 5);
            inventorybox.Name = "inventorybox";
            inventorybox.Size = new Size(274, 31);
            inventorybox.TabIndex = 45;
            inventorybox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(506, 248);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 46;
            label1.Text = "Product Quantity:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(close);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 70;
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
            close.TabIndex = 3;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(611, 17);
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
            label7.Padding = new Padding(6, 7, 6, 7);
            label7.Size = new Size(355, 41);
            label7.TabIndex = 0;
            label7.Text = "FAST Cafe Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 765);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(663, 390);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 71;
            label3.Text = "Products";
            // 
            // ProductsMana
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(countbtn);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(Searchbtn);
            Controls.Add(inventorybox);
            Controls.Add(Editbtn);
            Controls.Add(comboBox1);
            Controls.Add(removebtn);
            Controls.Add(Addbtn);
            Controls.Add(Mainmenubtn);
            Controls.Add(procatbtn);
            Controls.Add(dataGridView1);
            Controls.Add(PriceBox);
            Controls.Add(Descbox);
            Controls.Add(Namebox);
            Controls.Add(Idbox);
            Controls.Add(proprice);
            Controls.Add(ProDescbtn);
            Controls.Add(pronamebtn);
            Controls.Add(productIDbtn);
            Controls.Add(clearbtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductsMana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsMana";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label procatbtn;
        private DataGridView dataGridView1;
        private TextBox PriceBox;
        private TextBox Descbox;
        private TextBox Namebox;
        private TextBox Idbox;
        private Label proprice;
        private Label ProDescbtn;
        private Label pronamebtn;
        private Label productIDbtn;
        private Button Searchbtn;
        private Button Editbtn;
        private Button removebtn;
        private Button Addbtn;
        private Button Mainmenubtn;
        private Label label6;
        private Label label5;
        private Button clearbtn;
        private Label closebtn;
        private ComboBox comboBox1;
        private Button countbtn;
        private TextBox inventorybox;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label3;
        private Label close;
    }
}