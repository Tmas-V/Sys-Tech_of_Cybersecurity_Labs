using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CyberSysTech_Lab1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        private void login_button_Click(object sender, EventArgs e)
        {
            _UserAccountsManager _userAccManager = _UserAccountsManager.getInstance();
            _UserData userData = new _UserData();
            bool checkCreds = _userAccManager.checkIfUserExists(this.login_textbox.Text, this.password_textbox.Text, ref userData);
            if (checkCreds)
            {
                if (!userData._blocked)
                {
                    if (userData._ID.Equals(_UserAccountsManager.adminID))
                    {
                        MainMenuAdmin mainMenu = new MainMenuAdmin(userData);
                        mainMenu.Show();
                    }
                    else
                    {
                        MainMenu mainMenu = new MainMenu(userData);
                        mainMenu.Show();
                    }
                    this.login_textbox.Text = "";
                    this.password_textbox.Text = "";
                    this.Close();
                }
                else
                {
                    LoginErrorDialog logErrDialog = new LoginErrorDialog(this, "This user account is blocked.");
                    this.Enabled = false;
                    logErrDialog.Show();
                }
            }
            else
            {
                LoginErrorDialog logErrDialog = new LoginErrorDialog(this, "The login and/or the password are incorrect.");
                this.Enabled = false;
                logErrDialog.Show();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow(this);
            this.Enabled = false;
            aboutWindow.Show();
        }
    }
}
