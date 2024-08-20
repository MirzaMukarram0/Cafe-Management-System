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
    public partial class Form1 : Form
    {
        SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void loginclosebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }
        public bool FieldEmpty()
        {
            if (loginUsername.Text == "" || loginPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void loginSP_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = loginSP.Checked ? '\0' : '*';

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            if (FieldEmpty())
            {
                MessageBox.Show("Please Fill All Required Fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbconnect.State == ConnectionState.Closed)
                {
                    try
                    {
                        dbconnect.Open();
                        string checkAccount = "SELECT * FROM users WHERE userfname = @user AND userpassword = @userpassword AND userstatus = @status";
                        using (SqlCommand checkusername = new SqlCommand(checkAccount, dbconnect))
                        {
                            checkusername.Parameters.AddWithValue("@user", loginUsername.Text.Trim());
                            checkusername.Parameters.AddWithValue("@userpassword", loginPassword.Text.Trim());
                            checkusername.Parameters.AddWithValue("@status", "Active");
                            SqlDataAdapter adapter = new SqlDataAdapter(checkusername);
                            DataTable table = new DataTable();
                            adapter.SelectCommand = checkusername;
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                DataRow userRow = table.Rows[0];
                                string userRole = userRow["userrole"].ToString();
                                string selectedRole = RolecomboBox1.SelectedItem.ToString();

                                if (userRole != selectedRole)
                                {
                                    MessageBox.Show("Invalid Role for this user.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (selectedRole == "Administrator")
                                    {
                                        Class1.name = loginUsername.Text;
                                        Class1.Id = Convert.ToInt32(userRow["Id"]);
                                        MessageBox.Show("Login Successfully:", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Dashboard form = new Dashboard();
                                        form.Show();
                                        this.Hide();
                                    }
                                    else if (selectedRole == "Employee")
                                    {
                                        Class1.name = loginUsername.Text;
                                        Class1.Id = Convert.ToInt32(userRow["Id"]);
                                        MessageBox.Show("Login Successfully:", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Reciptgenerate reciptgenerate = new Reciptgenerate();
                                        reciptgenerate.Show();
                                        this.Hide();
                                    }
                                    else if (selectedRole == "Customer")
                                    {
                                        Class1.name = loginUsername.Text;
                                        string customerIdQuery = "SELECT CustomerId FROM Customer WHERE CustomerId IN (SELECT Id FROM users WHERE userfname = @username)";
                                        using (SqlCommand customerIdCommand = new SqlCommand(customerIdQuery, dbconnect))
                                        {
                                            customerIdCommand.Parameters.AddWithValue("@username", loginUsername.Text.Trim());
                                            int customerId = Convert.ToInt32(customerIdCommand.ExecuteScalar());
                                            Class1.Id = customerId;
                                        }
                                        MessageBox.Show("Login Successfully:", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        catbtn customer = new catbtn();
                                        customer.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password or Account is not registered", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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




        public void RolecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rolelebel_Click(object sender, EventArgs e)
        {

        }

        private void loginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}