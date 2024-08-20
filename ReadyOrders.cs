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
    public partial class ReadyOrders : Form
    {
        private SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public ReadyOrders()
        {
            InitializeComponent();
            RefreshOrderItemsGrid(dbconnect);
            label4.Text = Class1.name;
        }

        private void RefreshOrderItemsGrid(SqlConnection dbconnect)
        {
            // int customerId = Class1.Id;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT 
        Pay.PaymentId,
        Pay.PaymentStatus,
        O.TotalAmount,
        U.userfname AS CustomerName
    FROM 
        Payment Pay
    JOIN 
        Orders O ON Pay.OrderId = O.OrderId AND Pay.PaymentStatus = 'Pending'
    JOIN 
        Customer C ON O.customerId = C.CustomerId AND O.OrderStatus = 'READY'
    JOIN 
        users U ON C.CustomerId = U.Id ", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridReadyOrders.DataSource = dataTable;
        }

        private void dataGridReadyOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridReadyOrders.SelectedRows.Count > 0)
            {
                string PayID = dataGridReadyOrders.SelectedRows[0].Cells["PaymentId"].Value.ToString();

                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand deleteCartCommand = new SqlCommand("UPDATE Payment SET PaymentStatus='Done' WHERE PaymentId=@PaymentId", dbconnect);
                    deleteCartCommand.Parameters.AddWithValue("@PaymentId", PayID);
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
