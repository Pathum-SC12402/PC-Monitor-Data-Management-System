using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace App
{
    internal class DBconnection
    {
        private static DBconnection instance;
        private MySqlConnection connection;

        private DBconnection()
        {
            try
            {
                string connectionString = "Server=localhost;Database=monitor_data;User Id=root;Password=bbw@8138;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connection Successfully...");
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close(); 
            }
        }

        public static DBconnection GetInstance()
        {
            if (instance == null)
                instance = new DBconnection();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
