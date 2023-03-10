using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Forms;

namespace InventorySystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            componentInit();
        }

        public void componentInit()
        {
            inventoryDash.Hide();
            reportsDash.Hide();
            userDash.Show();

            this.BackColor = ColorTranslator.FromHtml("#f7f7f7");
            logoPanel.BackColor = ColorTranslator.FromHtml("#292b2c");
            sidebarLayout.BackColor = ColorTranslator.FromHtml("#292b2c");
        }

        private void showProduct(object sender, EventArgs e)
        {
            
        }

        private void showInventory(object sender, EventArgs e)
        {
            userDash.Hide();
            reportsDash.Hide();
            inventoryDash.Show();
        }

        private void showDashboard(object sender, EventArgs e)
        {
            inventoryDash.Hide();
            reportsDash.Hide();
            userDash.Show();
        }

        private void inventoryDash_Load(object sender, EventArgs e)
        {

        }

        private void showReport(object sender, EventArgs e)
        {
            inventoryDash.Hide();
            userDash.Hide();
            reportsDash.Show();
        }
    }
}
