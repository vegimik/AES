using System;
using System.IO;
using System.Security.Cryptography;

namespace Assignment_1_AES
{
    public class AES : IAES
    {

        static string aesKEY = "Vjhhvhkljlckjc87b4dgjufxFSDHjhtyf867vhjKL9k=";
        static string aesIV = "vkuyfgufyHF7fufERTihih==";

        public string Decrypt(string encryptedText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            string decyptedText = null;
            byte[] cipherBytes = Convert.FromBase64String(encryptedText);
            using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
            {
                aesCryptoServiceProvider.Key = Convert.FromBase64String(aesKEY);
                aesCryptoServiceProvider.IV = Convert.FromBase64String(aesIV);
                aesCryptoServiceProvider.Mode = cipherMode;
                aesCryptoServiceProvider.Padding = paddingMode;
                ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);

                using (MemoryStream ms = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            decyptedText = sr.ReadToEnd();
                        }
                    }
                }
            }
            return decyptedText;
        }

        public string Encrypt(string plainText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            byte[] encryptedBytes;
            using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
            {
                aesCryptoServiceProvider.Key = Convert.FromBase64String(aesKEY);
                aesCryptoServiceProvider.IV = Convert.FromBase64String(aesIV);
                aesCryptoServiceProvider.Mode = cipherMode;
                aesCryptoServiceProvider.Padding = paddingMode;

                ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        encryptedBytes = ms.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedBytes);
        }
    }
}
