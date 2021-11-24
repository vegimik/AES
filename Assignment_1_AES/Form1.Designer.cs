
namespace Assignment_1_AES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.rtbCipertext = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.rtbPlainText = new System.Windows.Forms.RichTextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEncText = new System.Windows.Forms.RadioButton();
            this.rbEncFile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(260, 170);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlaintext.Size = new System.Drawing.Size(850, 116);
            this.txtPlaintext.TabIndex = 1;
            // 
            // rtbCipertext
            // 
            this.rtbCipertext.Location = new System.Drawing.Point(27, 313);
            this.rtbCipertext.Name = "rtbCipertext";
            this.rtbCipertext.Size = new System.Drawing.Size(1436, 183);
            this.rtbCipertext.TabIndex = 2;
            this.rtbCipertext.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1139, 170);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(148, 116);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1318, 170);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(148, 116);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rtbPlainText
            // 
            this.rtbPlainText.Location = new System.Drawing.Point(27, 568);
            this.rtbPlainText.Name = "rtbPlainText";
            this.rtbPlainText.ReadOnly = true;
            this.rtbPlainText.Size = new System.Drawing.Size(1436, 183);
            this.rtbPlainText.TabIndex = 5;
            this.rtbPlainText.Text = "";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(260, 110);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(850, 39);
            this.txtFileName.TabIndex = 6;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(1139, 110);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(327, 39);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Name";
            // 
            // rbEncText
            // 
            this.rbEncText.AutoSize = true;
            this.rbEncText.Checked = true;
            this.rbEncText.Location = new System.Drawing.Point(166, 38);
            this.rbEncText.Name = "rbEncText";
            this.rbEncText.Size = new System.Drawing.Size(88, 36);
            this.rbEncText.TabIndex = 9;
            this.rbEncText.TabStop = true;
            this.rbEncText.Text = "Text";
            this.rbEncText.UseVisualStyleBackColor = true;
            this.rbEncText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEncFile
            // 
            this.rbEncFile.AutoSize = true;
            this.rbEncFile.Location = new System.Drawing.Point(408, 38);
            this.rbEncFile.Name = "rbEncFile";
            this.rbEncFile.Size = new System.Drawing.Size(171, 36);
            this.rbEncFile.TabIndex = 10;
            this.rbEncFile.TabStop = true;
            this.rbEncFile.Text = "File content";
            this.rbEncFile.UseVisualStyleBackColor = true;
            this.rbEncFile.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEncText);
            this.groupBox1.Controls.Add(this.rbEncFile);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt data by";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1498, 828);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.rtbPlainText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbCipertext);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Advanced Encryption Standard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.RichTextBox rtbCipertext;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox rtbPlainText;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEncText;
        private System.Windows.Forms.RadioButton rbEncFile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

