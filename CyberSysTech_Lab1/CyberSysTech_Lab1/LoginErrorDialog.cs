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
    public partial class LoginErrorDialog : Form
    {
        private LoginForm calleeLoginForm;
        private string errorStr;
        public LoginErrorDialog()
        {
            calleeLoginForm = null;
            errorStr = "";
            InitializeComponent();
        }
        public LoginErrorDialog(LoginForm loginForm, string errorLabel)
        {
            calleeLoginForm = loginForm;
            errorStr = errorLabel;
            InitializeComponent();
            this.error_label.Text = errorStr;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            calleeLoginForm.Enabled = true;
            this.Close();
        }
    }
}
