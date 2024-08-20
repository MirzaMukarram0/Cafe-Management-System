namespace CafeManagementSystem
{
    partial class ReadyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadyOrders));
            UpdateStatus = new Button();
            Mainmenubtn = new Button();
            label4 = new Label();
            dataGridReadyOrders = new DataGridView();
            viewlebel = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridReadyOrders).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UpdateStatus
            // 
            UpdateStatus.BackColor = SystemColors.ActiveCaptionText;
            UpdateStatus.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateStatus.ForeColor = SystemColors.ButtonFace;
            UpdateStatus.Location = new Point(626, 498);
            UpdateStatus.Margin = new Padding(4, 5, 4, 5);
            UpdateStatus.Name = "UpdateStatus";
            UpdateStatus.Size = new Size(243, 48);
            UpdateStatus.TabIndex = 28;
            UpdateStatus.Text = "Update Status";
            UpdateStatus.UseVisualStyleBackColor = false;
            UpdateStatus.Click += UpdateStatus_Click;
            // 
            // Mainmenubtn
            // 
            Mainmenubtn.BackColor = SystemColors.ActiveCaptionText;
            Mainmenubtn.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Mainmenubtn.ForeColor = SystemColors.ButtonFace;
            Mainmenubtn.Location = new Point(130, 401);
            Mainmenubtn.Margin = new Padding(4, 5, 4, 5);
            Mainmenubtn.Name = "Mainmenubtn";
            Mainmenubtn.Size = new Size(243, 48);
            Mainmenubtn.TabIndex = 27;
            Mainmenubtn.Text = "Main Menu";
            Mainmenubtn.UseVisualStyleBackColor = false;
            Mainmenubtn.Click += Mainmenubtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(683, 85);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 5;
            label4.Text = "Employee";
            // 
            // dataGridReadyOrders
            // 
            dataGridReadyOrders.BackgroundColor = Color.White;
            dataGridReadyOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReadyOrders.Location = new Point(514, 198);
            dataGridReadyOrders.Margin = new Padding(4, 5, 4, 5);
            dataGridReadyOrders.Name = "dataGridReadyOrders";
            dataGridReadyOrders.RowHeadersWidth = 62;
            dataGridReadyOrders.RowTemplate.Height = 33;
            dataGridReadyOrders.Size = new Size(460, 285);
            dataGridReadyOrders.TabIndex = 7;
            dataGridReadyOrders.CellContentClick += dataGridReadyOrders_CellContentClick;
            // 
            // viewlebel
            // 
            viewlebel.AutoSize = true;
            viewlebel.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            viewlebel.Location = new Point(651, 157);
            viewlebel.Margin = new Padding(4, 0, 4, 0);
            viewlebel.Name = "viewlebel";
            viewlebel.Size = new Size(192, 36);
            viewlebel.TabIndex = 60;
            viewlebel.Text = "View Orders:";
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
            panel1.TabIndex = 63;
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
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 525);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(514, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 64;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(949, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 29);
            label2.TabIndex = 65;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // ReadyOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(987, 555);
            Controls.Add(label1);
            Controls.Add(Mainmenubtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(UpdateStatus);
            Controls.Add(viewlebel);
            Controls.Add(dataGridReadyOrders);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReadyOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReadyOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridReadyOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button Mainmenubtn;
        private DataGridView dataGridReadyOrders;
        private Label viewlebel;
        private Button UpdateStatus;
        private Panel panel1;
        private Label label7;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}