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
    public partial class Categories : Form
    {
        public Categories()
        {

            InitializeComponent();
            label6.Text = Class1.name;
            DataView3();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DataView3()
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                try
                {
                    dbconnect.Open();  //Product in each cat
                    SqlCommand cmd = new SqlCommand("SELECT categoryid, COUNT(*) AS ProductCount FROM Products GROUP BY categoryid HAVING COUNT(*) > 2;", dbconnect);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView3.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // Load categories into the combobox
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", dbconnect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["catName"].ToString());
                }
                reader.Close();
            }
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    //Subquery
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Products WHERE categoryid = (SELECT catId FROM Categories WHERE catName = @CategoryName)", dbconnect);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CategoryName", selectedCategory);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string productId = dataGridView1.SelectedRows[0].Cells["PID"].Value.ToString();
                int quantity = 0;

                if (!int.TryParse(quantitybox.Text, out quantity))
                {
                    MessageBox.Show("Quantity must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    int cartId = CreateCart(dbconnect);
                    InsertCartItem(dbconnect, cartId, productId, quantity);
                    MessageBox.Show("Product added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCartTotal(dbconnect, cartId);//TotalAmount in cart
                    RefreshCartItemsGrid(dbconnect);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CreateCart(SqlConnection dbconnect)
        {
            SqlCommand createCartCommand = new SqlCommand("INSERT INTO cart (CDate, TotalAmount, customerId) VALUES (@CDate, 0, @customerId); SELECT SCOPE_IDENTITY();", dbconnect);
            createCartCommand.Parameters.AddWithValue("@CDate", DateTime.Today);
            createCartCommand.Parameters.AddWithValue("@customerId", Class1.Id);
            return Convert.ToInt32(createCartCommand.ExecuteScalar());
        }

        private void InsertCartItem(SqlConnection dbconnect, int cartId, string productId, int quantity)
        {
            SqlCommand insertCartItemCommand = new SqlCommand("INSERT INTO cartItems (CId, PID, Quantity) VALUES (@CId, @PID, @Quantity)", dbconnect);
            insertCartItemCommand.Parameters.AddWithValue("@CId", cartId);
            insertCartItemCommand.Parameters.AddWithValue("@PID", productId);
            insertCartItemCommand.Parameters.AddWithValue("@Quantity", quantity);
            insertCartItemCommand.ExecuteNonQuery();
        }

        private void totalprice_TextChanged(object sender, EventArgs e)
        {

        }
        private decimal CalculateTotalPrice(SqlConnection dbconnect, int cartId)
        {
            SqlCommand totalPriceCommand = new SqlCommand(@"SELECT SUM(p.price * ci.Quantity) AS TotalPrice
                                                     FROM Products p
                                                     INNER JOIN cartItems ci ON p.PID = ci.PID
                                                     WHERE ci.CId = @CId", dbconnect);
            totalPriceCommand.Parameters.AddWithValue("@CId", cartId);
            object result = totalPriceCommand.ExecuteScalar();
            if (result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }
        private void UpdateCartTotal(SqlConnection dbconnect, int cartId)
        {
            decimal totalPrice = CalculateTotalPrice(dbconnect, cartId);
            SqlCommand updateTotalCommand = new SqlCommand("UPDATE cart SET TotalAmount = @TotalAmount WHERE CId = @CId", dbconnect);
            updateTotalCommand.Parameters.AddWithValue("@TotalAmount", totalPrice);
            updateTotalCommand.Parameters.AddWithValue("@CId", cartId);
            updateTotalCommand.ExecuteNonQuery();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int cItemsId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["CItemsId"].Value);

                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    int customerId = Class1.Id;
                    SqlCommand deleteCartItemCommand = new SqlCommand("DELETE FROM cartItems WHERE CItemsId = @CItemsId", dbconnect);
                    deleteCartItemCommand.Parameters.AddWithValue("@CItemsId", cItemsId);
                    deleteCartItemCommand.ExecuteNonQuery();
                    SqlCommand deleteCartCommand = new SqlCommand("DELETE FROM cart WHERE CId NOT IN (SELECT CId FROM cartItems) AND customerId = @CustomerId", dbconnect);
                    deleteCartCommand.Parameters.AddWithValue("@CustomerId", customerId);
                    deleteCartCommand.ExecuteNonQuery();
                    RefreshCartItemsGrid(dbconnect);
                    UpdateCartTotal(dbconnect, customerId);  //Totalprice in Cart
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the cart items grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshCartItemsGrid(SqlConnection dbconnect)
        {
            int customerId = Class1.Id;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT ci.CItemsId, p.name AS ProductName, ci.Quantity, p.price AS BasePrice,
                                              (p.price * ci.Quantity) AS Tprice
                                          FROM Products p
                                          INNER JOIN cartItems ci ON p.PID = ci.PID
                                          INNER JOIN cart c ON ci.CId = c.CId
                                          WHERE c.customerId = @CustomerId", dbconnect);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CustomerId", customerId);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
            CalculateAndDisplayTotalPrice();  //TotalPrice In grid
        }

        private void CalculateAndDisplayTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                decimal tPrice = Convert.ToDecimal(row.Cells["Tprice"].Value);
                totalPrice += tPrice;
            }

            totalprice.Text = totalPrice.ToString();
        }
        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            catbtn catbtn = new catbtn();
            catbtn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Categories_Load_1(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
