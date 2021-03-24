using System;
using System.Windows.Forms;

namespace CyberSysTech_Lab1
{
    public partial class PassphraseEncryptForm : Form
    {
        public PassphraseEncryptForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string encryptpass = this.login_textbox.Text;
            _UserAccountsManager _userAccManager = _UserAccountsManager.getInstance();
            _userAccManager.setEncryptPass(encryptpass);
            _userAccManager.initializeUsersList();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
