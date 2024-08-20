using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            label6.Text = Class1.name;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutD_btn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void Db_btn_Click(object sender, EventArgs e)
        {
            DashboardA dashboardA = new DashboardA();
            dashboardA.Show();
            this.Hide();
        }

        private void empman_btn_Click(object sender, EventArgs e)
        {
            EmployeesManage employeesManage = new EmployeesManage();
            employeesManage.Show();
            this.Hide();
        }

        private void proman_btn_Click(object sender, EventArgs e)
        {
            ProductsMana productsMana = new ProductsMana();
            productsMana.Show();
            this.Hide();
        }

        private void disbtn_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount();
            discount.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void feedana_btn_Click(object sender, EventArgs e)
        {
            FeedAna feedAna = new FeedAna();
            feedAna.Show();
            this.Hide();
        }

        private void cusrec_btn_Click(object sender, EventArgs e)
        {
            Crecord crecord = new Crecord();
            crecord.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
