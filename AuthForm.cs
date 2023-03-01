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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            componentInit();
        }

        public void componentInit()
        {
            formRegister.Hide();
            passwordBox.PasswordChar = '⬤';
        }

        private void loginProcess(object sender, EventArgs e)
        {
            var formDashboard = new Dashboard();
            var formPOSBoard = new POSBoard();
            //formDashboard.Show();

            
            User user = new User();

            user.username = usernameBox.Text;
            user.password = passwordBox.Text;

            if (Authentication.Authenticate(user) > 0)
            {
                this.Hide();

                if (Session.userType == 2)
                {
                    
                    formPOSBoard.Show();
                }
                else 
                {
                    formDashboard.Show();

                }

                
                
            } else MessageBox.Show("You have entered an invalid credentials\nPlease try again.", "Authentication");
            
        }

        private void showRegisterForm(object sender, EventArgs e)
        {
            formRegister.Show();
        }
    }
}
