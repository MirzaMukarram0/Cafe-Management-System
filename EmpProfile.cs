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
    public partial class EmpProfile : Form
    {
        private SqlConnection dbconnect = new SqlConnection(@"Data Source=INCOGNITO\SQLEXPRESS;Initial Catalog=ProjectFinalDB;Integrated Security=True;");
        public EmpProfile()
        {
            InitializeComponent();
            RefreshprofileGrid(dbconnect);
        }

        private void RefreshprofileGrid(SqlConnection dbconnect)
        {
            int EmpId = Class1.Id;
            SqlCommand sqlcomm = new SqlCommand(@"SELECT * FROM EmployeeDetails WHERE EmpId=@empid", dbconnect);
            sqlcomm.Parameters.AddWithValue("@empid", EmpId);
            SqlDataAdapter sqlad = new SqlDataAdapter(sqlcomm);
            DataTable dataTable = new DataTable();
            sqlad.Fill(dataTable);
            GridProfile.DataSource = dataTable;
        }

        private void EmpProfile_Load(object sender, EventArgs e)
        {

        }

        private void Mainmenubtn_Click(object sender, EventArgs e)
        {
            Reciptgenerate EmpDash = new Reciptgenerate();
            EmpDash.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
