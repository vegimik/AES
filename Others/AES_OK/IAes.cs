namespace Assignment_1_AES.Service
{
    public interface IAes
    {
        string Encrypt(string plaintext);
        byte[] Encrypt(byte[] plaintext);
        string Decrypt(string ciphertext);
        byte[] Decrypt(byte[] ciphertext);
    }
}
