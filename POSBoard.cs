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

namespace InventorySystem
{
    public partial class POSBoard : Form
    {

        public POSBoard()
        {
            InitializeComponent();
            MessageBox.Show("Successfully logged In!", "Authentication");
        }

        private void POSBoard_Load(object sender, EventArgs e)
        {

            orderidTextbox.Text =  Convert.ToString(OrdersModel.GetOrderID());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            Products products = ProductModel.GetByBarcodeId(barcodeidTextbox.Text);
          
            orders.order_id = int.Parse(orderidTextbox.Text);
            orders.prod_id = products.id;
            orders.quantity = int.Parse(quantityTextbox.Text);

            if (OrdersModel.SaveData(orders) > 0) 
            {
                MessageBox.Show("Item added successfully");
            }

            var something = OrdersModel.GetAllRecords(int.Parse(orderidTextbox.Text));
            var bindingList = new BindingList<Orders>(something);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            grandTotalTextBox.Text = Convert.ToString(OrdersModel.GetGrandTotal(int.Parse(orderidTextbox.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Current items from order table will be transferred to pos_sales table
        }
    }
}
