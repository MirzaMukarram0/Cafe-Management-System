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
    public partial class EasyPaisa : Form
    {
        private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";

        public EasyPaisa()
        {
            InitializeComponent();
            label6.Text = Class1.name;
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            catbtn catbtn = new catbtn();
            catbtn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                    !string.IsNullOrWhiteSpace(textBox2.Text) &&
                    !string.IsNullOrWhiteSpace(textBox2.Text)) // Checking if all textboxes are filled
                {
                    // Retrieving data for the current order
                    decimal totalAmount = 0;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        int customerId = Class1.Id;
                        string query = @"SELECT O.TotalAmount FROM OrderItems OI
                                INNER JOIN Orders O ON OI.OrderId = O.OrderId 
                                WHERE O.OrderId = (SELECT MAX(OrderId) FROM Orders WHERE customerId = @customerId)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@customerId", customerId);
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalAmount = Convert.ToDecimal(result); // Setting the value of totalAmount to the total amount
                        }
                    }

                    // Checking if the amount entered in textBox2 matches the total amount
                    decimal enteredAmount;
                    if (!decimal.TryParse(textBox2.Text, out enteredAmount))
                    {
                        MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (enteredAmount == totalAmount)
                    {
                        MessageBox.Show("Order confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Your order has been placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Feedback feedback = new Feedback();
                        feedback.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The entered payment amount does not match the total order amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
