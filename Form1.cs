using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IT481_Unit_2_Assignment_Nick_Rozzi
{
    public partial class Form1 : Form
    {
        DB database;
        string dbConnString = "Server = localhost\\SQLEXPRESS; Trusted_Connection=true; Database=northwind; User Instance=false; TrustServerCertificate=True; Connection timeout=30;";
        bool databaseCreated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            database = new DB(dbConnString);
            databaseCreated = true;
            MessageBox.Show("Connection Information Sent");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (databaseCreated == false)
            {
                database = new DB(dbConnString);
                databaseCreated = true;
            }
            string count = database.getCustomerCount();
            MessageBox.Show(count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (databaseCreated == false)
            {
                database = new DB(dbConnString);
                databaseCreated = true;
            }
            string companyNames = database.getCompanyNames();
            MessageBox.Show(companyNames);
        }
    }

    class DB
    {
        string connectionString;

        public DB()
        {
            connectionString = "Server = localhost\\SQLEXPRESS; Trusted_Connection=true; Database=northwind; User Instance=false; TrustServerCertificate=True; Connection timeout=30;";
        }

        public DB(string pConnString)
        {
            connectionString = pConnString;
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
    }
}
