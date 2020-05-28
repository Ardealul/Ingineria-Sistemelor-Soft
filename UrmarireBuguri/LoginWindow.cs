using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.controller;

namespace UrmarireBuguri
{
    public partial class LoginWindow : Form
    {
        private LoginController loginController;

        public LoginWindow(LoginController loginController)
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 20;
            usernameTextBox.MaxLength = 20;
            this.loginController = loginController;
        }

        private void clearFields()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginAdminButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            loginController.loginAdmin(username, password);
            clearFields();
        }

        private void loginProgramatorButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            loginController.loginProgramator(username, password);
            clearFields();
        }

        private void loginVerificatorButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            loginController.loginVerificator(username, password);
            clearFields();
        }
    }
}
