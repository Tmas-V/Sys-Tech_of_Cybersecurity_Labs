using System;
namespace InstallerLibrary
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            CustomInstaller1 ci = new CustomInstaller1();
            ci.setRegKey();
        }
    }
}