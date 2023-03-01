using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using MySql.Data.MySqlClient;

using App.Database;
using App.Objects;

namespace App.Models
{
    public class UserModel
    {
        private static DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;
        public static int SaveData(User user) {
            try {
                connection.Open();

                command = DatabaseManager.setCommand("INSERT INTO pos_users (username, password, user_type, created_at, updated_at)" +
                    "VALUES (@username, @password, @user_type, @created_at, @updated_at)", connection);

                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@user_type", 1);
                command.Parameters.AddWithValue("@created_at", now.ToUnixTimeSeconds());
                command.Parameters.AddWithValue("@updated_at", now.ToUnixTimeSeconds());
                command.Prepare();

                return command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally {
                connection.Close();
            }

            return 0;
        }

        public static User GetById(int id) {
            User user = new User();

            try {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM pos_users WHERE id = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read()) {
                    user.username = reader.GetString("username");
                    user.password = reader.GetString("password");
                    user.userType = reader.GetInt32("user_type");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally {
                connection.Close();
            }

            return user;
        }

        public static List<User> GetAllRecords() {
            List<User> list = new List<User>();

            try {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM pos_users", connection);
                reader = command.ExecuteReader();

                while (reader.Read()) {
                    User user = new User();

                    user.username = reader.GetString("username");
                    user.password = reader.GetString("password");
                    user.userType = reader.GetInt32("user_type");

                    list.Add(user);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally {
                connection.Close();
            }

            return list;
        }

        public static int UpdateData(int id, User user) {
            try {
                connection.Open();

                command = DatabaseManager.setCommand("UPDATE pos_users SET username = @username, password = @password, user_type = @user_type, updated_at = @updated_at WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@user_type", user.userType);
                command.Parameters.AddWithValue("@updated_at", now.ToUnixTimeSeconds());
                command.Prepare();

                return command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally {
                connection.Close();
            }

            return 0;
        }

        public static int DeleteData(int id) {
            try {
                connection.Open();

                command = DatabaseManager.setCommand("DELETE FROM pos_users WHERE id = @id)", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                return command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.StackTrace, ex.Message);
            } finally {
                connection.Close();
            }

            return 0;
        }
    }
}
