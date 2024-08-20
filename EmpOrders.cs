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
    public partial class EmpOrders : Form
    {
        // private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=CafeDB;Integrated Security=True";
        private SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public EmpOrders()
        {
            InitializeComponent();
            RefreshOrderItemsGrid(dbconnect);
            label4.Text = Class1.name;

        }

        private void RefreshOrderItemsGrid(SqlConnection dbconnect)
        {
            int customerId = Class1.Id;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM PendingOrders", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridOrders.DataSource = dataTable;
        }

        private void EmpOrders_Load(object sender, EventArgs e)
        {

        }

        private void viewlebel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedRows.Count > 0)
            {
                string OrderID = dataGridOrders.SelectedRows[0].Cells["OrderId"].Value.ToString();


                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand deleteCartCommand = new SqlCommand("UPDATE Orders SET OrderStatus='READY' WHERE OrderId=@OrderId", dbconnect);
                    deleteCartCommand.Parameters.AddWithValue("@OrderId", OrderID);
                    deleteCartCommand.ExecuteNonQuery();
                    RefreshOrderItemsGrid(dbconnect);
                }
            }
            else
            {
                MessageBox.Show("Please select a Order from the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Reciptgenerate EmpDash = new Reciptgenerate();
            EmpDash.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutD_btn_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

