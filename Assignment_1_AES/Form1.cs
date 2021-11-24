using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment_1_AES
{
    public partial class Form1 : Form
    {
        private readonly IAES _aes;
        private string plainTextFileContent;

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
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var cipertext = rtbCipertext.Text;
            var plaintext = _aes.Decrypt(cipertext);
            rtbPlainText.Text = plaintext;
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
    }
}
