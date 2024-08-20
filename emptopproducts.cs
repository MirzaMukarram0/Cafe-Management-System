using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class emptopproducts : Form
    {
        private SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public emptopproducts()
        {
            InitializeComponent();
            label4.Text = Class1.name;
            RefreshproductsGrid(dbconnect);
        }

        private void RefreshproductsGrid(SqlConnection dbconnect)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM productsorderedtimes", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridproducts.DataSource = dataTable;
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Reciptgenerate EmpDash = new Reciptgenerate();
            EmpDash.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
