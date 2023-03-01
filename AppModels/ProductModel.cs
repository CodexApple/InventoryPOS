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
    internal class ProductModel
    {
        private static DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
        private static MySqlConnection connection = DatabaseManager.GetConnection();
        private static MySqlCommand command = null;
        private static MySqlDataReader reader = null;

        public static int SaveData(Products product)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("INSERT INTO tbl_products (prod_name, prod_discount, prod_barcode, prod_dimension, prod_stock, prod_price, prod_status, created_at, updated_at)" +
                    "VALUES (@name, @discount, @barcode, @dimension, @stock, @price, @status, @created, @updated)", connection);

                command.Parameters.AddWithValue("@name", product.name);
                command.Parameters.AddWithValue("@discount", product.discount);
                command.Parameters.AddWithValue("@barcode", product.barcode);
                command.Parameters.AddWithValue("@dimension", product.dimension);
                command.Parameters.AddWithValue("@stock", product.stock);
                command.Parameters.AddWithValue("@price", product.price);
                command.Parameters.AddWithValue("@status", product.status);
                command.Parameters.AddWithValue("@created_at", now.ToUnixTimeSeconds());
                command.Parameters.AddWithValue("@updated_at", now.ToUnixTimeSeconds());
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

        public static Products GetById(string id)
        {
            Products product = new Products();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_products WHERE prod_barcode = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    product.id = reader.GetInt32("product_id");
                    product.name = reader.GetString("prod_name");
                    product.discount = reader.GetInt32("prod_discount");
                    product.barcode = reader.GetString("prod_barcode");
                    product.dimension = reader.GetString("prod_dimension");
                    product.stock = reader.GetInt32("prod_stock");
                    product.price = reader.GetInt32("prod_price");
                    product.status = reader.GetInt32("prod_status");

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

            return product;
        }

        public static List<Products> GetAllRecords()
        {
            List<Products> list = new List<Products>();

            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("SELECT * FROM tbl_products", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Products product = new Products();

                    product.name = reader.GetString("prod_name");
                    product.discount = reader.GetInt32("prod_discount");
                    product.barcode = reader.GetString("prod_barcode");
                    product.dimension = reader.GetString("prod_dimension");
                    product.stock = reader.GetInt32("prod_stock");
                    product.price = reader.GetInt32("prod_price");
                    product.status = reader.GetInt32("prod_status");

                    list.Add(product);
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

        public static int DeleteData(int id)
        {
            try
            {
                connection.Open();

                command = DatabaseManager.setCommand("DELETE FROM tbl_products WHERE id = @id)", connection);
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
