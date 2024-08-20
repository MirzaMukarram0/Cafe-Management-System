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
    public partial class recipt : Form
    {
        private SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public recipt()
        {
            InitializeComponent();
            RefreshOrderItemsGrid(dbconnect);
            label4.Text = Class1.name;
        }
        private void RefreshOrderItemsGrid(SqlConnection dbconnect)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT O.OrderId,Pay.PaymentId,Pay.PaymentStatus,O.TotalAmount
          FROM Payment Pay
            JOIN Orders O ON Pay.OrderId=O.OrderId AND Pay.PaymentStatus='DONE' AND O.OrderStatus='READY'
            LEFT JOIN Recipt Re ON Pay.PaymentId=Re.PaymentId AND Re.PaymentId IS NULL", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            ReciptGrid.DataSource = dataTable;
        }

        private void RefreshdataGridView1(SqlConnection dbconnect)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Recipt", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void recipt_Load(object sender, EventArgs e)
        {

        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Reciptgenerate EmpDash = new Reciptgenerate();
            EmpDash.Show();
            this.Hide();
        }

        private void reciptbtn_Click(object sender, EventArgs e)
        {
            if (ReciptGrid.SelectedRows.Count > 0)
            {
                string PayId = ReciptGrid.SelectedRows[0].Cells["PaymentId"].Value.ToString();

                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand createRecipt = new SqlCommand("Insert INTO Recipt(PaymentId,R_time,R_date) VALUES(@PayId,@rtime,@rdate); SELECT SCOPE_IDENTITY();", dbconnect);
                    createRecipt.Parameters.AddWithValue("@PayId", Convert.ToInt32(PayId));
                    createRecipt.Parameters.AddWithValue("@rdate", DateTime.Today);
                    createRecipt.Parameters.AddWithValue("@rtime", DateTime.Now.TimeOfDay);
                    createRecipt.ExecuteNonQuery();
                    MessageBox.Show("Recipt Generated Successfully!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshdataGridView1(dbconnect);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
