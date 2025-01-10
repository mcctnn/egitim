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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Port=5432;Database=superuser;user Id=superuser;Password=123456aA*";

        void GetAllEmployee()
        {
            var connection=new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * from Employees";
            var command=new NpgsqlCommand(query, connection);
            var adapter=new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * from Departments";
            var command= new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbxEmployeeDep.DisplayMember = "DepartmentName";
            cbxEmployeeDep.ValueMember = "DepartmentId";
            cbxEmployeeDep.DataSource = dt;
            connection.Close();
        }
        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetAllEmployee();
            DepartmentList();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            string employeeName=tbxEmployeeName.Text;
            string employeeSurname=tbxEmployeeSurname.Text;
            int employeeSalary=int.Parse(tbxEmployeeSalary.Text);
            int departmentId = int.Parse(cbxEmployeeDep.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees(EmployeeName,EmployeeSurname,EmployeeSalary,DepartmentId) " +
                "values(@employeeName,@employeeSurname,@employeeSalary,@departmentId)";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee added successfully");
            connection.Close();
            GetAllEmployee();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            int id=int.Parse((string)tbxEmployeeId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete from Employees where EmployeeId=@employeeId";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("employeeId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee deleted successfully");
            connection.Close();
            GetAllEmployee();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int id = int.Parse((string)tbxEmployeeId.Text);
            string employeeName = tbxEmployeeName.Text;
            string employeeSurname = tbxEmployeeSurname.Text;
            int employeeSalary = int.Parse(tbxEmployeeSalary.Text);
            int departmentId = int.Parse(cbxEmployeeDep.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Employees Set EmployeeName=@employeeName,EmployeeSurname=@employeeSurname," +
                "EmployeeSalary=@employeeSalary,DepartmentId=@departmentId where EmployeeId=@employeeId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("employeeId", id);
            command.Parameters.AddWithValue("@employeeName", employeeName);
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@employeeSalary", employeeSalary);
            command.Parameters.AddWithValue("departmentId", departmentId);
            command.ExecuteNonQuery();
            MessageBox.Show("Employee updated successfully");
            connection.Close();
            GetAllEmployee();
        }

        private void GetEmployeeById()
        {
            try
            {
                int id = int.Parse(tbxEmployeeId.Text);

                var connection = new NpgsqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM Employees WHERE EmployeeId = @employeeId";
                var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("employeeId", id);

                var adapter = new NpgsqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnGetEmployeeById_Click(object sender, EventArgs e)
        {
            GetEmployeeById();
        }
    }
}
