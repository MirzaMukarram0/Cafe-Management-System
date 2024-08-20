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
    public partial class Feedback : Form
    {
        private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
        public Feedback()
        {
            InitializeComponent();
            label6.Text = Class1.name;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                // Retrieve data from textboxes
              //  string email = textBox2.Text;
                int rating = Convert.ToInt32(textBox3.Text);
                string description = textBox4.Text;

                // Fetch ProductId and CustomerId from the relevant tables
                int productId = GetProductId();
                int customerId = GetCustomerId();

                // Insert feedback into the Feedback table
                InsertFeedback(rating, description, productId, customerId);

                MessageBox.Show("Feedback recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                catbtn catbtn = new catbtn();
                catbtn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetCustomerId()
        {
            int customerId = Class1.Id; // Assuming Class1.Id stores the logged-in customer ID
            return customerId;
        }

        private int GetProductId()
        {
            int productId = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 PID FROM OrderItems WHERE OrderId IN (SELECT TOP 1 OrderId FROM Orders WHERE customerId = @customerId ORDER BY OrderDate DESC)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", Class1.Id); // Assuming Class1.Id stores the logged-in customer ID
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        productId = Convert.ToInt32(reader["PID"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching ProductId: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productId;
        }
        private void InsertFeedback(int rating, string description, int productId, int customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Feedback (Rating, Description, PID, customerId,date,time) VALUES (@Rating, @Description, @PID, @customerId,@date,@time)";
                SqlCommand insert = new SqlCommand(query, connection);
              //  insert.Parameters.AddWithValue("@Email", email);
                insert.Parameters.AddWithValue("@Rating", rating);
                insert.Parameters.AddWithValue("@Description", description);
                insert.Parameters.AddWithValue("@PID", productId);
                insert.Parameters.AddWithValue("@customerId", customerId);
                insert.Parameters.AddWithValue("@date", DateTime.Today);
                insert.Parameters.AddWithValue("@time", DateTime.Now.TimeOfDay);
                insert.ExecuteNonQuery();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
