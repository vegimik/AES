
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
            this.cbAesBits = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCbc = new System.Windows.Forms.RadioButton();
            this.rbCtr = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext";
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(193, 177);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlaintext.Size = new System.Drawing.Size(674, 112);
            this.txtPlaintext.TabIndex = 1;
            this.txtPlaintext.TextChanged += new System.EventHandler(this.txtPlaintext_TextChanged);
            // 
            // rtbCipertext
            // 
            this.rtbCipertext.Location = new System.Drawing.Point(27, 313);
            this.rtbCipertext.Name = "rtbCipertext";
            this.rtbCipertext.Size = new System.Drawing.Size(1197, 183);
            this.rtbCipertext.TabIndex = 2;
            this.rtbCipertext.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(897, 177);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 112);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1015, 177);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(89, 112);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rtbPlainText
            // 
            this.rtbPlainText.Location = new System.Drawing.Point(27, 536);
            this.rtbPlainText.Name = "rtbPlainText";
            this.rtbPlainText.ReadOnly = true;
            this.rtbPlainText.Size = new System.Drawing.Size(1197, 174);
            this.rtbPlainText.TabIndex = 5;
            this.rtbPlainText.Text = "";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(193, 114);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(674, 27);
            this.txtFileName.TabIndex = 6;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(897, 110);
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
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Name";
            // 
            // rbEncText
            // 
            this.rbEncText.AutoSize = true;
            this.rbEncText.Checked = true;
            this.rbEncText.Location = new System.Drawing.Point(166, 38);
            this.rbEncText.Name = "rbEncText";
            this.rbEncText.Size = new System.Drawing.Size(57, 24);
            this.rbEncText.TabIndex = 9;
            this.rbEncText.TabStop = true;
            this.rbEncText.Text = "Text";
            this.rbEncText.UseVisualStyleBackColor = true;
            this.rbEncText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbEncFile
            // 
            this.rbEncFile.AutoSize = true;
            this.rbEncFile.Location = new System.Drawing.Point(298, 38);
            this.rbEncFile.Name = "rbEncFile";
            this.rbEncFile.Size = new System.Drawing.Size(107, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(547, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt data by";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbAesBits
            // 
            this.cbAesBits.FormattingEnabled = true;
            this.cbAesBits.Items.AddRange(new object[] {
            "Bits128",
            "Bits192",
            "Bits256"});
            this.cbAesBits.SelectedIndex = 0;
            this.cbAesBits.Location = new System.Drawing.Point(30, 37);
            this.cbAesBits.Name = "cbAesBits";
            this.cbAesBits.Size = new System.Drawing.Size(151, 28);
            this.cbAesBits.TabIndex = 11;
            this.cbAesBits.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCbc);
            this.groupBox2.Controls.Add(this.rbCtr);
            this.groupBox2.Location = new System.Drawing.Point(27, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 92);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES Encryption Type:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbCbc
            // 
            this.rbCbc.AutoSize = true;
            this.rbCbc.Location = new System.Drawing.Point(20, 34);
            this.rbCbc.Name = "rbCbc";
            this.rbCbc.Size = new System.Drawing.Size(189, 24);
            this.rbCbc.TabIndex = 9;
            this.rbCbc.TabStop = true;
            this.rbCbc.Text = "CBC(Cryptograhphy, lib)";
            this.rbCbc.UseVisualStyleBackColor = true;
            this.rbCbc.Click += new System.EventHandler(this.rbCbc_Click);
            // 
            // rbCtr
            // 
            this.rbCtr.AutoSize = true;
            this.rbCtr.Checked = true;
            this.rbCtr.Location = new System.Drawing.Point(248, 34);
            this.rbCtr.Name = "rbCtr";
            this.rbCtr.Size = new System.Drawing.Size(196, 24);
            this.rbCtr.TabIndex = 10;
            this.rbCtr.TabStop = true;
            this.rbCtr.Text = "CTR(wih all process flow)";
            this.rbCtr.UseVisualStyleBackColor = true;
            this.rbCtr.CheckedChanged += new System.EventHandler(this.rbCtr_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAesBits);
            this.groupBox3.Location = new System.Drawing.Point(1029, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 92);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose AES_CTR_Bit";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 112);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1253, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.rtbPlainText);
            this.Controls.Add(this.rtbCipertext);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Advanced Encryption Standard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbAesBits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCbc;
        private System.Windows.Forms.RadioButton rbCtr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

