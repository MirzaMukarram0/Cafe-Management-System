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
    public partial class Payment : Form
    {
        private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
        public Payment()
        {
            InitializeComponent();
            LoadDataIntoGrid();
            label6.Text = Class1.name;
        }

        private void mobilebtn_Click(object sender, EventArgs e)
        {
            InsertPayment("Mobile App");
            EasyPaisa easyPaisa = new EasyPaisa();
            easyPaisa.Show();
            this.Hide();
        }

        private void credbtn_Click(object sender, EventArgs e)
        {
            InsertPayment("Bank Transfer");
            Bank bank = new Bank();
            bank.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InsertPayment(string paymentType)
        {

            if (paymentType == "By Hand")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int orderId = (int)dataGridView2.Rows[0].Cells["OrderId"].Value; // Assuming the OrderId is included in the DataGridView

                        string insertPaymentQuery = @"INSERT INTO Payment (OrderId, PaymentDate, PaymentTime, PaymentType,PaymentStatus) 
                                          VALUES (@orderId, @paymentDate, @paymentTime, @paymentType,@PaymentStatus)";

                        SqlCommand insertPaymentCommand = new SqlCommand(insertPaymentQuery, connection);
                        insertPaymentCommand.Parameters.AddWithValue("@orderId", orderId);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentDate", DateTime.Today);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentTime", DateTime.Now.TimeOfDay);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentType", paymentType);
                        insertPaymentCommand.Parameters.AddWithValue("@PaymentStatus", "Pending");
                        insertPaymentCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        int orderId = (int)dataGridView2.Rows[0].Cells["OrderId"].Value; // Assuming the OrderId is included in the DataGridView

                        string insertPaymentQuery = @"INSERT INTO Payment (OrderId, PaymentDate, PaymentTime, PaymentType,PaymentStatus) 
                                          VALUES (@orderId, @paymentDate, @paymentTime, @paymentType,@PaymentStatus)";

                        SqlCommand insertPaymentCommand = new SqlCommand(insertPaymentQuery, connection);
                        insertPaymentCommand.Parameters.AddWithValue("@orderId", orderId);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentDate", DateTime.Today);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentTime", DateTime.Now.TimeOfDay);
                        insertPaymentCommand.Parameters.AddWithValue("@paymentType", paymentType);
                        insertPaymentCommand.Parameters.AddWithValue("@PaymentStatus", "Done");
                        insertPaymentCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment details inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadDataIntoGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int customerId = Class1.Id;

                    string query = @"SELECT 
        O.OrderId,
        OI.Quantity AS Quantity, 
        P.name AS ProductName, 
        P.price AS Price, 
        O.TotalAmount AS TotalAmount, 
        U.userfname AS CustomerName 
    FROM 
        OrderItems OI
    INNER JOIN 
        Orders O ON OI.OrderId = O.OrderId 
    INNER JOIN 
        Products P ON OI.PID = P.PID 
    INNER JOIN 
        users U ON O.customerId = U.Id 
    WHERE 
        O.OrderId = (SELECT MAX(OrderId) FROM Orders WHERE customerId = @customerId)";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@customerId", customerId);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            catbtn catbtn = new catbtn();
            catbtn.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void handbutton1_Click(object sender, EventArgs e)
        {
            InsertPayment("By Hand");
            MessageBox.Show("Your Order has been successfully Placed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Feedback feedback = new Feedback();
            feedback.Show();
            this.Hide();
        }
    }
}
