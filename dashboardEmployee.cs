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
    public partial class Reciptgenerate : Form
    {
        public Reciptgenerate()
        {
            InitializeComponent();
            label4.Text = Class1.name;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardEmployee_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpOrders orders = new EmpOrders();
            orders.Show();
            this.Hide();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void ByhandPayment_Click(object sender, EventArgs e)
        {
            ReadyOrders readyOrders = new ReadyOrders();
            readyOrders.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recipt r = new recipt();
            r.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reciptgenerate_Load(object sender, EventArgs e)
        {

        }

        private void logoutD_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void toporder_Click(object sender, EventArgs e)
        {
            emptopproducts emptopproducts = new emptopproducts();
            emptopproducts.Show();
            this.Hide();
        }

        private void empprofile_Click(object sender, EventArgs e)
        {
            EmpProfile profile = new EmpProfile();
            profile.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
