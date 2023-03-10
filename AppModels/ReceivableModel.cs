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
    public class ReceivableModel
    {
        private static DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;

        public static int SaveData(Receivables account)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("INSERT INTO tbl_ar (ar_trans_number, ar_customer_name, ar_amount, ar_date, ar_due_date, created_at, updated_at) " +
                    "VALUES(@transNumber, @name, @amount, @date, @dueDate, @created, @updated)", connection);

                command.Parameters.AddWithValue("@transNumber", account.transaction_number);
                command.Parameters.AddWithValue("@name", account.customer_name);
                command.Parameters.AddWithValue("@amount", account.amount);
                command.Parameters.AddWithValue("@date", account.date);
                command.Parameters.AddWithValue("@dueDate", account.due_date);
                command.Parameters.AddWithValue("@created", now.ToUnixTimeSeconds());
                command.Parameters.AddWithValue("@updated", now.ToUnixTimeSeconds());

                command.Prepare();

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static Receivables GetById(int id)
        {
            Receivables account = new Receivables();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_ar WHERE ar_trans_number = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    account.transaction_number = id;
                    account.customer_name = reader.GetString("ar_customer_name");
                    account.amount = reader.GetDecimal("ar_amount");
                    account.date = reader.GetInt64("ar_date");
                    account.due_date = reader.GetInt64("ar_due_date");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return account;
        }

        public static List<Receivables> GetAllRecords()
        {
            List<Receivables> list = new List<Receivables>();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_ar", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Receivables account = new Receivables();

                    account.transaction_number = reader.GetInt32("ar_trans_number");
                    account.customer_name = reader.GetString("ar_customer_name");
                    account.amount = reader.GetDecimal("ar_amount");
                    account.date = reader.GetInt64("ar_date");
                    account.due_date = reader.GetInt64("ar_due_date");

                    list.Add(account);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        public static int UpdateData(int id, Receivables account)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("UPDATE tbl_ar SET ar_customer_name = @name, ar_amount = @amount, ar_date = @date, ar_due_date = @dueDate, updated_at = @updated WHERE ar_trans_number = @transNumber", connection);

                command.Parameters.AddWithValue("@transNumber", id);
                command.Parameters.AddWithValue("@name", account.customer_name);
                command.Parameters.AddWithValue("@amount", account.amount);
                command.Parameters.AddWithValue("@date", account.date);
                command.Parameters.AddWithValue("@dueDate", account.due_date);
                command.Parameters.AddWithValue("@updated", now.ToUnixTimeSeconds());

                command.Prepare();

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static int GetMaxID()
        {
            Receivables account = new Receivables();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT MAX(ar_trans_number) AS `trans_number` FROM tbl_ar", connection);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return reader.IsDBNull(0) ? 1 : reader.GetInt32(0) + 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static int DeleteData(int id)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("DELETE FROM tbl_ar WHERE id = @id)", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }
    }
}
