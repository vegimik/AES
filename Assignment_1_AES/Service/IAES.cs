namespace Assignment_1_AES
{
    public interface IAES
    {
        static string aes_key = "Vjhhvhkljlckjc87b4dgjufxFSDHjhtyf867vhjKL9k=";
        static string aes_iv = "vkuyfgufyHF7fufERTihih==";

        string DecryptAES(string encryptedText);

        string EncryptAES(string plainText);
    }
}