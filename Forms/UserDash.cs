using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class UserDash : UserControl
    {
        public UserDash()
        {
            InitializeComponent();
            componentInit();
        }

        public void componentInit()
        {
            statsPanel1.BackColor = ColorTranslator.FromHtml("#0275d8");
            statsPanel2.BackColor = ColorTranslator.FromHtml("#5cb85c");
            statsPanel3.BackColor = ColorTranslator.FromHtml("#f0ad4e");
            statsPanel4.BackColor = ColorTranslator.FromHtml("#d9534f");

            this.totalBarcode.Text = "10023";
            this.totalProducts.Text = "12356";
            this.totalPrice.Text = "98235";
            this.totalUsers.Text = "5323";
        }
    }
}
