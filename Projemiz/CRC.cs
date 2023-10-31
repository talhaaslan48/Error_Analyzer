using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projemiz
{
    public partial class CRC : Form
    {
        public CRC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnaSyf formAnaSyf = new FormAnaSyf();
            formAnaSyf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CRCcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Gelen karakterin '0' veya '1' olup olmadığını kontrol et
            if (e.KeyChar != '0' && e.KeyChar != '1')
            {
                // Eğer '0' veya '1' değilse, olayı engelle
                e.Handled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private bool IsCRCValid(string crc)
        {
            // CRC sonucunun tüm bitlerini kontrol et
            foreach (char bit in crc)
            {
                if (bit != '0')
                {
                    return false;
                }
            }
            return true;
        }
        private string CalculateCRC(string data, string divisor)
        {
            int dataLength = data.Length;
            int divisorLength = divisor.Length;

            // Data'yı uzat
            string extendedData = data.PadRight(dataLength + divisorLength - 1, '0');

            char[] dataArray = extendedData.ToCharArray();
            char[] divisorArray = divisor.ToCharArray();

            for (int i = 0; i < dataLength; i++)
            {
                if (dataArray[i] == '1')
                {
                    for (int j = 0; j < divisorLength; j++)
                    {
                        dataArray[i + j] = dataArray[i + j] == divisorArray[j] ? '0' : '1';
                    }
                }
            }

            // CRC bitlerini al
            string crcBits = new string(dataArray, dataLength, divisorLength - 1);

            return crcBits;

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string data = dividendTextBox.Text;
            string divisor = divisorTextBox.Text;

            // CRC işlemi
            string crcResult = CalculateCRC(data, divisor);

            // CRC bitlerini verinin sonuna ekle
            string dataWithCRC = data + crcResult;

            // Alıcı tarafından doğrulama
            string receivedData = dataWithCRC; // Alıcı veriyi aldıktan sonra

            string receivedCRCResult = CalculateCRC(receivedData, divisor);

            // Sonucu ekranda göster
            label6.Text = crcResult;
            label7.Text = dataWithCRC;

            if (IsCRCValid(receivedCRCResult))
            {
                label8.Text += "\nHata Kontrolü: Hatasız";
            }
            else
            {
                label8.Text += "\nHata Kontrolü: Hatalı";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // PDF dosyasının yolunu belirtin
            string pdfDosyaYolu = "C:\\Users\\talha\\Downloads\\9.10.2023 Siber - 1.pdf"; // Gerçek dosya yolunu belirtin

            // Dosyanın varlığını kontrol etmek isterseniz:
            if (File.Exists(pdfDosyaYolu))
            {
                // Dosyayı MemoryStream'e yükle
                byte[] pdfBytes = File.ReadAllBytes(pdfDosyaYolu);
                MemoryStream memoryStream = new MemoryStream(pdfBytes);

                // SaveFileDialog ile kullanıcıya nereye kaydetmek istediğini sorma
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
                saveFileDialog.FileName = "YeniDosyaAdi.pdf"; // İndirilen dosyanın adını belirleyin

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Dosyayı kullanıcının belirttiği yere kaydet
                    File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                    MessageBox.Show("PDF İndirme Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Belirtilen PDF dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormAnaSyf formAnaSyf = new FormAnaSyf();
            formAnaSyf.Show();
            this.Hide();
        }
    }
}