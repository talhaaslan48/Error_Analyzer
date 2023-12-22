using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projemiz
{
    public partial class LRCcs : Form
    {
        public LRCcs()
        {
            InitializeComponent();
            button4.Enabled = false;

			textBox1.TextChanged += TextBox_TextChanged;
			textBox2.TextChanged += TextBox_TextChanged;
			textBox3.TextChanged += TextBox_TextChanged;
			textBox4.TextChanged += TextBox_TextChanged;
		}
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox currentTextBox = sender as TextBox;
			if (currentTextBox != null && currentTextBox.Text.Length == 8)
			{
				SelectNextTextBox(currentTextBox);
			}
		}
		private void SelectNextTextBox(TextBox currentTextBox)
		{
			// Enter tuşuyla veya diğer yollarla TextBox'a girilen veriyi kontrol edin
			Control nextControl = GetNextControl(currentTextBox, true);
			if (nextControl != null)
			{
				nextControl.Focus();
			}
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddLabelsToTableLayoutPanel(TextBox textBox, int rowIndex)
        {
            if (textBox.Text.Length == 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    Label label = new Label();
                    label.Text = textBox.Text[i].ToString();
                    label.ForeColor = Color.Black; // Rengi siyah yap
                    label.Font = new Font(label.Font.FontFamily, 12); // Puntoyu 12 yap
                    tableLayoutPanel1.Controls.Add(label, i, rowIndex);
                }

                // Yenile butonunu etkinleştir
                buttonYenile.Enabled = true;
            }
        }

        private void fillTable()
        {
            if (
                (textBox1.Text.Length == 8 || textBox1.Text.Length == 0) &&
                (textBox2.Text.Length == 8 || textBox2.Text.Length == 0) &&
                (textBox3.Text.Length == 8 || textBox3.Text.Length == 0) &&
                (textBox4.Text.Length == 8 || textBox4.Text.Length == 0)
                )
            {
                tableLayoutPanel1.Controls.Clear();
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

        private void LRCcs_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            list.Clear();
            bool test = false;
            button4.Enabled = true;


            try
            {
                string[] girilenMetinler = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };

                foreach (string girilenMetin in girilenMetinler)
                {
                    if (girilenMetin.Length != 8)
                    {
                        return;
                    }
                }

                test = true;
            }
            catch
            {
                MessageBox.Show("Lütfen her kutucağa 8 karakter uzunluğunda bir sayı girin.");
            }

            if (test)
            {
                fillTable();
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
                    }

                    string sonuc = (birSayisi % 2 == 0) ? "0" : "1";
                    Label sonucLabel = new Label();
                    sonucLabel.Text = sonuc;
                    sonucLabel.ForeColor = Color.Black; // Rengi siyah yap
                    sonucLabel.Font = new Font(sonucLabel.Font.FontFamily, 12); // Puntoyu 12 yap
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


        private void LRCcs_Load(object sender, EventArgs e)
        {

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label5.Text = "";

            tableLayoutPanel1.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			LRC_NasılÇalışır_Form form = new LRC_NasılÇalışır_Form();
			form.TopMost = true;  // Pencereyi en üstte tutar
			form.Owner = this; // Bu satırı ekleyin
			form.ShowDialog();
			this.Hide();
		}

        private void button10_Click(object sender, EventArgs e)
        {
            FormAnaSayfa form = new FormAnaSayfa();
            form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string pdfDosyaYolu = "C:\\Users\\90545\\Desktop\\bitirme projesi\\pdfler\\LRC_DersNotu.pdf";

            if (File.Exists(pdfDosyaYolu))
            {
                byte[] pdfBytes = File.ReadAllBytes(pdfDosyaYolu);
                MemoryStream memoryStream = new MemoryStream(pdfBytes);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
                saveFileDialog.FileName = "YeniDosyaAdi.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                    MessageBox.Show("PDF İndirme Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Belirtilen PDF dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void IkilikSayilariKarsilastir()
        {
            string kullaniciGirisi = textBox5.Text;

            if (kullaniciGirisi.Length == 8)
            {
                string olusturulanIkilik = string.Join("", list);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
			// textBox5'in boş olup olmadığını kontrol ediyoruz.
			if (string.IsNullOrWhiteSpace(textBox5.Text))
			{
				MessageBox.Show("Lütfen gerekli veriyi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; // Eğer metin kutusu boşsa, burada fonksiyonu sonlandırıyoruz.
			}

			IkilikSayilariKarsilastir();
            string kullaniciGirisi = textBox5.Text;
            string olusturulanIkilik = string.Join("", list);

            if (olusturulanIkilik.Equals(kullaniciGirisi))
            {
                MessageBox.Show("Parity Bitleri Eşleşiyor!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Parity Bitleri Eşleşmiyor ! . Lütfen tekrar deneyin.", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
