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

        private void AddLabelsToTableLayoutPanel(TextBox textBox, int rowIndex)
        {
            if (textBox.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label label = new Label();
                    label.Text = textBox.Text[i].ToString();
                    label.ForeColor = Color.Black;
                    label.Font = new Font(label.Font.FontFamily, 12);
                    tableLayoutPanel1.Controls.Add(label, columnIndex, i);
                }

                columnIndex++; // Bir sonraki sütun için columnIndex'ı artır
                buttonYenile.Enabled = true;
            }
        }

        // ColumnCount'u 5 olarak güncelle
        private void fillTable()
        {
            if (
        (textBox1.Text.Length == 8 || textBox1.Text.Length == 0) &&
        (textBox2.Text.Length == 8 || textBox2.Text.Length == 0) &&
        (textBox3.Text.Length == 8 || textBox3.Text.Length == 0) &&
        (textBox4.Text.Length == 8 || textBox4.Text.Length == 0)
    )
            {
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.Controls.Clear();
                columnIndex = 0; // columnIndex'ı sıfırla
                AddLabelsToTableLayoutPanel(textBox1, 0);
                AddLabelsToTableLayoutPanel(textBox2, 1);
                AddLabelsToTableLayoutPanel(textBox3, 2);
                AddLabelsToTableLayoutPanel(textBox4, 3);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            fillTable();
        }

        private void VRCcs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FormAnaSayfa formAnaSyf = new FormAnaSayfa();
            formAnaSyf.Show();
            this.Hide();
        }


        List<string> list = new List<string>();
        private int columnIndex;

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            bool test = false;

            try
            {
                string[] girilenMetinler = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };

                foreach (string girilenMetin in girilenMetinler)
                {
                    if (girilenMetin.Length != 8)
                    {
                        MessageBox.Show("Lütfen her kutucağa 8 karakter uzunluğunda bir sayı girin.");
                        return;
                    }
                }

                test = true;
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu. Lütfen geçerli bir giriş yapın.");
                return;
            }

            if (test)
            {
               

                tableLayoutPanel1.RowCount = 8; // Sabit satır sayısı
                tableLayoutPanel1.ColumnCount = 5; // Sabit sütun sayısı

                // Hücreleri temizle
                tableLayoutPanel1.Controls.Clear();

                for (int i = 0; i < 4; i++)
                {
                    AddLabelsToTableLayoutPanel(textBox1, i);
                    AddLabelsToTableLayoutPanel(textBox2, i);
                    AddLabelsToTableLayoutPanel(textBox3, i);
                    AddLabelsToTableLayoutPanel(textBox4, i);
                }

                for (int col = 0; col < 8; col++)
                {
                    int birSayisi = 0;

                    for (int satir = 0; satir < 8; satir++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(col, satir);

                        if (control is Label label)
                        {
                            if (label.Text == "1")
                            {
                                birSayisi++;
                            }
                        }
                    }

                    string sonuc = (birSayisi % 2 == 0) ? "0" : "1";
                    Label sonucLabel = new Label();
                    sonucLabel.Text = sonuc;
                    sonucLabel.ForeColor = Color.Black;
                    sonucLabel.Font = new Font(sonucLabel.Font.FontFamily, 12);
                    list.Add(sonuc);
                    tableLayoutPanel1.Controls.Add(sonucLabel, col, 8);
                }

                // Paneli boyutlandırma


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

        private void buttonYenile_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label5.Text = "";

            tableLayoutPanel1.Controls.Clear();
        }
    }
}
