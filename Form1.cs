using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMD5Encrypt_Click(object sender, EventArgs e)
        {
            string hash = txtHash.Text;
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtValue.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void btnMD5Decrypt_Click(object sender, EventArgs e)
        {
            string hash = txtHash.Text;
            //Convert a string to byte array
            byte[] data = Convert.FromBase64String(txtEncrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Decrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtDecrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void btnSHAEncrypt_Click(object sender, EventArgs e)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(txtValue.Text));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            txtEncrypt.Text = sb.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/TAJassson",
                UseShellExecute = true
            });
        }

        private void btnSHA512Encrypt_Click(object sender, EventArgs e)
        {
            using var sha512 = SHA512.Create();
            byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(txtValue.Text));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            txtEncrypt.Text = sb.ToString();
        }
    }
    }
