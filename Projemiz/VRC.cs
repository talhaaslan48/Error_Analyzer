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



		private void button3_Click(object sender, EventArgs e)
		{

			FormAnaSayfa formAnaSyf = new FormAnaSayfa();
			formAnaSyf.Show();
			this.Hide();
		}


		private void button2_Click(object sender, EventArgs e)
		{
			// Toplam 1 sayısı
			int toplamBirSayisi = 0;

			// Her bir TextBox'ten 1'leri say
			foreach (Control control in Controls)
			{
				if (control is TextBox textBox)
				{
					// TextBox'ten 1'leri say
					int sayiBirSayisi = textBox.Text.Count(c => c == '1');

					// Toplam 1 sayısını güncelle
					toplamBirSayisi += sayiBirSayisi;
				}
			}

			// Label'a sonucu yazdır
			label26.Text = toplamBirSayisi % 2 == 1 ? "1" : "0";

			textBox15.Text = textBox23.Text;
			textBox14.Text = textBox1.Text;
			textBox13.Text = textBox2.Text;
			textBox12.Text = textBox3.Text;
			textBox11.Text = textBox4.Text;
			textBox10.Text = textBox5.Text;
			textBox9.Text = textBox6.Text;
			textBox8.Text = textBox7.Text;

			// Eğer labelSonuc'un Text özelliği null değilse ve boş değilse
			if (!string.IsNullOrEmpty(label26.Text))
			{
				// labelSonuc'un Text'ini textBoxSonuc'a kopyala
				textBox24.Text = label26.Text;
			}

		}


		private int sure = 5; // İlerleme süresi (saniye)
		private int adimSayisi = 100; // Toplam adım sayısı
		private int adimSuresi; // Her adımın süresi (milisaniye)

		private void button4_Click(object sender, EventArgs e)
		{
			button5.Enabled = false;
			// Adım süresini hesapla
			adimSuresi = sure * 1000 / adimSayisi;

			// Timer'ı başlat
			timerProgress.Start();






		}

		private void VRC_Load(object sender, EventArgs e)
		{

		}


		private void timerProgress_Tick(object sender, EventArgs e)
		{

			// ProgressBar henüz dolmadıysa
			if (progressBar1.Value < adimSayisi)
			{
				// Progress Bar'ın değerini artır
				progressBar1.Value += 1;
			}
			else
			{
				button5.Enabled = true;
				// ProgressBar dolunca Timer'ı durdur
				timerProgress.Stop();

				// TextBox'a veriyi yaz
				txtD8.Text = textBox15.Text;
				textBox16.Text = textBox14.Text;
				textBox17.Text = textBox13.Text;
				textBox18.Text = textBox12.Text;
				textBox19.Text = textBox11.Text;
				textBox20.Text = textBox10.Text;
				textBox21.Text = textBox9.Text;
				textBox22.Text = textBox8.Text;
				textBox25.Text = textBox24.Text;


			}
		}

		private void buttonYenile_Click(object sender, EventArgs e)
		{

			label26.Text = string.Empty;
			label27.Text = string.Empty;

			// Belirli TextBox'ların isimlerini ayarla
			string[] textBoxIsimleri = { "textBox1", "textBox2", "textBox3", "textBox4", "textBox5", "textBox6", "textBox7", "textBox8", "textBox9", "textBox10", "textBox11", "textBox12", "textBox13", "textBox14", "textBox15", "textBox16", "textBox17", "textBox18", "textBox19", "textBox20", "textBox21", "textBox22", "textBox23", "textBox24", "textBox25", "txtD8", }; // Örnek isimler, senin uygulamandaki isimlere uygun şekilde güncelle

			foreach (string textBoxIsim in textBoxIsimleri)
			{
				TextBox textBox = Controls.Find(textBoxIsim, true).FirstOrDefault() as TextBox;

				if (textBox != null)
				{
					// TextBox'ın içeriğini sil
					textBox.Text = string.Empty;
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int toplamBirSayisi = 0;

			// Belirli TextBox'ların isimlerini ve sayılarını ayarla
			string[] textBoxIsimleri = { "textBox15", "textBox14", "textBox13", "textBox12", "textBox11", "textBox10", "textBox9", "textBox8", "textBox24" }; // Örnek isimler, senin uygulamandaki isimlere uygun şekilde güncelle

			foreach (string textBoxIsim in textBoxIsimleri)
			{
				TextBox textBox = Controls.Find(textBoxIsim, true).FirstOrDefault() as TextBox;

				if (textBox != null)
				{
					int sayiBirSayisi = textBox.Text.Count(c => c == '1');
					toplamBirSayisi += sayiBirSayisi;
				}
			}

			// Çift veya tek sayıda 1 olduğuna göre "Hatasız" veya "Hatalı" yazdır
			if (toplamBirSayisi % 2 == 0)
			{
				label27.Text = "Kabul Edilir Data";
			}
			else
			{
				label27.Text = "Red Edilir Data";
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			string pdfDosyaYolu = "C:\\Users\\talha\\Downloads\\9.10.2023 Siber - 1.pdf";

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

		private void button6_Click(object sender, EventArgs e)
		{
			VRC_NasılÇalışır_Form form = new VRC_NasılÇalışır_Form();
			form.Show();
			this.Hide();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}
	}
}
