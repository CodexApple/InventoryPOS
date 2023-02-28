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

            inventoryDash.Show();
        }

        private void showDashboard(object sender, EventArgs e)
        {
            inventoryDash.Hide();

            userDash.Show();
        }
    }
}
