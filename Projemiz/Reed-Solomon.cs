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

		string tumleyen;
		public Reed_Solomon()
		{
			InitializeComponent();

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
			TextBox[] d1 = { textBox36, textBox35, textBox34, textBox33, textBox32, textBox31, textBox30, textBox29 };
			// TextBox'a girilen metni kontrol et
			string input = textBox1.Text;

			// Girilen metnin uzunluğunu kontrol et
			if (input.Length == 8)
			{
				for (int i = 0; i < d1.Length; i++)
				{
					d1[i].Text = input[i].ToString();
				}
			}
			else
			{
				for (int i = 0; i < d1.Length; i++)
				{
					d1[i].Text = "";
				}
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

			TextBox[] d2 = { textBox28, textBox27, textBox26, textBox25, textBox24, textBox23, textBox22, textBox21 };
			// TextBox'a girilen metni kontrol et
			string input = textBox2.Text;

			// Girilen metnin uzunluğunu kontrol et
			if (input.Length == 8)
			{
				for (int i = 0; i < d2.Length; i++)
				{
					d2[i].Text = input[i].ToString();
				}
			}
			else
			{
				for (int i = 0; i < d2.Length; i++)
				{
					d2[i].Text = "";
				}
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

			TextBox[] d3 = { textBox20, textBox19, textBox18, textBox17, textBox15, textBox14, textBox13, textBox12 };
			// TextBox'a girilen metni kontrol et
			string input = textBox3.Text;

			// Girilen metnin uzunluğunu kontrol et
			if (input.Length == 8)
			{
				for (int i = 0; i < d3.Length; i++)
				{
					d3[i].Text = input[i].ToString();
				}
			}
			else
			{
				for (int i = 0; i < d3.Length; i++)
				{
					d3[i].Text = "";
				}
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			TextBox[] d4 = { textBox16, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

			// TextBox'a girilen metni kontrol et
			string input = textBox4.Text;

			// Girilen metnin uzunluğunu kontrol et
			if (input.Length == 8)
			{
				for (int i = 0; i < d4.Length; i++)
				{
					d4[i].Text = input[i].ToString();
				}
			}
			else
			{
				for (int i = 0; i < d4.Length; i++)
				{
					d4[i].Text = "";
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{

			// TextBox'lar boş mu kontrol et
			if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
			{
				MessageBox.Show("Lütfen tüm alanları doldurunuz.");
				return; // Boş alan varsa işlemi durdur
			}

			textBox104.Text = txtResultBit1.Text;
			textBox103.Text = txtResultBit0.Text;


			List<string> binaries = new();

			// Her bir TextBox'tan binary veriyi al
			binaries.Add(textBox1.Text);
			binaries.Add(textBox2.Text);
			binaries.Add(textBox3.Text);
			binaries.Add(textBox4.Text);

			// Binary sayıları decimal sayılara çevirip topla
			int decimalResult = SumOfBinaries(binaries);


			// Toplamı binary'ye çevirip her bir biti ayrı TextBox'a yazdır
			string binaryResult = Convert.ToString(decimalResult, 2);

			binaryResult = ControlBit(binaryResult, 10);

			WriteTextBoxes("txtResultBit", binaryResult);


			textBox103.Text = txtResultBit0.Text;
			textBox104.Text = txtResultBit1.Text;

			var x = new List<string>() { txtResultBit0.Text + txtResultBit1.Text,
										 txtResultBit2.Text + txtResultBit3.Text +
										 txtResultBit4.Text + txtResultBit5.Text +
										 txtResultBit6.Text + txtResultBit7.Text +
										 txtResultBit8.Text + txtResultBit9.Text };
			// İlk iki biti decimal sayıya çevirip topla

			// Toplamı binary'ye çevirip her bir biti ayrı TextBox'a yazdır
			string binaryFinalResult = Convert.ToString(SumOfBinaries(x), 2);

			binaryFinalResult = ControlBit(binaryFinalResult, 8);

			WriteTextBoxes("txtFinalBit", binaryFinalResult);


			tumleyen = BinaryTumleyen(binaryFinalResult);

			WriteTextBoxes("txtCompBit", tumleyen);


		}

		private string ControlBit(string text, int bit)
		{
			if (text.Length < bit)
			{
				text = "0" + text;
				return ControlBit(text, bit);
			}
			else
			{
				return text;
			}
		}

		private int SumOfBinaries(List<string> binaries)
		{
			var sumOfBinaries = 0;
			foreach (string bin in binaries)
			{
				sumOfBinaries += Convert.ToInt32(bin, 2);
			}
			return sumOfBinaries;
		}

		private void WriteTextBoxes(string textBoxNameString, string binary, int incress = 0)
		{
			for (int i = 0; i < binary.Length; i++)
			{
				var textbox = GetTextBox(i + incress, textBoxNameString);
				textbox.Text = binary[i].ToString();
			}
		}

		private string BinaryTumleyen(string binary)
		{
			string tumleyen = "";
			for (var i = 0; i < binary.Length; i++)
			{
				if (binary[i] == '1')
				{
					tumleyen += "0";
				}
				else
				{
					tumleyen += "1";
				}
			}
			return tumleyen;
		}


		private TextBox GetTextBox(int index, string textBoxName)
		{
			// Formdaki TextBox'ları index'e göre bul
			return Controls.Find(textBoxName + index, true).FirstOrDefault() as TextBox;
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

			WriteTextBoxes("textBox", tumleyen, 69);

			string d1Data = textBox84.Text + textBox83.Text +
							textBox82.Text + textBox81.Text +
							textBox80.Text + textBox79.Text +
							textBox78.Text + textBox77.Text;
			string d2Data = textBox92.Text + textBox91.Text +
							textBox90.Text + textBox89.Text +
							textBox88.Text + textBox87.Text +
							textBox86.Text + textBox85.Text;
			string d3Data = textBox100.Text + textBox99.Text +
							textBox98.Text + textBox97.Text +
							textBox96.Text + textBox95.Text +
							textBox94.Text + textBox93.Text;
			string d4Data = textBox60.Text + textBox59.Text +
							textBox58.Text + textBox57.Text +
							textBox56.Text + textBox55.Text +
							textBox54.Text + textBox53.Text;

			List<string> binaries = new List<string>(){ d1Data,
				d2Data, d3Data, d4Data, tumleyen };

			int compFinalSum = SumOfBinaries(binaries);

			string compFinalSumResult = Convert.ToString(compFinalSum, 2);

			compFinalSumResult = ControlBit(compFinalSumResult, 10);

			WriteTextBoxes("txtCompFinalBit", compFinalSumResult);

			textBox115.Text = txtCompFinalBit0.Text;
			textBox116.Text = txtCompFinalBit1.Text;

			var x = new List<string>() { textBox115.Text + textBox116.Text,
										 txtCompFinalBit2.Text + txtCompFinalBit3.Text +
										 txtCompFinalBit4.Text + txtCompFinalBit5.Text +
										 txtCompFinalBit6.Text + txtCompFinalBit7.Text +
										 txtCompFinalBit8.Text + txtCompFinalBit9.Text };

			string reedSolomonResult = Convert.ToString(SumOfBinaries(x), 2);

			reedSolomonResult = ControlBit(reedSolomonResult, 8);

			WriteTextBoxes("txtReedSolomonResultBox", reedSolomonResult);

			if (reedSolomonResult == "11111111")
			{
				MessageBox.Show("Veri Hatasız bir şekilde iletilmiştir", "Okey", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Veri Hatalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

		private void textBox44_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string pdfDosyaYolu = "C:\\Users\\90545\\Desktop\\bitirme projesi\\pdfler\\Checksum_DersNotu.pdf";

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

		private void button1_Click(object sender, EventArgs e)
		{
			Checksum_NasılÇalışır_Form form = new Checksum_NasılÇalışır_Form();
			form.ShowDialog();
			this.Hide();
		}
	}
}


