using InventorySystem.Forms;
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

namespace App.Forms
{
    public partial class InventoryDash : UserControl
    {
        string config = default;
        int id = default;
        public InventoryDash()
        {
            InitializeComponent();
            componentInit();
        }

        public void componentInit()
        {
            this.Hide();
        }
        private void addProductButton_click(object sender, EventArgs e)
        {
            config = "Add";
            formAddProduct form = new formAddProduct(config);
            form.ShowDialog();
            LoadGrid();
            form.Dispose();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            config = "Edit";
            formAddProduct form = new formAddProduct(config, this.id);
            form.ShowDialog();
            LoadGrid();
            form.Dispose();

      
        }

        private void InventoryDash_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        }

        public void LoadGrid() {

            var something = ProductModel.GetAllRecords();
            var bindingList = new BindingList<Products>(something);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formProductReport().Show();
        }
    }
}
