using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using App.Database;
using App.Objects;
using System.Windows;

namespace App.Models
{
    public class Authentication
    {
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;

        public static int Authenticate(User user)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM pos_users WHERE username = @username AND password = @password", connection);
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally
            {
                connection.Close();
            }

            return 0;
        }
    }
}
