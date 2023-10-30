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

		private void EncodeButton_Click(object sender, EventArgs e)
		{
			// Kullanıcı tarafından girilen veriyi al
			string inputText = InputTextBox.Text;

			// Bit verisi ise metinsel temsile çevir
			if (IsBinary(inputText))
			{
				inputText = ConvertBinaryToText(inputText);
			}

			// QR kodunu oluştur
			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.M);
			QRCode qrCode = new QRCode(qrCodeData);

			// QR kodunun boyutunu ayarla (örneğin, 200x200 piksel)
			Bitmap qrCodeImage = qrCode.GetGraphic(8);

			// PictureBox bileşenine görüntüyü yerleştir
			QRCodePictureBox.Width = qrCodeImage.Width;
			QRCodePictureBox.Height = qrCodeImage.Height;
			QRCodePictureBox.Image = qrCodeImage;

			// QR kodunun metinsel temsilini QRCodeTextBox'a yerleştir
			QRCodeTextBox.Text = inputText;
		}

		private void DecodeButton_Click(object sender, EventArgs e)
		{
			string qrCodeText = QRCodeTextBox.Text; // QR kodunu içeren metinsel giriş

			try
			{
				BarcodeReader barcodeReader = new BarcodeReader();
				// QR kodunu bir resim olarak çözmek için metni bir Bitmap'e dönüştür
				Bitmap qrCodeBitmap = new Bitmap(qrCodeText);
				ZXing.Result result = barcodeReader.Decode(qrCodeBitmap);

				if (result != null)
				{
					DecodedTextBox.Text = result.Text;
				}
				else
				{
					MessageBox.Show("QR kodu çözülemedi veya hatalı formatta.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("QR kodu çözülürken hata oluştu: " + ex.Message);
			}
		}
		private string DecodeBinaryText(string binaryText)
		{
			// Burada binaryText'i istediğiniz gibi işleyebilirsiniz.
			// QR kodundan çıkan veriyi bu metot içinde işleyebilirsiniz.

			// Örnek olarak, metni ASCII karakterlere dönüştürelim:
			string decodedText = "";
			for (int i = 0; i < binaryText.Length; i += 8)
			{
				string binaryChar = binaryText.Substring(i, 8);
				int charCode = Convert.ToInt32(binaryChar, 2);
				char character = (char)charCode;
				decodedText += character;
			}

			return decodedText;
		}
		private string ConvertBinaryToText(string binaryText)
		{
			string decodedText = "";

			// 8 karakterlik bit dizilerini alıp metin haline çevir
			for (int i = 0; i < binaryText.Length; i += 8)
			{
				if (i + 8 <= binaryText.Length)
				{
					string binaryChar = binaryText.Substring(i, 8);
					byte characterByte = Convert.ToByte(binaryChar, 2);
					decodedText += (char)characterByte;
				}
				else
				{
					// Hata durumunda burada uygun bir işlem yapabilirsiniz.
					// Örneğin, eksik bitler nedeniyle hata mesajı gösterebilirsiniz.
					MessageBox.Show("Eksik bitler nedeniyle metin dönüştürme hatası.(8 bitlik veri giriniz.)");
					break;
				}
			}

			return decodedText;
		}

		private bool IsBinary(string input)
		{
			// Girdi metni bit dizisi mi yoksa metin mi olduğunu kontrol et
			foreach (char c in input)
			{
				if (c != '0' && c != '1')
				{
					return false; // Bit dizisi değil, metin
				}
			}
			return true; // Bit dizisi
		}
	}
}
