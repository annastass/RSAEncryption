using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace RSAEncryption
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateKeysButton_Click(object sender, EventArgs e)
        {
            //генерация открытого и закрытого ключей
            rsa = new RSACryptoServiceProvider();
            publicKeyTextBox.Text = rsa.ToXmlString(false);
            privateKeyTextBox.Text = rsa.ToXmlString(true);
        }

        private void exportPublicKeyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(publicKeyTextBox.Text);
                }
            }
        }

        private void exportPrivateKeyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(privateKeyTextBox.Text);
                }
            }
        } 

        private void importPrivateKeyButton_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string xml = reader.ReadToEnd();
                    rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(xml);
                    privateKeyTextBox.Text = rsa.ToXmlString(true);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //проверка, выбрал ли пользователь файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFileDialog.FileName;
                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + "_encrypted" + Path.GetExtension(inputFile));

                using (FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    {
                        int bufferSize = (int)Math.Ceiling(rsa.KeySize / 8.0) - 11; //вычисление размера буфера для зашифрованных данных
                        byte[] buffer = new byte[bufferSize];
                        int bytesRead;
                        while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            byte[] encryptedData = rsa.Encrypt(buffer, false);
                            outputStream.Write(encryptedData, 0, encryptedData.Length);
                        }
                        Application.DoEvents(); //исправяет зависание
                    }
                }

                MessageBox.Show("Шифрование завершено");
            }
        }


        private void decryptButton_Click(object sender, EventArgs e)
        {
            //дешифрование файла данных с помощью закрытого ключа
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFileDialog.FileName;
                string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), Path.GetFileNameWithoutExtension(inputFile) + "_decrypted" + Path.GetExtension(inputFile));
                
                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                {
                    byte[] buffer = new byte[rsa.KeySize / 8];
                    int bytesRead;
                    while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        byte[] decryptedBuffer = rsa.Decrypt(buffer, false);
                        fsOutput.Write(decryptedBuffer, 0, decryptedBuffer.Length);
                    }

                    Application.DoEvents(); //исправяет зависание
                }
                MessageBox.Show("Файл успешно дешифрован.");
            }
       }
    }
}


