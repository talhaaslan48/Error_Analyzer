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
            StringBuilder rem = new StringBuilder();
            string msg = dividendTextBox.Text;
            string key = divisorTextBox.Text;
            int msg_len = msg.Length;
            int key_len = key.Length;

            // Append 0 at the end
            StringBuilder temp = new StringBuilder(msg);
            for (int i = 0; i < key_len - 1; i++)
            {
                temp.Append('0');
            }

            // XOR operation
            for (int j = 0; j <= msg_len - key_len; j++)
            {
                if (temp[j] != '0')
                {
                    for (int k = 0; k < key_len; k++)
                    {
                        rem.Append(temp[j + k] = (temp[j + k] == key[k]) ? '0' : '1');
                    }
                }
            }

            // Reduce remainder
            for (int k = 0; k < key_len; k++)
            {
                rem.Remove(0, 1);
            }

            // CRC bitini bölme işlemlerinden sonra kalan son 3 biti al
            string last3Bits = rem.ToString().Substring(rem.Length - 3);

            // Sonucu ekrana yazdır
            label6.Text = "Last 3 Bits: " + last3Bits;

            // CRC bitini dividend'in sonuna ekle
            string result = msg + last3Bits;

            // Hata kontrolü
            StringBuilder tempResult = new StringBuilder(result);
            temp.Clear();

            // XOR operation
            for (int j = 0; j <= msg_len - key_len; j++)
            {
                if (tempResult[j] != '0')
                {
                    for (int k = 0; k < key_len; k++)
                    {
                        temp.Append(tempResult[j + k] = (tempResult[j + k] == key[k]) ? '0' : '1');
                    }
                }
            }

            // Reduce remainder
            for (int k = 0; k < key_len; k++)
            {
                temp.Remove(0, 1);
            }

            // CRC kontrolü
            string crcCheck = temp.ToString().Substring(temp.Length - 3);

            if (crcCheck == "000")
            {
                label8.Text = "Status: Hatasız Gönderildi";
            }
            else
            {
                label8.Text = "Status: Hatalı Gönderildi";
            }

            // Tüm sonuçları göster
            label7.Text = "Data Transmitted: " + result;
        }
    }
}
