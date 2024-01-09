using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

			textBox0.TextChanged += TextBox_TextChanged;
			textBox1.TextChanged += TextBox_TextChanged;
			textBox2.TextChanged += TextBox_TextChanged;
			textBox3.TextChanged += TextBox_TextChanged;
			textBox4.TextChanged += TextBox_TextChanged;
			textBox5.TextChanged += TextBox_TextChanged;
			textBox6.TextChanged += TextBox_TextChanged;
			textBox7.TextChanged += TextBox_TextChanged;

		}
		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			TextBox currentTextBox = sender as TextBox;
			if (currentTextBox != null && currentTextBox.Text.Length == 1)
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

			// İlk GroupBox'ın ismini bilmiyorsanız, uygun isimle değiştirin.
			GroupBox inputGroupBox = this.groupBox1; // Örnek GroupBox ismi
			GroupBox parityGroupBox = this.groupBox2; // Parity TextBox'ın içinde olduğu GroupBox ismi

			for (int i = 0; i < 8; i++)
			{
				// İlk GroupBox içindeki TextBox'ları bul
				var textBoxName = "textBox" + i;
				var textBox = inputGroupBox.Controls[textBoxName] as TextBox;

				if (textBox != null)
				{
					// Boş değer kontrolü
					if (string.IsNullOrWhiteSpace(textBox.Text))
					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return; // Boş alan varsa işlemi durdur
					}

					// TextBox'taki 1'leri say
					int birSayisi = textBox.Text.Count(c => c == '1');
					// Toplam 1 sayısını güncelle
					toplamBirSayisi += birSayisi;
				}
				else
				{
					// TextBox bulunamadı, hata mesajı göster
					MessageBox.Show(textBoxName + " bulunamadı.");
				}
			}

			// Parity için GroupBox içindeki TextBox'ı bul
			var parityTextBoxName = "textBox24";
			var parityTextBox = parityGroupBox.Controls[parityTextBoxName] as TextBox;

			if (parityTextBox != null)
			{
				// Toplam 1 sayısına göre Parity TextBox'ı güncelle
				parityTextBox.Text = toplamBirSayisi % 2 == 0 ? "0" : "1";
			}
			else
			{
				// Parity TextBox bulunamadı, hata mesajı göster
				MessageBox.Show(parityTextBoxName + " bulunamadı.");
			}

			textBox15.Text = textBox0.Text;
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
			string[] textBoxIsimleri = { "textBox0", "textBox1", "textBox2", "textBox3", "textBox4", "textBox5", "textBox6", "textBox7", "textBox8", "textBox9", "textBox10", "textBox11", "textBox12", "textBox13", "textBox14", "textBox15", "textBox16", "textBox17", "textBox18", "textBox19", "textBox20", "textBox21", "textBox22", "textBox23", "textBox24", "textBox25", "txtD8", }; // Örnek isimler, senin uygulamandaki isimlere uygun şekilde güncelle

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
			label26.Text = textBox24.Text;
			int toplamBirSayisi = 0;

			// Belirli TextBox'ların isimlerini ve sayılarını ayarla
			string[] textBoxIsimleri = { "textBox15", "textBox14", "textBox13", "textBox12", "textBox11", "textBox10", "textBox9", "textBox8", "textBox24" };

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
			var assembly = Assembly.GetExecutingAssembly();
			var kaynakAdi = "Projemiz.VRC_DersNotu.pdf";

			using (Stream stream = assembly.GetManifestResourceStream(kaynakAdi))
			using (MemoryStream memoryStream = new MemoryStream())
			{
				stream.CopyTo(memoryStream);
				byte[] pdfBytes = memoryStream.ToArray();

				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "PDF Dosyaları (*.pdf)|*.pdf",
					FileName = "YeniDosyaAdi.pdf"
				};

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
					MessageBox.Show("PDF İndirme Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			VRC_NasılÇalışır_Form form = new VRC_NasılÇalışır_Form();
			form.ShowDialog();
			this.Hide();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void textBox0_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}
		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}
		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}
		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}
		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}
		private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox24_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sadece '0', '1' ve kontrol karakterlerine (örneğin, backspace) izin ver
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true; // Diğer karakter girişlerini engelle
			}
		}

		private void textBox0_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			// Sadece '0' veya '1' kabul et
			if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true; // Diğer tüm tuş vuruşlarını engelle
			}
		}
	}
}
