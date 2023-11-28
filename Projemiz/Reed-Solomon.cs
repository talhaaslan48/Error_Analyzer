using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Projemiz
{
    public partial class Reed_Solomon : Form
    {

        private List<List<TextBox>> inputGroups; // Her bir basamak için TextBox gruplarını tutacak liste

        public Reed_Solomon()
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


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TextBox'a girilen metni kontrol et
            string input = textBox1.Text;

            // Girilen metnin uzunluğunu kontrol et
            if (input.Length == 8)
            {
                // Her bir basamağı ayrı TextBox'lara yazdır
                textBox36.Text = input[0].ToString();
                textBox35.Text = input[1].ToString();
                textBox34.Text = input[2].ToString();
                textBox33.Text = input[3].ToString();
                textBox32.Text = input[4].ToString();
                textBox31.Text = input[5].ToString();
                textBox30.Text = input[6].ToString();
                textBox29.Text = input[7].ToString();
            }
            else
            {
                // Eğer 8 hane girilmediyse, diğer TextBox'ları temizle
                textBox36.Text = "";
                textBox35.Text = "";
                textBox34.Text = "";
                textBox33.Text = "";
                textBox32.Text = "";
                textBox31.Text = "";
                textBox30.Text = "";
                textBox29.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TextBox'a girilen metni kontrol et
            string input = textBox2.Text;

            // Girilen metnin uzunluğunu kontrol et
            if (input.Length == 8)
            {
                // Her bir basamağı ayrı TextBox'lara yazdır
                textBox28.Text = input[0].ToString();
                textBox27.Text = input[1].ToString();
                textBox26.Text = input[2].ToString();
                textBox25.Text = input[3].ToString();
                textBox24.Text = input[4].ToString();
                textBox23.Text = input[5].ToString();
                textBox22.Text = input[6].ToString();
                textBox21.Text = input[7].ToString();
            }
            else
            {
                // Eğer 8 hane girilmediyse, diğer TextBox'ları temizle
                textBox28.Text = "";
                textBox27.Text = "";
                textBox26.Text = "";
                textBox25.Text = "";
                textBox24.Text = "";
                textBox23.Text = "";
                textBox22.Text = "";
                textBox21.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // TextBox'a girilen metni kontrol et
            string input = textBox3.Text;

            // Girilen metnin uzunluğunu kontrol et
            if (input.Length == 8)
            {
                // Her bir basamağı ayrı TextBox'lara yazdır
                textBox20.Text = input[0].ToString();
                textBox19.Text = input[1].ToString();
                textBox18.Text = input[2].ToString();
                textBox17.Text = input[3].ToString();
                textBox15.Text = input[4].ToString();
                textBox14.Text = input[5].ToString();
                textBox13.Text = input[6].ToString();
                textBox12.Text = input[7].ToString();
            }
            else
            {
                // Eğer 8 hane girilmediyse, diğer TextBox'ları temizle
                textBox20.Text = "";
                textBox19.Text = "";
                textBox18.Text = "";
                textBox17.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox13.Text = "";
                textBox12.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            // TextBox'a girilen metni kontrol et
            string input = textBox4.Text;

            // Girilen metnin uzunluğunu kontrol et
            if (input.Length == 8)
            {
                // Her bir basamağı ayrı TextBox'lara yazdır
                textBox16.Text = input[0].ToString();
                textBox5.Text = input[1].ToString();
                textBox6.Text = input[2].ToString();
                textBox7.Text = input[3].ToString();
                textBox8.Text = input[4].ToString();
                textBox9.Text = input[5].ToString();
                textBox10.Text = input[6].ToString();
                textBox11.Text = input[7].ToString();
            }
            else
            {
                // Eğer 8 hane girilmediyse, diğer TextBox'ları temizle
                textBox16.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox60.Text = textBox16.Text;
            textBox59.Text = textBox5.Text;
            textBox58.Text = textBox6.Text;
            textBox57.Text = textBox7.Text;
            textBox56.Text = textBox8.Text;
            textBox55.Text = textBox9.Text;
            textBox54.Text = textBox10.Text;
            textBox53.Text = textBox11.Text;

            textBox100.Text = textBox20.Text;
            textBox99.Text = textBox19.Text;
            textBox98.Text = textBox18.Text;
            textBox97.Text = textBox17.Text;
            textBox96.Text = textBox15.Text;
            textBox95.Text = textBox14.Text;
            textBox94.Text = textBox13.Text;
            textBox93.Text = textBox12.Text;

            textBox92.Text = textBox28.Text;
            textBox91.Text = textBox27.Text;
            textBox90.Text = textBox26.Text;
            textBox89.Text = textBox25.Text;
            textBox88.Text = textBox24.Text;
            textBox87.Text = textBox23.Text;
            textBox86.Text = textBox22.Text;
            textBox85.Text = textBox21.Text;

            textBox84.Text = textBox36.Text;
            textBox83.Text = textBox35.Text;
            textBox82.Text = textBox34.Text;
            textBox81.Text = textBox33.Text;
            textBox80.Text = textBox32.Text;
            textBox79.Text = textBox31.Text;
            textBox78.Text = textBox30.Text;
            textBox77.Text = textBox29.Text;

        }
    }
}


