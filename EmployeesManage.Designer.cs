namespace CafeManagementSystem
{
    partial class EmployeesManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesManage));
            label6 = new Label();
            label5 = new Label();
            Searchbtn = new Button();
            Editbtn = new Button();
            removebtn = new Button();
            Addbtn = new Button();
            Mainmenubtn = new Button();
            close = new Label();
            empID = new Label();
            empname = new Label();
            EmpAge = new Label();
            EmpPass = new Label();
            Idbox = new TextBox();
            Namebox = new TextBox();
            Agebox = new TextBox();
            PasswordBox = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Availabilitylabel = new Label();
            Availbox = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(738, 82);
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
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.Black;
            Searchbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Searchbtn.ForeColor = Color.Transparent;
            Searchbtn.Location = new Point(260, 389);
            Searchbtn.Margin = new Padding(4, 5, 4, 5);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(225, 43);
            Searchbtn.TabIndex = 29;
            Searchbtn.Text = "Search Employee\r\n";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += button1_Click;
            // 
            // Editbtn
            // 
            Editbtn.BackColor = Color.Black;
            Editbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Editbtn.ForeColor = Color.Transparent;
            Editbtn.Location = new Point(13, 389);
            Editbtn.Margin = new Padding(4, 5, 4, 5);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(225, 43);
            Editbtn.TabIndex = 28;
            Editbtn.Text = "Edit Employee";
            Editbtn.UseVisualStyleBackColor = false;
            Editbtn.Click += Editbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Black;
            removebtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removebtn.ForeColor = Color.Transparent;
            removebtn.Location = new Point(260, 336);
            removebtn.Margin = new Padding(4, 5, 4, 5);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(225, 43);
            removebtn.TabIndex = 27;
            removebtn.Text = "Remove Employee";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Black;
            Addbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.Transparent;
            Addbtn.Location = new Point(13, 336);
            Addbtn.Margin = new Padding(4, 5, 4, 5);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(225, 43);
            Addbtn.TabIndex = 26;
            Addbtn.Text = "Add Employee";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = Color.Black;
            Mainmenubtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = Color.Transparent;
            Mainmenubtn.Location = new Point(153, 454);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(225, 43);
            Mainmenubtn.TabIndex = 25;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.Black;
            close.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonFace;
            close.Location = new Point(949, 16);
            close.Margin = new Padding(4, 0, 4, 0);
            close.Name = "close";
            close.Size = new Size(25, 29);
            close.TabIndex = 1;
            close.Text = "x";
            close.Click += close_Click;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            empID.Location = new Point(506, 134);
            empID.Margin = new Padding(4, 0, 4, 0);
            empID.Name = "empID";
            empID.Size = new Size(144, 25);
            empID.TabIndex = 15;
            empID.Text = "Employee ID:";
            // 
            // empname
            // 
            empname.AutoSize = true;
            empname.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            empname.Location = new Point(506, 185);
            empname.Margin = new Padding(4, 0, 4, 0);
            empname.Name = "empname";
            empname.Size = new Size(177, 25);
            empname.TabIndex = 16;
            empname.Text = "Employee Name:";
            // 
            // EmpAge
            // 
            EmpAge.AutoSize = true;
            EmpAge.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            EmpAge.Location = new Point(506, 234);
            EmpAge.Margin = new Padding(4, 0, 4, 0);
            EmpAge.Name = "EmpAge";
            EmpAge.Size = new Size(154, 25);
            EmpAge.TabIndex = 17;
            EmpAge.Text = "Employee Age:";
            // 
            // EmpPass
            // 
            EmpPass.AutoSize = true;
            EmpPass.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            EmpPass.Location = new Point(506, 285);
            EmpPass.Margin = new Padding(4, 0, 4, 0);
            EmpPass.Name = "EmpPass";
            EmpPass.Size = new Size(108, 25);
            EmpPass.TabIndex = 19;
            EmpPass.Text = "Password:";
            // 
            // Idbox
            // 
            Idbox.Location = new Point(700, 130);
            Idbox.Margin = new Padding(4, 5, 4, 5);
            Idbox.Name = "Idbox";
            Idbox.Size = new Size(264, 31);
            Idbox.TabIndex = 20;
            // 
            // Namebox
            // 
            Namebox.Location = new Point(700, 181);
            Namebox.Margin = new Padding(4, 5, 4, 5);
            Namebox.Name = "Namebox";
            Namebox.Size = new Size(264, 31);
            Namebox.TabIndex = 21;
            // 
            // Agebox
            // 
            Agebox.Location = new Point(700, 228);
            Agebox.Margin = new Padding(4, 5, 4, 5);
            Agebox.Name = "Agebox";
            Agebox.Size = new Size(264, 31);
            Agebox.TabIndex = 22;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(700, 279);
            PasswordBox.Margin = new Padding(4, 5, 4, 5);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(264, 31);
            PasswordBox.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(506, 416);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 115);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(723, 697);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(97, 47);
            button1.TabIndex = 26;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Availabilitylabel
            // 
            Availabilitylabel.AutoSize = true;
            Availabilitylabel.Font = new Font("Garamond", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Availabilitylabel.Location = new Point(506, 336);
            Availabilitylabel.Margin = new Padding(4, 0, 4, 0);
            Availabilitylabel.Name = "Availabilitylabel";
            Availabilitylabel.Size = new Size(123, 25);
            Availabilitylabel.TabIndex = 27;
            Availabilitylabel.Text = "Availability:";
            // 
            // Availbox
            // 
            Availbox.FormattingEnabled = true;
            Availbox.Items.AddRange(new object[] { "Yes", "No" });
            Availbox.Location = new Point(700, 336);
            Availbox.Margin = new Padding(4, 5, 4, 5);
            Availbox.Name = "Availbox";
            Availbox.Size = new Size(264, 33);
            Availbox.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 47);
            panel1.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(611, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(192, 31);
            label4.TabIndex = 1;
            label4.Text = "Admin's Portal";
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
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 516);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(664, 380);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 72;
            label3.Text = "Employees";
            // 
            // EmployeesManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(label3);
            Controls.Add(Searchbtn);
            Controls.Add(close);
            Controls.Add(Editbtn);
            Controls.Add(Availbox);
            Controls.Add(removebtn);
            Controls.Add(Addbtn);
            Controls.Add(Availabilitylabel);
            Controls.Add(Mainmenubtn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(PasswordBox);
            Controls.Add(label5);
            Controls.Add(Agebox);
            Controls.Add(Namebox);
            Controls.Add(Idbox);
            Controls.Add(EmpPass);
            Controls.Add(EmpAge);
            Controls.Add(empname);
            Controls.Add(empID);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeesManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesManage";
            Load += EmployeesManage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label close;
        private Button removebtn;
        private Button Addbtn;
        private Button Mainmenubtn;
        private Button Editbtn;
        private Button Searchbtn;
        private Label empID;
        private Label empname;
        private Label EmpAge;
        private Label EmpPass;
        private TextBox Idbox;
        private TextBox Namebox;
        private TextBox Agebox;
        private TextBox PasswordBox;
        private DataGridView dataGridView1;
        private Button button1;
        private Label Availabilitylabel;
        private ComboBox Availbox;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label3;
    }
}