using System;
using System.Text;
using System.Security.Cryptography;
using Mono.Security;
using System.IO;


namespace CyberSysTech_Lab1
{
    class CryptoAPI_class
    {
        protected AesCryptoServiceProvider aes;
        private static string encryptionKey;
        private static string initialisationVector = "26744a68b53dd87bb395584c00f7290a";
        protected static CryptoAPI_class _instance = null;
        public static CryptoAPI_class Instance()
        {
            if (_instance != null) return _instance;
            return _instance = new CryptoAPI_class();
        }
        public CryptoAPI_class()
        {
        }

        static string GetMd2Hash(Mono.Security.Cryptography.MD2 md2Hash, string input) //Encryption/Decryption keys are MD2 hashes of user key values
        {
                byte[] data = md2Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
        }
        public string EncryptText(string plainText)
        {
            using (aes = new AesCryptoServiceProvider())
            {
                aes.Key = HexStringToByte(encryptionKey);
                aes.IV = HexStringToByte(initialisationVector);
                aes.Mode = CipherMode.CFB; //CFB encryption mode
                aes.Padding = PaddingMode.PKCS7;
                byte[] encrypted = EncryptStringToBytes_Aes(plainText, aes.Key, aes.IV);
                string encString = Convert.ToBase64String(encrypted);
                return encString;
            }
        }
        public string DecryptText(string encryptedString)
        {
            using (aes = new AesCryptoServiceProvider())
            {
                aes.Key = HexStringToByte(encryptionKey);
                aes.IV = HexStringToByte(initialisationVector);
                aes.Mode = CipherMode.CFB; // CFB decryption mode
                aes.Padding = PaddingMode.PKCS7;
                Byte[] ourEnc = Convert.FromBase64String(encryptedString);
                string ourDec = DecryptStringFromBytes_Aes(ourEnc, aes.Key, aes.IV);
                return ourDec;
            }
        }
        protected static byte[] HexStringToByte(string hexString)
        {
            try
            {
                int bytesCount = (hexString.Length) / 2;
                byte[] bytes = new byte[bytesCount];
                for (int x = 0; x < bytesCount; ++x)
                {
                    bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
                }
                return bytes;
            }
            catch
            {
                throw;
            }
        }
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public string go_encryption(string text, string key1)
        {
            CryptoAPI_class crypto = CryptoAPI_class.Instance();
            string inputText = text;
            string key = key1;
            using (Mono.Security.Cryptography.MD2 md2Hash = Mono.Security.Cryptography.MD2Managed.Create())
            {
                encryptionKey = GetMd2Hash(md2Hash, key);
            }
            string encryptedText = crypto.EncryptText(inputText);
            return encryptedText;
        }
        public string go_decryption(string text, string key1)
        {
            CryptoAPI_class crypto = CryptoAPI_class.Instance();
            string inputText = text;
            string key = key1;
            using (Mono.Security.Cryptography.MD2 md2Hash = Mono.Security.Cryptography.MD2Managed.Create())
            {
                encryptionKey = GetMd2Hash(md2Hash, key);
            }
            string decryptedText = crypto.DecryptText(inputText);
            return decryptedText;
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;
            try
            {
                // Create an Aes object
                // with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {

                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                plaintext = srDecrypt.ReadToEnd();

                            }
                        }
                    }
                }
            }
            catch (CryptographicException)
            {
                return null;
            }

            return plaintext;
        }
    }
}
