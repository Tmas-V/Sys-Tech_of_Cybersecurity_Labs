using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberSysTech_Lab1
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _UserAccountsManager _userAccManager = _UserAccountsManager.getInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Application.Run();
        }
    }
}
