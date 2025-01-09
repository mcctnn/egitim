using mongoDb.Entities;
using mongoDb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mongoDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerOperations customerOperations = new CustomerOperations();
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = tbxCustomerName.Text,
                CustomerSurname = tbxCustomerSurname.Text,
                CustomerCity = tbxCustomerCity.Text,
                CustomerBalance = decimal.Parse(tbxCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(tbxCustomerShoppingCount.Text)

            };
            customerOperations.AddCustomer(customer);
            MessageBox.Show("Customer added successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            List<Customer> customerList = customerOperations.GetAllCustomers();
            dataGridView1.DataSource = customerList;
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            string customerId = tbxCustomerId.Text;
            customerOperations.RemoveCustomer(customerId);
            MessageBox.Show("Customer deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerId = tbxCustomerId.Text;
            var customer = new Customer()
            {
                CustomerID = customerId,
                CustomerName = tbxCustomerName.Text,
                CustomerSurname = tbxCustomerSurname.Text,
                CustomerCity = tbxCustomerCity.Text,
                CustomerBalance = decimal.Parse(tbxCustomerBalance.Text),
                CustomerShoppingCount = int.Parse(tbxCustomerShoppingCount.Text)

            };
            customerOperations.UpdateCustomer(customer);
            MessageBox.Show("Customer updated successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnGetCustomerById_Click(object sender, EventArgs e)
        {
            string customerId = tbxCustomerId.Text;
            Customer customer = customerOperations.GetCustomerById(customerId);
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}
