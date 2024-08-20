using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.VisualBasic.ApplicationServices;

namespace CafeManagementSystem
{
    public partial class Register : Form
    {
        SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public Register()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rsibtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void rcp_CheckedChanged(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = rcp.Checked ? '\0' : '*';
            cpasswordbox.PasswordChar = rcp.Checked ? '\0' : '*';
        }

        private void rpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void rconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }
        public bool FieldEmpty()
        {
            if (fnbox.Text == "" || lnbox.Text == "" || passwordbox.Text == "" || cpasswordbox.Text == "" || emailbox.Text == "" || RolecomboBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int GetLastInsertedUserId()
        {
            string query = "SELECT MAX(Id) FROM users";
            using (SqlCommand cmd = new SqlCommand(query, dbconnect))
            {
                int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                return lastInsertedId;
            }
        }
        private void rsubtn_Click(object sender, EventArgs e)
        {
            if (FieldEmpty())
            {
                MessageBox.Show("All Fields Required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbconnect.State == ConnectionState.Closed)
                {
                    try
                    {
                        dbconnect.Open();
                        string selectusername = "select * from users where userfname = @userfname";
                        using (SqlCommand checkusername = new SqlCommand(selectusername, dbconnect))
                        {
                            checkusername.Parameters.AddWithValue("@userfname", fnbox.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            DataTable table = new DataTable();
                            adapter.SelectCommand = checkusername;
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = fnbox.Text.Substring(0, 1).ToLower() + fnbox.Text.Substring(1);
                                MessageBox.Show(usern + "is already.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (passwordbox.Text != cpasswordbox.Text)
                            {
                                MessageBox.Show("Both Passwords not match", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (passwordbox.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password atleast 8 char", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string addDataQuery = "INSERT INTO users (userfname, userlastname, userpassword, userrole, userstatus, Email, datereg) " +
                                     "VALUES (@fname, @lname, @password, @role, @status, @email, @date);";
                                DateTime today = DateTime.Now;
                                using (SqlCommand addDataCmd = new SqlCommand(addDataQuery, dbconnect))
                                {
                                    addDataCmd.Parameters.AddWithValue("@fname", fnbox.Text.Trim());
                                    addDataCmd.Parameters.AddWithValue("@lname", lnbox.Text.Trim());
                                    addDataCmd.Parameters.AddWithValue("@password", passwordbox.Text.Trim());
                                    addDataCmd.Parameters.AddWithValue("@role", RolecomboBox.Text.Trim());
                                    addDataCmd.Parameters.AddWithValue("@status", "Active");
                                    addDataCmd.Parameters.AddWithValue("@email", emailbox.Text.Trim());
                                    addDataCmd.Parameters.AddWithValue("@date", today);
                                    addDataCmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully.", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    switch (RolecomboBox.Text.Trim().ToLower())
                                    {
                                        case "administrator":
                                            string addAdminDataQuery = "INSERT INTO Administrator (AdminId) VALUES (@userId)";
                                            using (SqlCommand addAdminDataCmd = new SqlCommand(addAdminDataQuery, dbconnect))
                                            {
                                                addAdminDataCmd.Parameters.AddWithValue("@userId", GetLastInsertedUserId());
                                                addAdminDataCmd.ExecuteNonQuery();
                                            }
                                            break;
                                        case "customer":
                                            string addCustomerDataQuery = "INSERT INTO Customer (CustomerId) VALUES (@userId)";
                                            using (SqlCommand addCustomerDataCmd = new SqlCommand(addCustomerDataQuery, dbconnect))
                                            {
                                                addCustomerDataCmd.Parameters.AddWithValue("@userId", GetLastInsertedUserId());
                                                addCustomerDataCmd.ExecuteNonQuery();
                                            }
                                            break;
                                        case "employee":
                                            string addEmployeeDataQuery = "INSERT INTO Employees (EmpId) VALUES (@userId)";
                                            using (SqlCommand addEmployeeDataCmd = new SqlCommand(addEmployeeDataQuery, dbconnect))
                                            {
                                                addEmployeeDataCmd.Parameters.AddWithValue("@userId", GetLastInsertedUserId());
                                                addEmployeeDataCmd.ExecuteNonQuery();
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                    Form1 form = new Form1();
                                    form.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dbconnect.Close();
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
