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

            //D4
            string textboxdeger = textBox11.Text;
            string textboxdeger1 = textBox10.Text;
            string textboxdeger2 = textBox9.Text;
            string textboxdeger3 = textBox8.Text;
            string textboxdeger4 = textBox7.Text;
            string textboxdeger5 = textBox6.Text;
            string textboxdeger6 = textBox5.Text;
            string textboxdeger7 = textBox16.Text;



            double sayi = double.Parse(textboxdeger);
            double sayi1 = double.Parse(textboxdeger1);
            double sayi2 = double.Parse(textboxdeger2);
            double sayi3 = double.Parse(textboxdeger3);
            double sayi4 = double.Parse(textboxdeger4);
            double sayi5 = double.Parse(textboxdeger5);
            double sayi6 = double.Parse(textboxdeger6);
            double sayi7 = double.Parse(textboxdeger7);




            double sonuc = sayi * Math.Pow(2, 0);
            double sonuc1 = sayi1 * Math.Pow(2, 1);
            double sonuc2 = sayi2 * Math.Pow(2, 2);
            double sonuc3 = sayi3 * Math.Pow(2, 3);
            double sonuc4 = sayi4 * Math.Pow(2, 4);
            double sonuc5 = sayi5 * Math.Pow(2, 5);
            double sonuc6 = sayi6 * Math.Pow(2, 6);
            double sonuc7 = sayi7 * Math.Pow(2, 7);


            double D4 = sonuc + sonuc1 + sonuc2 + sonuc3 + sonuc4 + sonuc5 + sonuc6 + sonuc7;


            // D3 

            string textboxdeger8 = textBox12.Text;
            string textboxdeger9 = textBox13.Text;
            string textboxdeger10 = textBox14.Text;
            string textboxdeger11 = textBox15.Text;
            string textboxdeger12 = textBox17.Text;
            string textboxdeger13 = textBox18.Text;
            string textboxdeger14 = textBox19.Text;
            string textboxdeger15 = textBox20.Text;



            double sayi8 = double.Parse(textboxdeger8);
            double sayi9 = double.Parse(textboxdeger9);
            double sayi10 = double.Parse(textboxdeger10);
            double sayi11 = double.Parse(textboxdeger11);
            double sayi12 = double.Parse(textboxdeger12);
            double sayi13 = double.Parse(textboxdeger13);
            double sayi14 = double.Parse(textboxdeger14);
            double sayi15 = double.Parse(textboxdeger15);




            double sonuc8 = sayi8 * Math.Pow(2, 0);
            double sonuc9 = sayi9 * Math.Pow(2, 1);
            double sonuc10 = sayi10 * Math.Pow(2, 2);
            double sonuc11 = sayi11 * Math.Pow(2, 3);
            double sonuc12 = sayi12 * Math.Pow(2, 4);
            double sonuc13 = sayi13 * Math.Pow(2, 5);
            double sonuc14 = sayi14 * Math.Pow(2, 6);
            double sonuc15 = sayi15 * Math.Pow(2, 7);


            double D3 = sonuc8 + sonuc9 + sonuc10 + sonuc11 + sonuc12 + sonuc13 + sonuc14 + sonuc15;

            //D2

            string textboxdeger16 = textBox21.Text;
            string textboxdeger17 = textBox22.Text;
            string textboxdeger18 = textBox23.Text;
            string textboxdeger19 = textBox24.Text;
            string textboxdeger20 = textBox25.Text;
            string textboxdeger21 = textBox26.Text;
            string textboxdeger22 = textBox27.Text;
            string textboxdeger23 = textBox28.Text;



            double sayi16 = double.Parse(textboxdeger16);
            double sayi17 = double.Parse(textboxdeger17);
            double sayi18 = double.Parse(textboxdeger18);
            double sayi19 = double.Parse(textboxdeger19);
            double sayi20 = double.Parse(textboxdeger20);
            double sayi21 = double.Parse(textboxdeger21);
            double sayi22 = double.Parse(textboxdeger22);
            double sayi23 = double.Parse(textboxdeger23);




            double sonuc16 = sayi16 * Math.Pow(2, 0);
            double sonuc17 = sayi17 * Math.Pow(2, 1);
            double sonuc18 = sayi18 * Math.Pow(2, 2);
            double sonuc19 = sayi19 * Math.Pow(2, 3);
            double sonuc20 = sayi20 * Math.Pow(2, 4);
            double sonuc21 = sayi21 * Math.Pow(2, 5);
            double sonuc22 = sayi22 * Math.Pow(2, 6);
            double sonuc23 = sayi23 * Math.Pow(2, 7);


            double D2 = sonuc16 + sonuc17 + sonuc18 + sonuc19 + sonuc20 + sonuc21 + sonuc22 + sonuc23;


            //D1

            string textboxdeger32 = textBox29.Text;
            string textboxdeger33 = textBox30.Text;
            string textboxdeger34 = textBox31.Text;
            string textboxdeger35 = textBox32.Text;
            string textboxdeger36 = textBox33.Text;
            string textboxdeger37 = textBox34.Text;
            string textboxdeger38 = textBox35.Text;
            string textboxdeger39 = textBox36.Text;



            double sayi24 = double.Parse(textboxdeger32);
            double sayi25 = double.Parse(textboxdeger33);
            double sayi26 = double.Parse(textboxdeger34);
            double sayi27 = double.Parse(textboxdeger35);
            double sayi28 = double.Parse(textboxdeger36);
            double sayi29 = double.Parse(textboxdeger37);
            double sayi30 = double.Parse(textboxdeger38);
            double sayi31 = double.Parse(textboxdeger39);




            double sonuc24 = sayi24 * Math.Pow(2, 0);
            double sonuc25 = sayi25 * Math.Pow(2, 1);
            double sonuc26 = sayi26 * Math.Pow(2, 2);
            double sonuc27 = sayi27 * Math.Pow(2, 3);
            double sonuc28 = sayi28 * Math.Pow(2, 4);
            double sonuc29 = sayi29 * Math.Pow(2, 5);
            double sonuc30 = sayi30 * Math.Pow(2, 6);
            double sonuc31 = sayi31 * Math.Pow(2, 7);


            double D1 = sonuc24 + sonuc25 + sonuc26 + sonuc27 + sonuc28 + sonuc29 + sonuc30 + sonuc31;

            double Toplam = D1 + D2 + D3 + D4;

            // Sabit bir decimal sayı kullan
            int decimalSayi = (int)Toplam; // Örneğin, 42 kullanıldı

            // Decimal sayıyı binary stringe çevir
            string binaryStr = Convert.ToString(decimalSayi, 2).PadLeft(10, '0');

            char[] binaryChars = binaryStr.ToCharArray();
            Array.Reverse(binaryChars);
            binaryStr = new string(binaryChars);

            // Her bir basamağı ayrı TextBox'a at
            for (int i = 0; i < binaryStr.Length; i++)
            {
                char basamak = binaryStr[i];                // TextBox'ın adını oluştur
                string textBoxName = $"textBox{37 + i}";

                // Eğer 9. veya 10. basamağa gelindiyse ismi düzelt
                if (i >= 8)
                {
                    textBoxName = $"textBox{101 + i - 8}";
                }

                // TextBox'ı bul
                TextBox textBox = (TextBox)Controls.Find(textBoxName, true)[0];

                // Basamağı TextBox'a ata
                textBox.Text = basamak.ToString();
            }

            textBox104.Text = textBox101.Text;
            textBox103.Text = textBox102.Text;
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

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


