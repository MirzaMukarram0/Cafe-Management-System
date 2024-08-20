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
    public partial class ProductsMana : Form
    {
        public ProductsMana()
        {
            InitializeComponent();
            PopulateCategories();
            label6.Text = Class1.name;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products (PID, name, price, categoryid, Description,Inventory)  VALUES  (@PID,@name, @price, @categoryid, @Description,@Inventory) ", dbconnect);
                    sqlCommand.Parameters.AddWithValue("@PId", Idbox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@name", Namebox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@price", PriceBox.Text.Trim());
                    int categoryId = (int)comboBox1.SelectedValue;
                    sqlCommand.Parameters.AddWithValue("@categoryid", categoryId); // Use selected category ID
                    sqlCommand.Parameters.AddWithValue("@Inventory", inventorybox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Description", Descbox.Text.Trim());
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Product Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
        }
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(Idbox.Text) || string.IsNullOrWhiteSpace(Namebox.Text) || string.IsNullOrWhiteSpace(PriceBox.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(Descbox.Text))
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
        private void RefreshDataGridView(SqlConnection dbconnect)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Products", dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void ClearFields()
        {
            Idbox.Text = "";
            Namebox.Text = "";
            PriceBox.Text = "";
            comboBox1.Text = "";
            Descbox.Text = "";
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Idbox.Text))
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE PID = @PID", dbconnect);
                    sqlCommand.Parameters.AddWithValue("@PID", Idbox.Text.Trim());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Removed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter an Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET name = @name, price = @price,categoryid = @categoryid,Description = @Description,Inventory=@Inventory WHERE PID = @PID", dbconnect);
                    sqlCommand.Parameters.AddWithValue("@PID", Idbox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@name", Namebox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@price", PriceBox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Inventory", inventorybox.Text.Trim());
                    int categoryId = (int)comboBox1.SelectedValue;
                    sqlCommand.Parameters.AddWithValue("@categoryid", categoryId);
                    sqlCommand.Parameters.AddWithValue("@Description", Descbox.Text.Trim());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Product Edited Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Products", dbconnect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                ClearFields();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateCategories()
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT catId, catName FROM categories", dbconnect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Bind the DataTable to the ComboBox
                comboBox1.DataSource = table;
                comboBox1.DisplayMember = "catName"; // Display category names
                comboBox1.ValueMember = "catId";     // Use category IDs as values
            }
        }

        private void countbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                string join2 = "SELECT c.catId, c.catName, COUNT(p.PID) AS ProductCount " +
               "FROM categories c " +
               "LEFT JOIN Products p ON c.catId = p.categoryid GROUP BY c.catId, c.catName";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(join2, dbconnect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                ClearFields();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void proprice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
