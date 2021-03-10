using System;
using System.Text;
using System.ComponentModel;
using System.Configuration.Install;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;
using System.IO;

namespace InstallerLibrary
{
    [RunInstaller(true)]
    public partial class CustomInstaller1 : System.Configuration.Install.Installer
    {
        public CustomInstaller1()
        {
            //this.BeforeInstall += new InstallEventHandler(BeforeInstallEventHandler);
            InitializeComponent();
        }
        private void BeforeInstallEventHandler(object sender, InstallEventArgs e)
        {
            this.setRegKey();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);
        public string assembleInfoString()
        {
            string userName = Environment.UserName;
            string compName = Environment.MachineName;
            string winDirPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            string winSysDirPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            string mouseButCount = GetSystemMetrics(43).ToString();
            string screenHeight = GetSystemMetrics(1).ToString();
            string[] logDrivesNames = Environment.GetLogicalDrives();
            DriveInfo di = new DriveInfo("C:\\");
            string fileSys = di.DriveFormat;
            string res = userName + compName + winDirPath + winSysDirPath + mouseButCount + screenHeight;
            foreach (string str in logDrivesNames)
            {
                res += str;
            }
            res += fileSys;
            return res;
        }

        private byte[] sign(string text)
        {
            X509Store my = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            //my.Open(OpenFlags.ReadOnly);
            if (my.Certificates.Count == 0)
            {
                SHA1Managed sha1 = new SHA1Managed();
                byte[] data = new UnicodeEncoding().GetBytes(text);
                byte[] hash = sha1.ComputeHash(data);
                return hash;
            }
            else
            {
                RSACryptoServiceProvider csp = (RSACryptoServiceProvider)my.Certificates[0].PrivateKey;
                SHA1Managed sha1 = new SHA1Managed();
                byte[] data = new UnicodeEncoding().GetBytes(text);
                byte[] hash = sha1.ComputeHash(data);
                return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
            }
        }
        public bool verify(string text, byte[] signature)
        {
            if (signature == null)
            {
                return false;
            }
            X509Store my = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            //my.Open(OpenFlags.ReadOnly);
            if (my.Certificates.Count == 0)
            {
                SHA1Managed sha1 = new SHA1Managed();
                byte[] data = new UnicodeEncoding().GetBytes(text);
                byte[] hash = sha1.ComputeHash(data);
                return (hash.ToString().CompareTo(signature.ToString()) == 0) ? true : false ;
            }
            else
            {
                RSACryptoServiceProvider csp = (RSACryptoServiceProvider)my.Certificates[0].PublicKey.Key;
                SHA1Managed sha1 = new SHA1Managed();
                byte[] data = new UnicodeEncoding().GetBytes(text);
                byte[] hash = sha1.ComputeHash(data);
                return csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
            }
        }
        public void setRegKey()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("Gakh");
            key = key.OpenSubKey("Gakh", true);
            key.SetValue("Signature", sign(assembleInfoString()), RegistryValueKind.Binary);
        }
        public byte[] getRegKey()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", false);
            key = key.OpenSubKey("Gakh", false);
            if (key == null) return null;
            return (byte[])key.GetValue("Signature", null);
        }
    }
}
