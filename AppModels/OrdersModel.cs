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
    public class OrdersModel
    {
        private static DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;

        public static int SaveData(Orders order)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("INSERT INTO tbl_orders (order_id, product_id, order_quantity, order_date, created_at, updated_at) " +
                    "VALUES(@oid, @pid, @quantity, @date, @created, @updated)", connection);

                command.Parameters.AddWithValue("@oid", order.order_id);
                command.Parameters.AddWithValue("@pid", order.prod_id);
                command.Parameters.AddWithValue("@quantity", order.quantity);
                command.Parameters.AddWithValue("@date", now.ToUnixTimeSeconds());
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

        public static Orders GetById(int id)
        {
            Orders order = new Orders();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_orders WHERE order_id = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    order.order_id = reader.GetInt32("order_id");
                    order.prod_id = reader.GetInt32("product_id");
                    order.quantity = reader.GetInt32("order_quantity");
                    order.date = reader.GetInt32("order_date");
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

            return order;
        }

        public static int GetOrderID()
        {
            Orders order = new Orders();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT MAX(order_id) AS `order_id` FROM tbl_orders", connection);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader == null) {

                    return order.order_id = 1;

                }

                if (reader.Read())
                {

                   return order.order_id = reader.GetInt32("order_id")+1;
                    
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

        public static List<Orders> GetAllRecords(int orderid)
        {
            List<Orders> list = new List<Orders>();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_orders INNER JOIN tbl_products ON tbl_orders.product_id = tbl_products.product_id WHERE tbl_orders.order_id = @id", connection);
                command.Parameters.AddWithValue("@id", orderid);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Orders order = new Orders();

                    order.order_id = reader.GetInt32("order_id");
                    order.prod_id = reader.GetInt32("product_id");
                    order.quantity = reader.GetInt32("order_quantity");
                    order.date = reader.GetInt32("order_date");

                    order._name = reader.GetString("prod_name");
                    order._price = reader.GetInt32("prod_price");

                    list.Add(order);
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

        public static decimal GetGrandTotal(int orderid)
        {
            
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT SUM(tbl_products.prod_price * tbl_orders.order_quantity) AS `GrandTotal` FROM tbl_orders INNER JOIN tbl_products ON tbl_orders.product_id = tbl_products.product_id WHERE tbl_orders.order_id = @id", connection);
                command.Parameters.AddWithValue("@id", orderid);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetDecimal("GrandTotal");
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

                command = DatabaseManager.setCommand("DELETE FROM tbl_orders WHERE id = @id)", connection);
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
