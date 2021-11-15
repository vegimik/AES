using System;
using System.Windows.Forms;

namespace Assignment_1_AES
{
    public partial class Form1 : Form
    {
        private readonly IAES _aes;

        public Form1()
        {
            InitializeComponent();
            _aes = new AES();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var plaintext = txtPlaintext.Text;
            var cipertext = _aes.Encrypt(plaintext);
            rtbCipertext.Text = cipertext;
            txtPlaintext.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var cipertext = rtbCipertext.Text;
            var plaintext = _aes.Decrypt(cipertext);
            txtPlaintext.Text = plaintext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
