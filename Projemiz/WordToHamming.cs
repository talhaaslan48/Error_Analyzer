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
    public partial class WordToHamming : Form
    {
        public WordToHamming()
        {
            InitializeComponent();
        }


        private string CalculateHammingCode(string input)
        {
            StringBuilder hammingCode = new StringBuilder();
            int blockSize = 4; // Her blok 4 karakter uzunluğunda   deneme123123123yaren
            int dataIndex = 0;

            while (dataIndex < input.Length)
            {
                string block = input.Substring(dataIndex, Math.Min(blockSize, input.Length - dataIndex));
                int blockSizeWithParity = blockSize + 3; // 3 parite biti ekleniyor

                StringBuilder blockWithParityBits = new StringBuilder(block);

                for (int i = 0; i < 3; i++)
                {
                    int parityBitIndex = (int)Math.Pow(2, i);
                    int parityBitValue = CalculateParityBitValue(blockWithParityBits.ToString(), parityBitIndex, blockSizeWithParity);
                    blockWithParityBits.Insert(parityBitIndex - 1, parityBitValue.ToString());
                }

                hammingCode.Append(blockWithParityBits.ToString());
                dataIndex += blockSize;
            }

            return hammingCode.ToString();
        }

        private int CalculateParityBitValue(string data, int parityBitIndex, int blockSize)
        {
            int parityBitValue = 0;

            for (int i = parityBitIndex - 1; i < blockSize; i += parityBitIndex * 2)
            {
                for (int j = i; j < Math.Min(i + parityBitIndex, blockSize); j++)
                {
                    if (j < data.Length)
                    {
                        parityBitValue ^= (data[j] == '1') ? 1 : 0;
                    }
                }
            }

            return parityBitValue;
        }

        private string GenerateDetailedOutput(string inputData, string hammingCode)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Girilen Veri: {inputData}");
            output.AppendLine("Hamming Kodu:");

            int blockSize = 4;
            int dataIndex = 0;

            for (int i = 0; i < hammingCode.Length; i += blockSize + 3)
            {
                string blockWithParity = hammingCode.Substring(i, blockSize + 3);
                output.AppendLine($"Veri Bloğu: {blockWithParity.Substring(3)}");
                output.AppendLine($"Parite Bitleri: {blockWithParity[0]}, {blockWithParity[1]}, {blockWithParity[2]}");
            }

            return output.ToString();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            string inputData = txtInput.Text;

            // Metinsel veriyi Hamming kodu ile işle
            string hammingCode = CalculateHammingCode(inputData);

            // DataGridView'i temizle
            dataGridViewOutput.Rows.Clear();

            int blockSize = 4;
            int dataIndex = 0;

            while (dataIndex < hammingCode.Length)
            {
                string blockWithParity = hammingCode.Substring(dataIndex, Math.Min(blockSize + 3, hammingCode.Length - dataIndex));
                string dataBlock = blockWithParity.Substring(3);
                string parityBits = $"{blockWithParity[0]}, {blockWithParity[1]}, {blockWithParity[2]}";
                dataGridViewOutput.Rows.Add(dataBlock, parityBits, dataBlock);
                dataIndex += blockSize + 3;
            }

        }

        private void WordToHamming_Load(object sender, EventArgs e)
        {
            // DataGridView için sütunlarını ekleyin
            DataGridViewTextBoxColumn dataBlockColumn = new DataGridViewTextBoxColumn();
            dataBlockColumn.HeaderText = "Veri Bloğu";
            DataGridViewTextBoxColumn parityBitsColumn = new DataGridViewTextBoxColumn();
            parityBitsColumn.HeaderText = "Parite Bitleri";
            DataGridViewTextBoxColumn hammingCodeColumn = new DataGridViewTextBoxColumn();
            hammingCodeColumn.HeaderText = "Hamming Kodu";

            dataGridViewOutput.Columns.Add(dataBlockColumn);
            dataGridViewOutput.Columns.Add(parityBitsColumn);
            dataGridViewOutput.Columns.Add(hammingCodeColumn);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSyf = new FormAnaSayfa();
            formAnaSyf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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


    }
}
