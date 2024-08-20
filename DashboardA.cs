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
    public partial class DashboardA : Form
    {
        private const string dbconnect = (@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public DashboardA()
        {
            InitializeComponent();
            label1.Text = CountDistinctEmployees().ToString();
            label3.Text = CountDistinctCustomers().ToString();
            label8.Text = CountDistinctProducts().ToString();
            label9.Text = CountDistinctFeedbacks().ToString();
            label7.Text = CalculateTotalOrderAmount().ToString();
            label6.Text = Class1.name;
        }

        private void Db_btn_Click(object sender, EventArgs e)
        {

        } //No of employees
        private int CountDistinctEmployees()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbconnect))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(DISTINCT EmpId) FROM employees";

                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    return count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting distinct employees: " + ex.Message);
                return -1;
            }
        }
        //No of Customers
        private int CountDistinctCustomers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbconnect))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(DISTINCT CustomerId) FROM Customer";

                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    return count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting distinct employees: " + ex.Message);
                return -1;
            }
        }
        //Total Products
        private int CountDistinctProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbconnect))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(DISTINCT PID) FROM Products";

                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting distinct products: " + ex.Message);
                return -1;
            }
        }
        //Total Feedbacks
        private int CountDistinctFeedbacks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbconnect))
                {
                    connection.Open();

                    string query = @"SELECT COUNT(DISTINCT FeedbackId) FROM Feedback";

                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting distinct feedbacks: " + ex.Message);
                return -1;
            }
        }
        //TotalAmount
        private decimal CalculateTotalOrderAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(dbconnect))
                {
                    connection.Open();

                    string query = @"SELECT SUM(TotalAmount) FROM Orders";

                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total order amount: " + ex.Message);
                return -1;
            }
        }

        private void proman_btn_Click(object sender, EventArgs e)
        {

        }

        private void closeDA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Dashboard Das = new Dashboard();
            Das.Show();
            this.Hide();
        }

        private void logoutDA_btn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TF_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
