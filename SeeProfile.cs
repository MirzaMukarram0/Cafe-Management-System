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
    public partial class SeeProfile : Form
    {
        private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
        public SeeProfile()
        {
            InitializeComponent();
            LoadCustomerInformation();
            label3.Text = Class1.Id.ToString();
            adminlabel.Text = Class1.name;
        }

        private void logoutD_btn_Click(object sender, EventArgs e)
        {
            catbtn catbtn = new catbtn();
            catbtn.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LoadCustomerInformation()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int customerId = Class1.Id;
                    string query = "SELECT C.*, U.userfname, U.userpassword FROM Customer C\r\nINNER JOIN users U ON C.customerId = U.Id WHERE customerId IN (SELECT Id FROM users WHERE Id = @customerId)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified customer ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in both name and password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int customerId = Class1.Id;
                    string customerQuery = "UPDATE Customer SET username = @username, userpassword = @userpassword WHERE customerId = @customerId";
                    SqlCommand customerCommand = new SqlCommand(customerQuery, connection);
                    customerCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    customerCommand.Parameters.AddWithValue("@userpassword", textBox2.Text);
                    customerCommand.Parameters.AddWithValue("@customerId", customerId);
                    int customerRowsAffected = customerCommand.ExecuteNonQuery();

                    // Update the users table based on customerId
                    string userQuery = "UPDATE users SET username = @username, userpassword = @userpassword WHERE Id IN (SELECT Id FROM Customer WHERE customerId = @customerId)";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection);
                    userCommand.Parameters.AddWithValue("@username", textBox1.Text);
                    userCommand.Parameters.AddWithValue("@userpassword", textBox2.Text);
                    userCommand.Parameters.AddWithValue("@customerId", customerId);
                    int userRowsAffected = userCommand.ExecuteNonQuery();

                    if (customerRowsAffected > 0 && userRowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Profile update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
