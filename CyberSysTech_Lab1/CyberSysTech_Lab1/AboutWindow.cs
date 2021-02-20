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
    public partial class AboutWindow : Form
    {
        private LoginForm loginForm;
        public AboutWindow()
        {
            InitializeComponent();
            loginForm = null;
        }
        public AboutWindow(LoginForm caller)
        {
            InitializeComponent();
            loginForm = caller;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            loginForm.Enabled = true;
            this.Close();
        }
    }
}
