using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;
using App.Objects;

namespace InventorySystem.Forms
{
    public partial class formAddProduct : Form
    {
        string config = default;
        int id = default;
        public formAddProduct(string config, int id = default)
        {
            InitializeComponent();
            this.config = config.Trim();
            this.id = id;
        }

        private void formAddProduct_Load(object sender, EventArgs e)
        {
            if (config.Equals("Add")) {
                productIDTextBox.Text = Convert.ToString(ProductModel.GetMaxID());
            }
            else
            {
                Products product = ProductModel.GetByProductId(this.id);

                productNameTextBox.Text = product.name;
                productDiscountTextBox.Text = Convert.ToString(product.discount);
                productBarcodeTextBox.Text = product.barcode;
                productDimensionsTextBox.Text = product.dimension;
                productStockTextBox.Text = Convert.ToString(product.stock);
                productPriceTextBox.Text = Convert.ToString(product.price);
                productStatusTextBox.Text = Convert.ToString(product.status);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products product = new Products();

            if (config.Equals("Add"))
            {
                //Add Button

                if (ProductModel.CheckByBarcodeId(productBarcodeTextBox.Text))
                {
                    MessageBox.Show("Barcode already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    product.name = productNameTextBox.Text;
                    product.discount = Convert.ToInt32(productDiscountTextBox.Text);
                    product.barcode = productBarcodeTextBox.Text;
                    product.dimension = productDimensionsTextBox.Text;
                    product.stock = Convert.ToInt32(productStockTextBox.Text);
                    product.price = Convert.ToDecimal(productPriceTextBox.Text);
                    product.status = Convert.ToInt32(productStatusTextBox.Text);

                    ProductModel.SaveData(product);

                    MessageBox.Show("Product saved successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }

            }

            else {
                //Edit Button

                product.name = productNameTextBox.Text;
                product.discount = Convert.ToInt32(productDiscountTextBox.Text);
                product.barcode = productBarcodeTextBox.Text;
                product.dimension = productDimensionsTextBox.Text;
                product.stock = Convert.ToInt32(productStockTextBox.Text);
                product.price = Convert.ToDecimal(productPriceTextBox.Text);
                product.status = Convert.ToInt32(productStatusTextBox.Text);

                ProductModel.UpdateData(this.id, product);

                MessageBox.Show("Product updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
