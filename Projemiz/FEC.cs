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
		Dictionary<string, string> fecTable = new Dictionary<string, string>
		{
			{"00", "00000"},
			{"01", "11100"},
			{"10", "10011"},
			{"11", "01111"}
		};
		// 110100  01100 11100 00000
		public FEC()
		{
			InitializeComponent();
		}



		private void btnCheckErrors_Click(object sender, EventArgs e)
		{
			listBoxResults.Items.Clear(); // ListBox'ı temizle

			string inputData = txtInputData.Text;
			List<string> dividedData = DivideData(inputData); // Giriş verisini 2'şer bitlere bölen fonksiyon
			List<string> randomData = GenerateRandomData(dividedData); // Rastgele veri üreten fonksiyon
			List<bool> control = Control(randomData);
			for (int i = 0; i < dividedData.Count; i++)
			{
				string expectedCodeword = fecTable[dividedData[i]];
				string randomCodeword = randomData[i]; // Her bir 2'lik bit için 5 katı kadar rastgele veri üretildiğinden, doğru indeksi seçiyoruz

				// XOR sonucunun uzunluğunu kontrol et
				if (control[i])
				{
					listBoxResults.Items.Add($"Input: {dividedData[i]}, Expected Codeword: {expectedCodeword}, Random Codeword: {randomCodeword}, Burada Hata yoktur,Çıktı ={dividedData[i]}");
				}
				else
				{
					var xorResults = XOR(randomCodeword);
					var cevap = EnKucukToplamSayiyiBul(xorResults.Select(x => x.Response).ToList());
					var enkucukSayilar = EnKucukSayiKontrol(xorResults.Select(x => x.Response).ToList(), cevap);
					if (enkucukSayilar.Count > 1)
					{
						var st = string.Join(",", enkucukSayilar);
						MessageBox.Show($"XOR lanmış datalardaki {st} sayılarının 1 toplamları aynı olduğu için lütfen tekrar gönderin", "Hata", MessageBoxButtons.OK);

						listBoxResults.Items.Add($"Input: {dividedData[i]}, Expected Codeword: {expectedCodeword}, Random Codeword: {randomCodeword}, RESEND");
					}
					else
					{

						foreach (var xorResult in xorResults)
						{
							if (xorResult.Response.Length != expectedCodeword.Length)
							{
								MessageBox.Show($"Hata: XOR sonucu beklenenden farklı uzunluktadır. Beklenen Uzunluk: {expectedCodeword.Length}, Gerçek Uzunluk: {xorResult.Response.Length}");
								return;
							}
							if (xorResult.Response == cevap)
							{
								listBoxResults.Items.Add($"Input: {dividedData[i]}, Expected Codeword: {expectedCodeword}, Random Codeword: {randomCodeword}, XORed Data:{xorResult.XoredData}, XOR Result: {xorResult.Response},Hatalıdır, Doğru Data:{dividedData[i]}");
							}
							else
							{
								listBoxResults.Items.Add($"Input: {dividedData[i]}, Expected Codeword: {expectedCodeword}, Random Codeword: {randomCodeword}, XORed Data:{xorResult.XoredData}, XOR Result: {xorResult.Response}");
							}
						}
					}
				}
				listBoxResults.Items.Add("--------------------------------------------------------");
			}
		}

		private List<string> EnKucukSayiKontrol(List<string> sayilar, string enKucukSayi)
		{
			List<string> kucukSayilar = new();
			foreach (var sayi in sayilar)
			{
				if (ToplamBul(sayi) == ToplamBul(enKucukSayi))
				{
					kucukSayilar.Add(sayi);
				}
			}
			return kucukSayilar;
		}

		private string EnKucukToplamSayiyiBul(List<string> sayilar)
		{
			int enKucukToplam = int.MaxValue; // Başlangıçta en büyük int değeri
			string enKucukToplamSayi = "";

			foreach (string sayi in sayilar)
			{
				int toplam = ToplamBul(sayi);

				if (toplam < enKucukToplam)
				{
					enKucukToplam = toplam;
					enKucukToplamSayi = sayi;
				}
			}

			return enKucukToplamSayi;
		}

		private int ToplamBul(string bitString)
		{
			int toplam = 0;

			foreach (char bit in bitString)
			{
				if (bit == '1')
				{
					toplam++;
				}
			}

			return toplam;
		}

		private List<bool> Control(List<string> datas)
		{
			List<bool> control = new();
			bool flag = false;
			for (int i = 0; i < datas.Count; i++)
			{
				if (fecTable["00"] == datas[i])
				{
					flag = true;
				}
				if (fecTable["01"] == datas[i])
				{
					flag = true;
				}
				if (fecTable["10"] == datas[i])
				{
					flag = true;
				}
				if (fecTable["11"] == datas[i])
				{
					flag = true;
				}
				control.Add(flag);
				flag = false;
			}
			return control;
		}

		private List<XORResponseDto> XOR(string b)
		{
			List<XORResponseDto> deneme = new();
			foreach (var fectData in fecTable)
			{
				StringBuilder result = new StringBuilder();

				int length = Math.Min(fectData.Value.Length, b.Length);

				for (int i = 0; i < length; i++)
				{
					result.Append(fectData.Value[i] == b[i] ? '0' : '1');
				}
				deneme.Add(new XORResponseDto
				{
					Response = result.ToString(),
					XoredData = fectData.Value
				});
			}

			return deneme;
		}



		private bool IsCodewordValid(string codeword)
		{
			return fecTable.ContainsValue(codeword);
		}

		private static List<string> DivideData(string inputData)
		{
			List<string> dividedData = new List<string>();

			for (int i = 0; i < inputData.Length; i += 2)
			{
				if (i + 1 < inputData.Length)
				{
					dividedData.Add(inputData.Substring(i, 2));
				}
				else
				{
					dividedData.Add(inputData.Substring(i, 1) + "0");
				}
			}

			return dividedData;
		}

		private List<string> GenerateRandomData(List<string> divededData)
		{
			Random random = new Random();
			List<string> randomData = new List<string>();

			foreach (var data in divededData)
			{
				randomData.Add(fecTable[$"{data}"]);
			}

			randomData = Deneme(randomData);

			txtRandomBits.Text = string.Join("", randomData); // Rastgele üretilen bitleri TextBox'ta göster
			return randomData;
		}


		private List<string> Deneme(List<string> datas)
		{
			Random random = new Random();

			HashSet<int> bozulmusIndexler = new HashSet<int>(); // Bozulmuş indexleri saklamak için kullanılan HashSet

			for (int i = 0; i < datas.Count; i++)
			{
				int index;
				do
				{
					index = random.Next(0, datas.Count); // Rasgele bir indeks seç
				} while (bozulmusIndexler.Contains(index)); // Eğer indeks daha önce bozulmuşsa, tekrar seç

				datas[index] = BozulmusSayi(datas[index], random.Next(0, 2)); // Seçilen indeksteki veriyi boz
				bozulmusIndexler.Add(index); // Bozulmuş index'i HashSet'e ekle
			}

			return datas;
		}


		private string BozulmusSayi(string sayiBinary, int bozulacakBitSayisi = 1)
		{
			// Rasgele bozulacak bitleri seç
			Random random = new Random();
			int[] bozulacakBitler = new int[bozulacakBitSayisi];
			for (int i = 0; i < bozulacakBitSayisi; i++)
			{
				int bozulacakBitIndex = random.Next(0, sayiBinary.Length);
				while (Array.IndexOf(bozulacakBitler, bozulacakBitIndex) != -1)
				{
					bozulacakBitIndex = random.Next(0, sayiBinary.Length);
				}
				bozulacakBitler[i] = bozulacakBitIndex;
			}

			// Bozulmuş sayıyı oluştur
			char[] bozulmusBinarySayi = sayiBinary.ToCharArray();
			foreach (int bozulacakBitIndex in bozulacakBitler)
			{
				bozulmusBinarySayi[bozulacakBitIndex] = (bozulmusBinarySayi[bozulacakBitIndex] == '0') ? '1' : '0';
			}

			// Bozulmuş sayıyı string'e çevir
			string bozulmusSayiString = new string(bozulmusBinarySayi);

			return bozulmusSayiString;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FEC_NasılÇalışır_Form form = new FEC_NasılÇalışır_Form();
			form.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
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

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}





