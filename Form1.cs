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
                controller = new Controller("Server = " + server + "\\SQLEXPRESS;" +
                                            "Database= " + database + ";" +
                                            "User Id = " + user + ";" +
                                            "Password = " + password + ";" +
                                            "TrustServerCertificate=True;" +
                                            "Connection timeout=30;");

                MessageBox.Show("Connection information sent");
            }
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                string count = controller.getCustomerCount();
                MessageBox.Show(count, "Customer Count");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                string names = controller.getCompanyNames();
                MessageBox.Show(names, "Customer Names");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            try
            {
                string count = controller.getOrderCount();
                MessageBox.Show(count, "Order Count");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            try
            {
                string names = controller.getShipNames();
                MessageBox.Show(names, "Order Ship Names");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            try
            {
                string count = controller.getEmployeeCount();
                MessageBox.Show(count, "Employee Count");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            try
            {
                string names = controller.getEmployeeNames();
                MessageBox.Show(names, "Employee Names");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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

                count = Convert.ToInt32(command.ExecuteScalar());

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

                count = Convert.ToInt32(command.ExecuteScalar());
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

                count = Convert.ToInt32(command.ExecuteScalar());
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
            return names;
        }
    }
}
