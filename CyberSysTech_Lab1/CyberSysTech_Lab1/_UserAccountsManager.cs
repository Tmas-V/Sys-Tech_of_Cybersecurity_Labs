using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace CyberSysTech_Lab1
{
    class _UserAccountsManager
    {
        private List<_UserData> _usersList;
        private static _UserAccountsManager _userAccManager = null;
        private static string _saveFileName = "passwd.txt";
        private static string delimiter = "::";
        public static string adminID = "0000";
        private string nextUserID = "0000";
        public static string lastUserID = "9999";
        public static int maxUserCount = 7;

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
        private void initializeUsersList()
        {
            string adminUserData = "ADMIN::0000::e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855::0::1::1::0";
            _usersList = new List<_UserData>();
			if (!File.Exists(_saveFileName))
            {
				string[] defaultUserCred = new string[1];
				defaultUserCred[0] = adminUserData;
				File.WriteAllLines(_saveFileName, defaultUserCred);
            }

			string[] usersDataLines;
			usersDataLines = File.ReadAllLines(_saveFileName);
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
        }
        public static _UserAccountsManager getInstance()
        {
            if (_userAccManager == null)
            {
                _userAccManager = new _UserAccountsManager();
            }
            if (_userAccManager._usersList == null)
            {
                _userAccManager.initializeUsersList();
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
            usersDataLines = File.ReadAllLines(_saveFileName);
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
                    File.WriteAllLines(_saveFileName, usersDataLines);
                    return;
                }
            }
        }
        public void appendNewUserData(_UserData userData)
        {
            if (userData == null) return;
            string[] userDataFields = new string[1];
            userDataFields[0] = userDataToString(ref userData);
            _usersList.Append<_UserData>(new _UserData(ref userData));
            File.AppendAllLines(_saveFileName, userDataFields);
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
            string[] usersDataLines = File.ReadAllLines(_saveFileName);
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
            File.WriteAllLines(_saveFileName, newUserDataLines);
        }
    }
}
