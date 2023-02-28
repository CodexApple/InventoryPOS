﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace App.Database
{
    public class DatabaseManager
    {
        private static string SERVER = "localhost";
        private static string PORT = "40000";
        private static string USERNAME = "root";
        private static string PASSWORD = "root";
        private static string DATABASE = "inventory_pos";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection();

            try {
                connection.ConnectionString = string.Format("server={0}; port={1}; uid={2}; pwd={3}; database={4}", SERVER, PORT, USERNAME, PASSWORD, DATABASE);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }

        public static MySqlCommand setCommand(String query, MySqlConnection connection)
        {
            var mySqlCommand = new MySqlCommand(query, connection);

            return mySqlCommand;
        }
    }
}
