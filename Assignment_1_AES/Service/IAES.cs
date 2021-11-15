﻿using System.Security.Cryptography;

namespace Assignment_1_AES
{
    public interface IAES
    {
        static string aesKEY = "Vjhhvhkljlckjc87b4dgjufxFSDHjhtyf867vhjKL9k=";
        static string aesIV = "vkuyfgufyHF7fufERTihih==";

        string Decrypt(string encryptedText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7);

        string Encrypt(string plainText, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7);
    }
}