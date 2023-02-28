using System;
using System.Collections.Generic;
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
    public partial class FormRegister : UserControl
    {
        public FormRegister()
        {
            InitializeComponent();
            componentInit();
        }

        public void componentInit()
        {
            regPassBox.PasswordChar = '⬤';
            regOldPassBox.PasswordChar = '⬤';
        }

        private void registerProcess(Object sender, EventArgs e)
        {
            User user = new User();

            var Username = regUserBox.Text;
            var Password = regPassBox.Text;
            var OldPassword = regOldPassBox.Text;

            if (Password.Equals(OldPassword) && !Username.Equals("")) {
                user.username = Username;
                user.password = Password;
                UserModel.SaveData(user);

                MessageBox.Show("You have successfully registered a new user! Redirecting to Login Form", "User Registration");

                this.Hide();
            }
        }

        private void showLoginForm(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
