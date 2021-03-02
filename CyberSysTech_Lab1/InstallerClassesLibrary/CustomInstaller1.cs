using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;

namespace InstallerClassesLibrary
{
    [RunInstaller(true)]
    public partial class CustomInstaller1 : System.Configuration.Install.Installer
    {
        public CustomInstaller1()
        {
            InitializeComponent();
        }
    }
}
