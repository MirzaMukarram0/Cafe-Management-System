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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
            label6.Text = Class1.name;
            DataView2();
        }


        private void ClearFields()
        {
            Idbox.Text = "";
            Namebox.Text = "";
            Applydiscountbox.Text = "";
            newbox.Text = "";
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    int productId = Convert.ToInt32(Idbox.Text.Trim());
                    string selectedDiscountType = Applydiscountbox.SelectedItem.ToString();
                    int discountId = GetDiscountIdByType(selectedDiscountType);//discount id taken
                    UpdateProductDiscountId(productId, discountId);//price updated
                    decimal newPrice = GetNewPrice(productId, discountId);//new price
                    UpdateProductPrice(productId, newPrice); //new price in product table
                    newbox.Text = newPrice.ToString();
                }
            }
        }
        //update in product table
        private void UpdateProductDiscountId(int productId, int discountId)
        {
            string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
            string query = "UPDATE Products SET DiscountId = @DiscountId WHERE PID = @PID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DiscountId", discountId);
                    command.Parameters.AddWithValue("@PID", productId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        //Discount id from string
        private int GetDiscountIdByType(string discountType)
        {
            int discountId = 0;
            string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
            string query = "SELECT DiscountId FROM Discount WHERE DiscountType = @DiscountType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DiscountType", discountType);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        discountId = Convert.ToInt32(result);
                    }
                }
            }

            return discountId;
        }
        private void Editbtn_Click(object sender, EventArgs e)
        {

        }
        //Validations
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(Idbox.Text) || string.IsNullOrWhiteSpace(Namebox.Text) || string.IsNullOrWhiteSpace(Applydiscountbox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Idbox.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!NameIsValid(Namebox.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool NameIsValid(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        //After applying discount on specific product new price 
        private decimal GetNewPrice(int productId, int discountId)
        {
            decimal originalPrice = 0;
            decimal discountAmount = 0;
            string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
            string query = "SELECT price FROM Products WHERE PID = @PID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PID", productId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        originalPrice = Convert.ToDecimal(result);
                    }
                }
            }
            query = "SELECT DisscountPer FROM Discount WHERE DiscountId = @DiscountId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DiscountId", discountId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        discountAmount = Convert.ToDecimal(result);
                    }
                }
            }
            decimal newPrice = 0;
            if (discountId == 1) // Percentage discount
            {
                newPrice = originalPrice - (originalPrice * (discountAmount / 100));
            }
            else if (discountId == 2) // Fixed amount discount
            {
                newPrice = originalPrice - (originalPrice * (discountAmount / 100));
            }
            else if (discountId == 3) // Large sale discount
            {
                newPrice = originalPrice - (originalPrice * (discountAmount / 100));
            }
            else
            {
                newPrice = originalPrice;
            }

            return newPrice;
        }


        private void removebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                string join1 = "select *from Products p where p.DiscountId is NULL";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(join1, dbconnect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                ClearFields();
            }
        }


        private void UpdateProductPrice(int productId, decimal newPrice)
        {
            string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";
            string query = "UPDATE Products SET price = @newPrice WHERE PID = @PID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newPrice", newPrice);
                    command.Parameters.AddWithValue("@PID", productId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void DataView2()
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                try
                {
                    dbconnect.Open();
                    SqlCommand cmd = new SqlCommand("SELECT d.DiscountType, COUNT(*) AS ProductCount FROM Products p LEFT JOIN Discount d ON p.DiscountId = d.DiscountId GROUP BY d.DiscountType HAVING COUNT(*) > 0;", dbconnect);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\NewBase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                dbconnect.Open();
                string join1 = "SELECT p.PID, p.name AS ProductName, p.price, d.DiscountType, d.DisscountPer " +
                               "FROM Products p " +
                               "INNER JOIN Discount d ON p.DiscountId = d.DiscountId";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(join1, dbconnect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                ClearFields();
            }
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private void Applydiscountbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Discount_Load(object sender, EventArgs e)
        {

        }
    }
}
