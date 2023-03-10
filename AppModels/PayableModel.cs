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
    public class PayableModel
    {
        private static DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;

        public static int SaveData(Payables account)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("INSERT INTO tbl_ap (ap_trans_number, ap_customer_name, ap_amount, ap_date, ap_due_date, created_at, updated_at) " +
                    "VALUES(@transNumber, @name, @amount, @date, @dueDate, @created, @updated)", connection);

                command.Parameters.AddWithValue("@transNumber", account.transaction_number);
                command.Parameters.AddWithValue("@name", account.vendor_name);
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

        public static Payables GetById(int id)
        {
            Payables account = new Payables();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_ap WHERE ap_trans_number = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    account.transaction_number = id;
                    account.vendor_name = reader.GetString("ap_customer_name");
                    account.amount = reader.GetDecimal("ap_amount");
                    account.date = reader.GetInt64("ap_date");
                    account.due_date = reader.GetInt64("ap_due_date");
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

        public static List<Payables> GetAllRecords()
        {
            List<Payables> list = new List<Payables>();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_ap", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Payables account = new Payables();

                    account.transaction_number = reader.GetInt32("ap_trans_number");
                    account.vendor_name = reader.GetString("ap_customer_name");
                    account.amount = reader.GetDecimal("ap_amount");
                    account.date = reader.GetInt64("ap_date");
                    account.due_date = reader.GetInt64("ap_due_date");

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

        public static int UpdateData(int id, Payables account)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("UPDATE tbl_ap SET ap_customer_name = @name, ap_amount = @amount, ap_date = @date, ap_due_date = @dueDate, updated_at = @updated WHERE ap_trans_number = @transNumber", connection);

                command.Parameters.AddWithValue("@transNumber", id);
                command.Parameters.AddWithValue("@name", account.vendor_name);
                command.Parameters.AddWithValue("@amount", account.amount);
                command.Parameters.AddWithValue("@date", account.date);
                command.Parameters.AddWithValue("@dueDate", account.due_date);
                command.Parameters.AddWithValue("@updated", now.ToUnixTimeSeconds());

                command.Prepare();

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static int GetMaxID()
        {
            Payables account = new Payables();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT MAX(ap_trans_number) AS `trans_number` FROM tbl_ap", connection);

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

                command = DatabaseManager.setCommand("DELETE FROM tbl_ap WHERE id = @id)", connection);
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
