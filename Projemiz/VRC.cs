using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projemiz
{
    public partial class VRC : Form
    {
        public VRC()
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Textbox'tan veriyi al
            string input = textBox1.Text;

            // Girilen veriyi kontrol et
            if (IsValidBinary(input))
            {
                // 1'leri say
                int oneCount = CountOnes(input);

                // Çift mi tek mi kontrol et
                int result = (oneCount % 2 == 0) ? 0 : 1;

                // Sonucu label'a yaz
                label6.Text = result.ToString();

                // Sonucu giriş verisi ile birleştirip diğer label'a yaz
                label7.Text = result.ToString() + input;
            }
            else
            {
                MessageBox.Show("Geçersiz binary girişi! Lütfen sadece 0 ve 1 içeren bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hata durumunda metodu burada sonlandır
            }
        }




        private void VRCcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private bool IsValidBinary(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }

        private int CountOnes(string binaryString)
        {
            return binaryString.Count(c => c == '1');
        }

        private string GenerateRandomBinary(int length)
        {
            Random random = new Random();
            return new string(Enumerable.Range(0, length).Select(_ => random.Next(2).ToString()[0]).ToArray());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // TextBox2'deki veriyi al
            string input2 = textBox2.Text;

            // Label7'den alınan veri ile TextBox2'deki verinin uzunluğunu karşılaştır
            if (!string.IsNullOrEmpty(input2) && input2.Length == label7.Text.Length)
            {
                // TextBox2'deki 1'leri say
                int generatedOneCount = CountOnes(input2);

                // Çift mi tek mi kontrol et
                label10.Text = (generatedOneCount % 2 == 0) ? "Hatasız" : "Hatalı";
            }
            else
            {
                MessageBox.Show("Üretilen sayı uzunluğu giriş verisi ile aynı değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}