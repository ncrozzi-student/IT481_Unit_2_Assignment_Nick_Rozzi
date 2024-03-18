using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IT481_Unit_3_Assignment_Nick_Rozzi
{
    public partial class Form1 : Form
    {
        Controller controller;
        string user;
        string password;
        string server;
        string database;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = tbUser.Text;
            password = tbPassword.Text;
            server = tbServer.Text;
            database = tbDatabase.Text;

            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");
            }

            if (isValid)
            {
                controller = new Controller("Server = localhost\\SQLEXPRESS; Trusted_Connection=true; Database=northwind; User Instance=false; TrustServerCertificate=True; Connection timeout=30;");
                MessageBox.Show("Connection information sent");
            }
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Customer Names");
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderCount();
            MessageBox.Show(count, "Order Count");
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            string names = controller.getShipNames();
            MessageBox.Show(names, "Order Ship Names");
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            string names = controller.getEmployeeNames();
            MessageBox.Show(names, "Employee Names");
        }
    }

    internal class Controller
    {
        string connectionString;
        SqlConnection cnn;

        public Controller()
        {
            connectionString = "Server = localhost\\SQLEXPRESS; Trusted_Connection=true; Database=northwind; User Instance=false; TrustServerCertificate=True; Connection timeout=30;";
        }

        public Controller(string conn)
        {
            connectionString = conn;
        }

        public string getCustomerCount()
        {
            int count = 0;
            string countQuery = "SELECT COUNT(*) FROM customers;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(countQuery, connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return count.ToString();
        }

        public string getCompanyNames()
        {
            string names = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT companyName FROM customers;", connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                names += reader[0].ToString() + "\n";
                            }
                        }
                        else
                        {
                            names = "None";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }

        public string getEmployeeCount()
        {
            int count = 0;
            string countQuery = "SELECT COUNT(*) FROM employees;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(countQuery, connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return count.ToString();
        }

        public string getEmployeeNames()
        {
            string names = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT FirstName + ' ' + LastName FROM employees;", connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                names += reader[0].ToString() + "\n";
                            }
                        }
                        else
                        {
                            names = "None";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }

        public string getOrderCount()
        {
            int count = 0;
            string countQuery = "SELECT COUNT(*) FROM orders;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(countQuery, connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return count.ToString();
        }

        public string getShipNames()
        {
            string names = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT shipname FROM orders;", connection))
            {
                command.CommandType = CommandType.Text;

                if (connection.State == ConnectionState.Closed) connection.Open();

                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                names += reader[0].ToString() + "\n";
                            }
                        }
                        else
                        {
                            names = "None";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return names;
        }
    }
}
