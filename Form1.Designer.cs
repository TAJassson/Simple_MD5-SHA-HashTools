namespace WinFormsApp3
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
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnMD5Encrypt = new System.Windows.Forms.Button();
            this.btnMD5Decrypt = new System.Windows.Forms.Button();
            this.btnSHAEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.txtDecrypt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSHA512Encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(87, 82);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(701, 23);
            this.txtHash.TabIndex = 1;
            // 
            // btnMD5Encrypt
            // 
            this.btnMD5Encrypt.Location = new System.Drawing.Point(87, 273);
            this.btnMD5Encrypt.Name = "btnMD5Encrypt";
            this.btnMD5Encrypt.Size = new System.Drawing.Size(87, 38);
            this.btnMD5Encrypt.TabIndex = 4;
            this.btnMD5Encrypt.Text = "MD5加密";
            this.btnMD5Encrypt.UseVisualStyleBackColor = true;
            this.btnMD5Encrypt.Click += new System.EventHandler(this.btnMD5Encrypt_Click);
            // 
            // btnMD5Decrypt
            // 
            this.btnMD5Decrypt.Location = new System.Drawing.Point(217, 273);
            this.btnMD5Decrypt.Name = "btnMD5Decrypt";
            this.btnMD5Decrypt.Size = new System.Drawing.Size(87, 38);
            this.btnMD5Decrypt.TabIndex = 5;
            this.btnMD5Decrypt.Text = "MD5解密";
            this.btnMD5Decrypt.UseVisualStyleBackColor = true;
            this.btnMD5Decrypt.Click += new System.EventHandler(this.btnMD5Decrypt_Click);
            // 
            // btnSHAEncrypt
            // 
            this.btnSHAEncrypt.Location = new System.Drawing.Point(564, 273);
            this.btnSHAEncrypt.Name = "btnSHAEncrypt";
            this.btnSHAEncrypt.Size = new System.Drawing.Size(87, 38);
            this.btnSHAEncrypt.TabIndex = 6;
            this.btnSHAEncrypt.Text = "SHA256加密";
            this.btnSHAEncrypt.UseVisualStyleBackColor = true;
            this.btnSHAEncrypt.Click += new System.EventHandler(this.btnSHAEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "加密";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "解密";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(87, 5);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(701, 71);
            this.txtValue.TabIndex = 11;
            this.txtValue.Text = "";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(87, 111);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(701, 69);
            this.txtEncrypt.TabIndex = 12;
            this.txtEncrypt.Text = "";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(87, 186);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(701, 81);
            this.txtDecrypt.TabIndex = 13;
            this.txtDecrypt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Developer: TAJassson \\ NeverLess DevOPS and IOT Team";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSHA512Encrypt
            // 
            this.btnSHA512Encrypt.Location = new System.Drawing.Point(685, 273);
            this.btnSHA512Encrypt.Name = "btnSHA512Encrypt";
            this.btnSHA512Encrypt.Size = new System.Drawing.Size(87, 38);
            this.btnSHA512Encrypt.TabIndex = 15;
            this.btnSHA512Encrypt.Text = "SHA512加密";
            this.btnSHA512Encrypt.UseVisualStyleBackColor = true;
            this.btnSHA512Encrypt.Click += new System.EventHandler(this.btnSHA512Encrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.btnSHA512Encrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSHAEncrypt);
            this.Controls.Add(this.btnMD5Decrypt);
            this.Controls.Add(this.btnMD5Encrypt);
            this.Controls.Add(this.txtHash);
            this.Name = "Form1";
            this.Text = "Simple MD5 / SHA Hash tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnMD5Encrypt;
        private System.Windows.Forms.Button btnMD5Decrypt;
        private System.Windows.Forms.Button btnSHAEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtValue;
        private System.Windows.Forms.RichTextBox txtEncrypt;
        private System.Windows.Forms.RichTextBox txtDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSHA512Encrypt;
    }
}
