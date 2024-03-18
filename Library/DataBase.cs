using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Library
{
    internal class DataBase
    {
        // SqlConnection object to manage the connection to the database
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AHJPH50\SQLEXPRESS01; Initial Catalog=Library; Integrated Security=True");

        // Method to open the database connection
        public void openConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    Console.WriteLine("Connection opened successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        // Method to close the database connection
        public void closeConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                    Console.WriteLine("Connection closed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }

        public SqlConnection getSqlConnection()
        {
            return sqlConnection;
        }
    }
}
