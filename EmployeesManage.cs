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
using System.Data;
using System.Data.SqlClient;
namespace CafeManagementSystem
{
    public partial class EmployeesManage : Form
    {
        public EmployeesManage()
        {
            InitializeComponent();
            label6.Text = Class1.name;
        }
        private void ClearFields()
        {
            Idbox.Text = "";
            Namebox.Text = "";
            Agebox.Text = "";
            PasswordBox.Text = "";
            Availbox.Text = "";
        }
        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }



        private void EmployeesManage_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();

                    // Insert into users table
                    SqlCommand userCmd = new SqlCommand("INSERT INTO users (userfname, userpassword, userrole, userstatus, datereg) VALUES (@userfname, @userpassword, @userrole, 'Active', @datereg); SELECT SCOPE_IDENTITY();", dbconnect);
                    userCmd.Parameters.AddWithValue("@userfname", Namebox.Text.Trim());
                    userCmd.Parameters.AddWithValue("@userpassword", PasswordBox.Text.Trim());
                    userCmd.Parameters.AddWithValue("@userrole", "Employee");
                    userCmd.Parameters.AddWithValue("@datereg", DateTime.Now);
                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    // Insert into Employees table
                    SqlCommand employeeCmd = new SqlCommand("INSERT INTO Employees (EmpId, age, availability) VALUES (@EmpId, @Age, @availability)", dbconnect);
                    employeeCmd.Parameters.AddWithValue("@EmpId", userId);
                    employeeCmd.Parameters.AddWithValue("@Age", Agebox.Text.Trim());
                    employeeCmd.Parameters.AddWithValue("@availability", Availbox.Text.Trim());
                    employeeCmd.ExecuteNonQuery();

                    MessageBox.Show("Employee Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
        }


        private void close_Click(object sender, EventArgs e)
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
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Employees WHERE EmpId = @EmpId; DELETE FROM users WHERE Id = @EmpId;", dbconnect);
                    sqlCommand.Parameters.AddWithValue("@EmpId", Idbox.Text.Trim());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee Removed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
                {
                    dbconnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Employees SET age = @Age, availability = @availability WHERE EmpId = @EmpId; UPDATE users SET userfname = @userfname, userpassword = @userpassword WHERE Id = @EmpId;", dbconnect);
                    sqlCommand.Parameters.AddWithValue("@EmpId", Idbox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@userfname", Namebox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@userpassword", PasswordBox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Age", Agebox.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@availability", Availbox.Text.Trim());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Employee Edited Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView(dbconnect);
                    ClearFields();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;"))
            {
                dbconnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM employees", dbconnect);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                ClearFields();
            }
        }
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(Idbox.Text) || string.IsNullOrWhiteSpace(Namebox.Text) || string.IsNullOrWhiteSpace(Agebox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Idbox.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Agebox.Text, out int age) || age <= 10 || age >= 100)
            {
                MessageBox.Show("Age must be a valid number between 11 and 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string query = @"SELECT 
                        u.Id AS EmployeeId,
                        u.userfname AS Username,
                        e.age AS EmployeeAge,
                        e.availability AS EmployeeAvailability,
                        u.userrole AS UserRole
                    FROM
                        users u
                    INNER JOIN 
                        Employees e ON u.Id = e.EmpId";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dbconnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click_1(object sender, EventArgs e)     //Clear button
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
