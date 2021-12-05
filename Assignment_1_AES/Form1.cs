using Assignment_1_AES.Helper;
using Assignment_1_AES.Service;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1_AES
{
    public partial class Form1 : Form
    {
        private readonly IAESCryptography aesCryptography;
        private IAes _aes;
        private string plainTextFileContent;
        private KeySizeEnum keysize;
        private string aesKEY;

        public Form1()
        {
            InitializeComponent();
            aesCryptography = new AESCryptography();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rbCbc.Checked)
            {
                var plaintext = txtPlaintext.Text;
                var cipertext = aesCryptography.Encrypt(plaintext);
                rtbCipertext.Text = cipertext;
            }
            else
            {
                switch (cbAesBits.Text)
                {
                    case "Bits256":
                        {
                            keysize = KeySizeEnum.Bits256;
                            aesKEY = Constants.AesKey256;
                            break;
                        }
                    case "Bits192":
                        {
                            keysize = KeySizeEnum.Bits192;
                            aesKEY = Constants.AesKey192;
                            break;
                        }
                    case "Bits128":
                        {
                            keysize = KeySizeEnum.Bits128;
                            aesKEY = Constants.AesKey128;
                            break;
                        }
                    default:
                        {
                            keysize = KeySizeEnum.Bits128;
                            aesKEY = Constants.AesKey128;
                            break;
                        }
                }

                var objAes = new Aes(aesKEY, (int)keysize);
                rtbCipertext.Text = objAes.Encrypt(txtPlaintext.Text);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rbCbc.Checked)
            {
                var cipertext = rtbCipertext.Text;
                var plaintext = aesCryptography.Decrypt(cipertext);
                rtbPlainText.Text = plaintext;
            }
            else
            {
                switch (cbAesBits.Text)
                {
                    case "Bits256":
                        {
                            keysize = KeySizeEnum.Bits256;
                            aesKEY = Constants.AesKey256;
                            break;
                        }
                    case "Bits192":
                        {
                            keysize = KeySizeEnum.Bits192;
                            aesKEY = Constants.AesKey192;
                            break;
                        }
                    case "Bits128":
                        {
                            keysize = KeySizeEnum.Bits128;
                            aesKEY = Constants.AesKey128;
                            break;
                        }
                    default:
                        {
                            keysize = KeySizeEnum.Bits128;
                            aesKEY = Constants.AesKey128;
                            break;
                        }
                }

                var objAes = new Aes(aesKEY, (int)keysize);
                rtbPlainText.Text = objAes.Decrypt(rtbCipertext.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFileName.ReadOnly = true;
            btnUpload.Enabled = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                txtFileName.Text = Path.GetFileName(openFileDialog.FileName);
                plainTextFileContent = File.ReadAllText(openFileDialog.FileName);
                txtPlaintext.Text = plainTextFileContent;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtPlaintext.Text = "";
            if (rbEncFile.Checked)
            {
                txtPlaintext.ReadOnly = true;
                txtFileName.ReadOnly = false;
                btnUpload.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtPlaintext.Text = "";
            if (rbEncText.Checked)
            {
                txtPlaintext.ReadOnly = false;
                txtFileName.ReadOnly = true;
                btnUpload.Enabled = false;
            }
        }


        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void rbCtr_CheckedChanged(object sender, EventArgs e)
        {
            cbAesBits.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbCbc_Click(object sender, EventArgs e)
        {
            cbAesBits.Enabled = false;
            cbAesBits.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtPlaintext.Text = "";
            rtbPlainText.Text = "";
            rtbCipertext.Text = "";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
