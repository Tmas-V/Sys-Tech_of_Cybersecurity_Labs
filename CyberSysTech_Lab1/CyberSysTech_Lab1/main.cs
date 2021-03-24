using System;
using System.Windows.Forms;
using InstallerLibrary;

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
            CustomInstaller1 ic = new CustomInstaller1();
            if (!ic.verify(ic.assembleInfoString(), ic.getRegKey()))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                OnStartUpErrorForm errForm = new OnStartUpErrorForm();
                errForm.Show();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                PassphraseDecryptForm passDecryptForm = new PassphraseDecryptForm();
                passDecryptForm.Show();
            }
            Application.Run();
        }
    }
}
