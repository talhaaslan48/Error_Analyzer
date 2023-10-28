using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projemiz
{
    public partial class BCH : Form
    {
        public BCH()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili öğeyi kontrol edin
            string selectedOption = comboBox2.SelectedItem?.ToString();

            // Sadece "7^4" seçildiğinde işlemleri gerçekleştir
            if (selectedOption == "7-4")
            {
                ShowFor7To4();
            }
            else
            {
                // Diğer durumları ele alabilirsiniz
                HideFor7To4();
            }


        }
        private void ShowFor7To4()
        {
            // Burada "7^4" seçildiğinde gösterilecek kontrol ve işlemleri gerçekleştirin
            // Örneğin, ilgili TextBox'ları ve Label'ları görünür yapabilirsiniz
            resultLabel.Visible = true;
            ResultLabel1.Visible = true;
            receivedTextBox.Visible = true;
            decodeButton.Visible = true;

            // Ayrıca, "Diğer Seçenek" ile ilgili kontrol ve işlemleri gizleyebilirsiniz
            // Örneğin:
            // otherLabel.Visible = false;
            // otherTextBox.Visible = false;
            // otherButton.Visible = false;
        }

        private void HideFor7To4()
        {
            // Burada "Diğer Seçenek" seçildiğinde gizlenecek kontrol ve işlemleri gerçekleştirin
            // Örneğin, ilgili TextBox'ları ve Label'ları gizleyebilirsiniz


            // Ayrıca, "7^4" ile ilgili kontrol ve işlemleri gösterebilirsiniz
            // Örneğin:
            // otherLabel.Visible = true;
            // otherTextBox.Visible = true;
            // otherButton.Visible = true;
        }


        private void encodeButton_Click(object sender, EventArgs e)
        {
            string originalData = originalTextBox.Text;
            string encodedData = EncodeHamming74(originalData);
            encodedTextBox.Text = encodedData;
            resultLabel.Text = $"Original Data: {originalData}\nEncoded Data: {encodedData}";
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string receivedData = receivedTextBox.Text;
            string decodedData = DecodeHamming74(receivedData);
            decodedTextBox.Text = decodedData;

            // Sonuçları label'a yazdır
            ResultLabel1.Text = $"Received Data: {receivedData}\nDecoded Data: {decodedData}";
        }
        private string EncodeHamming74(string data)
        {
            // Veriyi 4 bitlik bloklara ayır
            int[] originalBits = new int[4];
            for (int i = 0; i < 4; i++)
            {
                originalBits[i] = int.Parse(data[i].ToString());
            }

            // Hamming Kodu oluştur
            int[] encodedBits = new int[7];
            encodedBits[2] = originalBits[0];
            encodedBits[4] = originalBits[1];
            encodedBits[5] = originalBits[2];
            encodedBits[6] = originalBits[3];

            // Parity bitlerini hesapla
            encodedBits[0] = encodedBits[2] ^ encodedBits[4] ^ encodedBits[6];
            encodedBits[1] = encodedBits[2] ^ encodedBits[5] ^ encodedBits[6];
            encodedBits[3] = encodedBits[4] ^ encodedBits[5] ^ encodedBits[6];

            // Sonucu string'e çevir
            StringBuilder encodedData = new StringBuilder();
            foreach (var bit in encodedBits)
            {
                encodedData.Append(bit);
            }

            return encodedData.ToString();
        }

        private string DecodeHamming74(string receivedData)
        {
            // Alınan veriyi 7 bitlik bloklara ayır
            int[] receivedBits = new int[7];
            for (int i = 0; i < 7; i++)
            {
                receivedBits[i] = int.Parse(receivedData[i].ToString());
            }

            // Parity bitlerini kontrol et
            int errorBit = (receivedBits[0] ^ receivedBits[2] ^ receivedBits[4] ^ receivedBits[6]) +
                            (receivedBits[1] ^ receivedBits[2] ^ receivedBits[5] ^ receivedBits[6]) * 2 +
                            (receivedBits[3] ^ receivedBits[4] ^ receivedBits[5] ^ receivedBits[6]) * 4;

            // Hata varsa düzelt
            if (errorBit != 0)
            {
                receivedBits[errorBit - 1] = (receivedBits[errorBit - 1] == 0) ? 1 : 0;
            }

            // Düzeltildiğinde elde edilen veriyi string'e çevir
            StringBuilder decodedData = new StringBuilder();
            for (int i = 2; i < 7; i++)
            {
                decodedData.Append(receivedBits[i]);
            }

            return decodedData.ToString();
        }
    }
}
