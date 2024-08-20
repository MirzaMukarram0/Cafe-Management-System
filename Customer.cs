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
    public partial class catbtn : Form
    {
        public catbtn()
        {
            InitializeComponent();
            label3.Text = Class1.Id.ToString();
            adminlabel.Text = Class1.name;
        }

        private void logoutD_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            adminlabel.Text = Class1.name;
            label3.Text = Class1.Id.ToString();
        }

        private void reservationbtn_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void discountedbtn_Click(object sender, EventArgs e)
        {
            DiscountedProducts discountedProducts = new DiscountedProducts();
            discountedProducts.Show();
            this.Hide();
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void seeprofilebtn_Click(object sender, EventArgs e)
        {
            SeeProfile seeProfile = new SeeProfile();
            seeProfile.Show();
            this.Hide();
        }

        private void customerleb_Click(object sender, EventArgs e)
        {

        }
    }
}
