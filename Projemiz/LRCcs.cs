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
    public partial class LRCcs : Form
    {
        public LRCcs()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label a = new Label();
                    a.Text = textBox1.Text.ToString()[i].ToString();
                    tableLayoutPanel1.Controls.Add(a, i, 0);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)

        {
            if (textBox2.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label a = new Label();
                    a.Text = textBox2.Text.ToString()[i].ToString();
                    tableLayoutPanel1.Controls.Add(a, i, 1);
                }
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label a = new Label();
                    a.Text = textBox3.Text.ToString()[i].ToString();
                    tableLayoutPanel1.Controls.Add(a, i, 2);
                }
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label a = new Label();
                    a.Text = textBox4.Text.ToString()[i].ToString();
                    tableLayoutPanel1.Controls.Add(a, i, 3);
                }
            }

        }
        private void LRCcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Gelen karakterin '0' veya '1' olup olmadığını kontrol et
            if (e.KeyChar != '0' && e.KeyChar != '1')
            {
                // Eğer '0' veya '1' değilse, olayı engelle
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnaSyf formAnaSyf = new FormAnaSyf();
            formAnaSyf.Show();
            this.Hide();

        }
        List<string> list = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            bool test = false;
            try
            {

                // TextBox'taki metni al
                string girilenMetin = textBox1.Text;
                string girilenMetin1 = textBox2.Text;
                string girilenMetin2 = textBox3.Text;
                string girilenMetin3 = textBox4.Text;

                // Metnin uzunluğunu kontrol et
                if (!(girilenMetin.Length == 8 && girilenMetin1.Length == 8 && girilenMetin2.Length == 8 && girilenMetin3.Length == 8))
                {

                    throw new Exception();
                }
                test = true;

            }
            catch
            {
                // Uzunluk 8 değilse mesaj ver

                MessageBox.Show("Lütfen her kutucağa 8 karakter uzunluğunda bir sayı girin.");
            }
            if (test)
            {

                // TableLayoutPanel'deki satırları dolaş
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    int birSayisi = 0;
                    for (int satir = 0; satir < tableLayoutPanel1.RowCount; satir++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(col, satir);

                        if (control is Label label)
                        {
                            if (label.Text == "1")
                            {
                                birSayisi++;
                            }
                        }


                        // 1'lerin sayısına göre sonuç belirle ve TableLayoutPanel'e ekle

                    }
                    string sonuc = (birSayisi % 2 == 0) ? "0" : "1";
                    Label sonucLabel = new Label();
                    sonucLabel.Text = sonuc;
                    list.Add(sonuc);
                    tableLayoutPanel1.Controls.Add(sonucLabel, col, 4);
                }
                string lrcres = "";
                for (int i = 0; i < list.Count; i++)
                {
                    lrcres += list[i].ToString();

                }
                lrcres = lrcres + "-" + textBox4.Text;
                lrcres = lrcres + "-" + textBox3.Text;
                lrcres = lrcres + "-" + textBox2.Text;
                lrcres = lrcres + "-" + textBox1.Text;
                label5.Text = lrcres;


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

