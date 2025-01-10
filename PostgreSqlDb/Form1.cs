using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreSqlDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString="Server=localhost;Port=5432;Database=superuser;user Id=superuser;Password=123456aA*";

        void GetAllCustomers()
        {
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers";
            var command=new NpgsqlCommand(query, connection);
            var adapter=new NpgsqlDataAdapter(command);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            string customerName=tbxCustomerName.Text;
            string customerSurname=tbxCustomerSurname.Text;
            string customerCity=tbxCustomerCity.Text;
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers(CustomerName,CustomerSurname,CustomerCity) " +
                "values(@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName",customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer added successfully");
            connection.Close();
            GetAllCustomers();
            
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbxCustomerId.Text);
            var connection= new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete from Customers where CustomerId=@customerId";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery ();
            MessageBox.Show("Customer deleted successfully");
            connection.Close();
            GetAllCustomers();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerName = tbxCustomerName.Text;
            string customerCity = tbxCustomerCity.Text;
            string customerSurname= tbxCustomerSurname.Text;
            int id=int.Parse(tbxCustomerId.Text);
            var connection= new NpgsqlConnection( connectionString);
            connection.Open ();
            string query = "Update Customers set " +
                "CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity where CustomerId=@customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName",customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Customer updated successfully");
            connection.Close();
            GetAllCustomers();
        }

        private void btnGetCustomerById_Click(object sender, EventArgs e)
        {

        }
    }
}
