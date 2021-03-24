using System;
using System.Collections.Generic;
using System.IO;



namespace CyberSysTech_Lab1
{
    class _UserAccountsManager
    {
        private List<_UserData> _usersList;
        private static _UserAccountsManager _userAccManager = null;
        private static string _saveFileName = "passwd.txt";
        private static string _TMPsaveFileName = "tmp.txt";
        private static string delimiter = "::";
        public static string adminID = "0000";
        private string nextUserID = "0000";
        public static string lastUserID = "9999";
        public static int maxUserCount = 7;
        private static string defaultDecryptPass = "lab3-gakh";
        private static string passphraseDecrypt = "";
        private static string passphraseEncrypt = "";
        private static int randomValueRange = 999999999;
        private _UserAccountsManager()
        {
            _usersList = null;
        }
        public int getListLen()
        {
            return _usersList.Count;
        }
        public _UserData getFromList(int pos)
        {
            if ((pos<0) || (pos >= _usersList.Count))
            {
                return null;
            }
            return _usersList[pos];
        }
        private void createPasswdFile()
        {
            if (!File.Exists(_saveFileName))
            {
                string adminUserData = "ADMIN::0000::e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855::0::1::1::0";
                
                CryptoAPI_class crypto = CryptoAPI_class.Instance();
                Random rand = new Random();
                string salt = rand.Next(randomValueRange).ToString();
                string[] lines = new string[2];
                lines[0] = salt;
                lines[1] = crypto.go_encryption(adminUserData, defaultDecryptPass + salt);
                File.WriteAllLines(_saveFileName, lines);
            }
        }
        private bool checkStringsFormat(string[] fileContent)
        {
            if (fileContent == null) return false;
            for (int i = 0; i < fileContent.Length; i++)
            {
                string[] userDataFields = fileContent[i].Split(delimiter.ToCharArray());
                if (userDataFields.Length != 13) return false;
            }
            return true;
        }
        private bool checkFileContents()
        {
            if (!File.Exists(_saveFileName))
            {
                return false;
            }
            string[] usersDataLines = File.ReadAllLines(_saveFileName);
            return checkStringsFormat(usersDataLines);
        }
        public bool checkDecryptPhrase(string decryptpass)
        {
            if (!File.Exists(_saveFileName))
            {
                return false;
            }
            CryptoAPI_class crypto = CryptoAPI_class.Instance();
            string[] lines = File.ReadAllLines(_saveFileName);
            if (lines.Length != 2) return false;
            string decrypted = crypto.go_decryption(lines[1], decryptpass + lines[0]);
            if (decrypted == null) return false;
            lines = decrypted.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            return checkStringsFormat(lines);
        }
        public void setDecryptPass(string decryptpass)
        {
            passphraseDecrypt = decryptpass;
        }
        public void setEncryptPass(string encryptpass)
        {
            passphraseEncrypt = encryptpass;
        }
        public void initializeUsersList()
        {
            if (_usersList != null) return;
            _usersList = new List<_UserData>();
			string[] usersDataLines;
            CryptoAPI_class crypto = CryptoAPI_class.Instance();
            string[] lines = File.ReadAllLines(_saveFileName);
            string decrypted = crypto.go_decryption(lines[1], passphraseDecrypt + lines[0]);
            usersDataLines = decrypted.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < usersDataLines.Length; i++)
            {
                string[] userDataFields = usersDataLines[i].Split(delimiter.ToCharArray());
                _UserData newUserData = new _UserData(userDataFields[0], userDataFields[2], userDataFields[4], (Int32.Parse(userDataFields[6]) != 0), (Int32.Parse(userDataFields[8]) != 0), (Int32.Parse(userDataFields[10])), (Int32.Parse(userDataFields[12])));
                _usersList.Add(newUserData);
                if (Int32.Parse(nextUserID) < Int32.Parse(userDataFields[2]))
                {
                    nextUserID = userDataFields[2];
                }
            }
            nextUserID = calculateNextUserID();
            File.WriteAllLines(_TMPsaveFileName, usersDataLines);
        }
        public void endSession()
        {
            if (!File.Exists(_TMPsaveFileName))
            {
                return;
            }
            CryptoAPI_class crypto = CryptoAPI_class.Instance();
            Random rand = new Random();
            string salt = rand.Next(randomValueRange).ToString();
            string[] lines = new string[2];
            lines[0] = salt;
            lines[1] = crypto.go_encryption(File.ReadAllText(_TMPsaveFileName), passphraseEncrypt + lines[0]);
            File.WriteAllLines(_saveFileName, lines);
            File.Delete(_TMPsaveFileName);
        }
        public static _UserAccountsManager getInstance()
        {
            if (_userAccManager == null)
            {
                _userAccManager = new _UserAccountsManager();
            }
            if (!File.Exists(_saveFileName))
            {
                _userAccManager.createPasswdFile();
            }
            
            return _userAccManager;
        }
        public string getNextUserID()
        {
            return nextUserID;
        }
        private string calculateNextUserID()
        {
            string temp = (Int32.Parse(nextUserID) + 1).ToString();
            if (temp.Length > lastUserID.Length)
            {
                return lastUserID;
            }    
            while (temp.Length < lastUserID.Length)
            {
                temp = "0" + temp;
            }
            return temp;
        }
        public static string userDataToString(ref _UserData userData)
        {
            if (userData == null) return "";
            return userData._login + delimiter + userData._ID + delimiter + userData._passhash + delimiter + (userData._blocked?1:0).ToString() + delimiter + (userData._allowPassRestrict?1:0).ToString() + delimiter + (userData._passRestrict._minLength).ToString() + delimiter + (userData._passRestrict._passRegexIndex).ToString();
        }
        
        public bool checkIfUserExists(string login,string password, ref _UserData userData)
        {
	        if (_usersList == null) return false;
            userData = null;
            string passwordHashed = _UserData.getHash(password);

            bool res = false, sub_res = false;
	        foreach(_UserData _userData in _usersList)
	        {
                sub_res = _userData.compareCredentials(login, passwordHashed);
                if (sub_res)
                {
                    userData = _userData;
                }
		        res = sub_res || res;
	        }
	        return res;
        }
        public void saveUserData(_UserData userData)
        {
            if (userData == null) return;
            string[] usersDataLines;
            usersDataLines = File.ReadAllLines(_TMPsaveFileName);
            foreach(_UserData iter in _usersList)
            {
                if (iter._ID.Equals(userData._ID))
                {
                    iter.writeUserData(userData);
                    break;
                }
            }
            for (int i = 0; i < usersDataLines.Length; i++)
            {
                string[] userDataFields = usersDataLines[i].Split(delimiter.ToCharArray());
                if (userDataFields[2].Equals(userData._ID))
                {
                    usersDataLines[i] = userDataToString(ref userData);
                    File.WriteAllLines(_TMPsaveFileName, usersDataLines);
                    return;
                }
            }
        }
        public void appendNewUserData(_UserData userData)
        {
            if (userData == null) return;
            string[] userDataFields = new string[1];
            userDataFields[0] = userDataToString(ref userData);
            _usersList.Add(new _UserData(ref userData));
            File.AppendAllLines(_TMPsaveFileName, userDataFields);
            nextUserID = calculateNextUserID();
        }

        public void removeUserData(_UserData userData)
        {
            if (userData == null) return;
            for(int i = 0; i<_usersList.Count; i++)
            {
                if (_usersList[i]._ID.Equals(userData._ID))
                {
                    _usersList.RemoveAt(i);
                    break;
                }
            }
            string[] usersDataLines = File.ReadAllLines(_TMPsaveFileName);
            string[] newUserDataLines = new string[usersDataLines.Length - 1];
            int offset = 0;
            for (int i = 0; i < usersDataLines.Length; i++)
            {
                string[] userDataFields = usersDataLines[i].Split(delimiter.ToCharArray());
                if (!userDataFields[2].Equals(userData._ID))
                {
                    newUserDataLines[i - offset] = usersDataLines[i];
                }
                else
                {
                    offset = 1;
                }
            }
            File.WriteAllLines(_TMPsaveFileName, newUserDataLines);
        }
    }
}
