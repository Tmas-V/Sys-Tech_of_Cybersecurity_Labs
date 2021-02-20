using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;



namespace CyberSysTech_Lab1
{
	public class _passwordRestriction
	{
		public int _minLength { get; private set; }
		public int _passRegexIndex { get; private set; }
		public static int def_min_len = 1;
		public static int def_pass_regex_Index = 0;
		public static int premadeRegexArrLen = 2;
		public static string[] premadeRegex = {"", @"^[a-zA-Z0-9,.!?;:]+(?![^a-zA-Z0-9,.!?;:])$" };
		public _passwordRestriction()
        {
			_minLength = def_min_len;
			_passRegexIndex = def_pass_regex_Index;
		}
		public _passwordRestriction(int minLen, int regex_num)
        {
			_minLength = minLen;
			_passRegexIndex = regex_num;
		}
		public _passwordRestriction(ref _passwordRestriction passRestrict)
		{
			_minLength = passRestrict._minLength;
			_passRegexIndex = passRestrict._passRegexIndex;
		}
		public static string getRegexFriendlyName(int pos)
        {
			switch (pos)
			{
				case 0: return "No restrictions.";
				case 1: return "Only a-Z/0-9/.,?! allowed.";
				default: return "";
            }
        }
	}
	public class _UserData
	{
		public string _login { get; private set; }
		public string _ID { get; private set; }
		public string _passhash { get; private set; }
		public bool _blocked { get; private set; }
		public bool _allowPassRestrict { get; private set; }
		public _passwordRestriction _passRestrict;
		public _UserData()
        {
			_login = "";
			_ID = "";
			_passhash = "";
			_blocked = true;
			_allowPassRestrict = true;
			_passRestrict = new _passwordRestriction();
		}
		public _UserData(string login, string ID, string passhash, bool blocked, bool allowPassRestrict)
		{
			_login = login;
			_ID = ID;
			_passhash = passhash;
			_blocked = blocked;
			_allowPassRestrict = allowPassRestrict;
			_passRestrict = new _passwordRestriction();
		}
		public _UserData(string login, string ID, string passhash, bool blocked, bool allowPassRestrict, int minLen, int  regex_num)
		{
			_login = login;
			_ID = ID;
			_passhash = passhash;
			_blocked = blocked;
			_allowPassRestrict = allowPassRestrict;
			_passRestrict = new _passwordRestriction(minLen, regex_num);
		}
		public _UserData(ref _UserData userData)
        {
			_login = userData._login;
			_ID = userData._ID;
			_passhash = userData._passhash;
			_blocked = userData._blocked;
			_allowPassRestrict = userData._allowPassRestrict;
			_passRestrict = new _passwordRestriction(ref userData._passRestrict);
		}
		public void writeUserData(_UserData userData)
        {
			_login = userData._login;
			_ID = userData._ID;
			_passhash = userData._passhash;
			_blocked = userData._blocked;
			_allowPassRestrict = userData._allowPassRestrict;
			_passRestrict = new _passwordRestriction(ref userData._passRestrict);
		}
		public bool compareCredentials(string login, string passhash)
        {
			return ((_login.Equals(login)) && (_passhash.Equals(passhash)));
		}


		public static string getHash(string plainString)
        {
			SHA256 digestSHA256 = SHA256.Create();
			byte[] byteOutput = digestSHA256.ComputeHash(Encoding.UTF8.GetBytes(plainString));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < byteOutput.Length; i++)
			{
				stringBuilder.Append(byteOutput[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}
	};
}






