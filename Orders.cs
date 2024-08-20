using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Orders : Form
    {
        private const string connectionString = @"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;";

        public Orders()
        {
            InitializeComponent();
            LoadOrdersData();
            label6.Text = Class1.name;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrdersData(); // Call LoadOrdersData method when the form loads
        }

        private void LoadOrdersData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int customerId = Class1.Id;
                    string query = @"
                SELECT 
    U.userfname AS CustomerName,
    P.PID AS productID,
    CT.TotalAmount AS CartTotalAmount,
    P.price AS Price,
    CI.Quantity AS CartItemQuantity,
    P.name AS ProductName
    FROM 
    Customer C
INNER JOIN
    cart CT ON CT.customerId = C.customerId
INNER JOIN
    cartItems CI ON CT.CId = CI.CId
INNER JOIN
    Products P ON CI.PID = P.PID
INNER JOIN
    users U ON C.CustomerId = U.Id
WHERE 
    C.customerId = @customerId
                ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@customerId", customerId); // Add customerId parameter
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Add a DataGridViewCheckBoxColumn for selection
                    DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                    checkboxColumn.HeaderText = "Selected"; // Set the column header text
                    checkboxColumn.Name = "Selected"; // Set the column name
                    dataGridView2.Columns.Insert(0, checkboxColumn); // Insert the checkbox column at the beginning

                    // Set the column index as the DisplayIndex to ensure it appears first
                    dataGridView2.Columns["Selected"].DisplayIndex = 0;

                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.Show();
            this.Hide();
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            catbtn catbtn = new catbtn();
            catbtn.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            SaveOrderDetails(); // Call a method to save order details to the database
                                //  LoadOrdersData();   // Refresh the DataGridView to display the updated orders
        }

        private void SaveOrderDetails()
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select an order type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if order type is not selected
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert into Orders table
                    string insertOrderQuery = @"
                INSERT INTO Orders (customerId, TotalAmount, OrderDate, OrderTime, OrderType, OrderStatus)
                VALUES (@customerId, @totalAmount, @orderDate, @orderTime, @orderType,@OrderStatus);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection);
                    insertOrderCommand.Parameters.AddWithValue("@customerId", Class1.Id); // Provide the customer ID
                    insertOrderCommand.Parameters.AddWithValue("@totalAmount", CalculateTotalAmount(comboBox1.SelectedItem.ToString())); // Calculate the total amount
                    insertOrderCommand.Parameters.AddWithValue("@orderDate", DateTime.Today); // Provide the order date
                    insertOrderCommand.Parameters.AddWithValue("@orderTime", DateTime.Now.TimeOfDay); // Provide the order time
                    insertOrderCommand.Parameters.AddWithValue("@orderType", comboBox1.SelectedItem.ToString()); // Provide the order type (you can change this as needed)
                    insertOrderCommand.Parameters.AddWithValue("@OrderStatus", "Pending"); // Provide the order type (you can change this as needed)

                    int orderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());

                    // Insert into OrderItems table for each product in the cart
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Selected"].Value))
                        {
                            string insertOrderItemQuery = @"
                        INSERT INTO OrderItems (OrderId, PID, Quantity)
                        VALUES (@orderId, @productID, @quantity);";

                            SqlCommand insertOrderItemCommand = new SqlCommand(insertOrderItemQuery, connection);
                            insertOrderItemCommand.Parameters.AddWithValue("@orderId", orderId);
                            insertOrderItemCommand.Parameters.AddWithValue("@productId", row.Cells["productID"].Value);
                            insertOrderItemCommand.Parameters.AddWithValue("@quantity", row.Cells["CartItemQuantity"].Value);
                            totalprice.Text = CalculateTotalAmount(comboBox1.SelectedItem.ToString()).ToString();
                            insertOrderItemCommand.ExecuteNonQuery();
                        }
                    }
                    Payment payment = new Payment();
                    payment.Show();
                    this.Hide();
                    // MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private decimal CalculateTotalAmount(string orderType)
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selected"].Value))
                {
                    // Calculate the total amount based on the product price and quantity
                    totalAmount = totalAmount + Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToInt32(row.Cells["CartItemQuantity"].Value);
                }
            }
            if (orderType == "Online Delivery")
            {
                totalAmount = totalAmount + 50;
            }
            return totalAmount;
        }

        private void totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
