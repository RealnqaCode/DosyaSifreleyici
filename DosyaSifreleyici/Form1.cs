using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace DosyaSifreleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Şifrelenecek veya çözülecek dosyayı seç",
                Filter = "Tüm Dosyalar (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text;
            string pass = txtPassword.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("Dosya bulunamadı!");
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Lütfen bir şifre girin.");
                return;
            }

            byte[] fileBytes = File.ReadAllBytes(path);
            circleProgress.Value = 20;

            byte[] encrypted = CryptoHelper.Encrypt(fileBytes, pass);
            circleProgress.Value = 60;

            string newPath = path + ".enc";
            File.WriteAllBytes(newPath, encrypted);
            circleProgress.Value = 100;

            
            File.Delete(path);

            circleProgress.Text = "100";
            MessageBox.Show("Dosya başarıyla şifrelendi\n" + newPath);
        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string path = txtFilePath.Text;
            string pass = txtPassword.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("Dosya bulunamadı!");
                return;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Lütfen bir şifre girin.");
                return;
            }

            try
            {
                byte[] fileBytes = File.ReadAllBytes(path);
                circleProgress.Value = 20;

                byte[] decrypted = CryptoHelper.Decrypt(fileBytes, pass);
                circleProgress.Value = 60;

                string originalExtension = Path.GetExtension(Path.GetFileNameWithoutExtension(path)); 
                string baseName = Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(path)); 
                string newPath = Path.Combine(Path.GetDirectoryName(path), baseName + originalExtension);

                File.WriteAllBytes(newPath, decrypted);
                circleProgress.Value = 100;

                
                File.Delete(path);

                circleProgress.Text = "100";
                MessageBox.Show("Dosya başarıyla çözüldü ve şifreli dosya silindi:\n" + newPath);
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("❌ Şifre hatalı ya da dosya bozuk. Lütfen doğru şifreyi girin.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                circleProgress.Value = 0;
                circleProgress.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                circleProgress.Value = 0;
                circleProgress.Text = "0";
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string filePath = files[0];
                txtFilePath.Text = filePath;
                MessageBox.Show("Dosya yüklendi:\n" + filePath, "Sürükle-Bırak", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

