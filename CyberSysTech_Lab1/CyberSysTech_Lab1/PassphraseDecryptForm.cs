using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSysTech_Lab1
{
    public partial class PassphraseDecryptForm : Form
    {
        public PassphraseDecryptForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string decryptpass = this.login_textbox.Text;
            _UserAccountsManager _userAccManager = _UserAccountsManager.getInstance();
            if (_userAccManager.checkDecryptPhrase(decryptpass))
            {
                _userAccManager.setDecryptPass(decryptpass);
                PassphraseEncryptForm passEncrypt = new PassphraseEncryptForm();
                passEncrypt.Show();
                this.Close();
            }
            else
            {
                this.error_label.Show();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
