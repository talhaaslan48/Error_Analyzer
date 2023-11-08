using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projemiz
{
    public partial class FEC : Form
    {
        private string veri1;
        private string veri2;
        public FEC()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            FormAnaSyf formAnaSyf = new FormAnaSyf();
            formAnaSyf.Show();
            this.Hide();
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
            label20.Text = textBox1.Text;
            // 1. ve 2. TextBox'tan verileri alın
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // Verileri 2'li gruplara bölmek için uygun uzunluğa getirin
            int maxLength = Math.Max(input1.Length, input2.Length);
            input1 = input1.PadLeft(maxLength, '0');
            input2 = input2.PadLeft(maxLength, '0');

            int totalErrors = 0;

            // Her 2'li grup için işlem yapın
            for (int i = 0; i < maxLength; i += 2)
            {
                string group1 = input1.Substring(i, 2);
                string group2 = input2.Substring(i, 2);

                // 2'li grupların karşılıklarını hesaplayın
                string xorResult = XOR(group1, group2);

                // XOR sonucundaki 1'leri sayın
                int errorCount = xorResult.Count(c => c == '1');

                if (errorCount > 0)
                {
                    // Hata varsa
                    listBox1.Items.Add($"Hatalı: {group1} XOR {group2} = {xorResult}");
                    totalErrors += errorCount;
                }
                else
                {
                    // Hata yoksa
                    listBox1.Items.Add($"Hatasız: {group1} XOR {group2} = {xorResult}");
                }
            }

            // Toplam hatalı sayısını görüntüleyin
            label3.Text = $"Toplam Hatalı: {totalErrors}";
        }

        // XOR işlemi için yardımcı fonksiyon
        private string XOR(string a, string b)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    result += "0";
                }
                else
                {
                    result += "1";
                }
            }
            return result;
        }



    }
}





