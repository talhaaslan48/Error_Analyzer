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

			// QR kodunu oluştur
			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.M);
			QRCode qrCode = new QRCode(qrCodeData);

			// QR kodunu görüntülemek için bir resim oluştur
			Bitmap qrCodeImage = qrCode.GetGraphic(20);

			// PictureBox bileşenine görüntüyü yerleştir
			QRCodePictureBox.Image = qrCodeImage;
		}

		private void DecodeButton_Click(object sender, EventArgs e)
		{
			// QR kodunu tarayıcıdan oku (örneğin, bir dosya veya kamera ile)
			// Daha sonra bu örnekte basitçe bir metin olarak kabul edeceğiz.
			string qrCodeText = QRCodeTextBox.Text;

			// QR kodunu doğrula ve veriyi çıkar
			try
			{
				BarcodeReader barcodeReader = new BarcodeReader();
				ZXing.Result result = barcodeReader.Decode(new Bitmap(qrCodeText));

				if (result != null)
				{
					DecodedTextBox.Text = result.Text;
				}
				else
				{
					MessageBox.Show("QR kodu çözülemedi.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("QR kodu çözülemedi: " + ex.Message);
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
	}
}
