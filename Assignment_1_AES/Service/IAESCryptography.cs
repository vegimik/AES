using System.Security.Cryptography;

namespace Assignment_1_AES
{
    public interface IAESCryptography
    {
        static string aesKEY = "Vjhhvhkljlckjc87b4dgjufxFSDHjhtyf867vhjKL9k=";
        static string aesIV = "vkuyfgufyHF7fufERTihih==";

        string Encrypt(string plainText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7);
        string Decrypt(string encryptedText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7);
    }
}