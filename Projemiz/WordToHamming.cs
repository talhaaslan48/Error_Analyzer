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

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			string inputData = GirdiMetnitxt.Text;

			// Metinsel veriyi Hamming kodu ile işleyin
			string hammingCode = HesaplaHammingKodu(inputData);

			// Hamming kodunu TextBox'ta gösterin
			HammingKodutxt.Text = hammingCode;

			// Hamming kodunu matris olarak DataGridView içinde gösterin
			DoldurDataGridView(hammingCode);
		}
		private string HesaplaHammingKodu(string inputData)
		{
			int dataLength = inputData.Length;
			int hammingCodeLength = 0;

			// Hamming kodu uzunluğunu hesaplayın
			while (dataLength + hammingCodeLength + 1 > Math.Pow(2, hammingCodeLength))
			{
				hammingCodeLength++;
			}

			StringBuilder hammingCode = new StringBuilder();
			int inputDataIndex = 0;
			int hammingBitIndex = 0;

			for (int i = 0; i < dataLength + hammingCodeLength; i++)
			{
				if (IsPowerOfTwo(i + 1))
				{
					hammingCode.Append('P'); // Parite bitleri için 'P' kullanıyoruz
				}
				else
				{
					hammingCode.Append('D'); // Veri bitleri için 'D' kullanıyoruz
					hammingCode.Append(inputData[inputDataIndex]);
					inputDataIndex++;
				}
			}

			// Parite bitlerini hesaplayın ve doldurun
			for (int i = 0; i < hammingCodeLength; i++)
			{
				int bitPosition = (int)Math.Pow(2, i);
				char parityBit = CalculateParityBit(hammingCode, bitPosition, hammingCodeLength);
				hammingCode[bitPosition - 1] = parityBit;
			}

			return hammingCode.ToString();
		}
		private void DoldurDataGridView(string hammingCode)
		{
			int numRows = 1;
			int numCols = hammingCode.Length;

			dataGridView.Rows.Clear();
			dataGridView.Columns.Clear();

			for (int i = 0; i < numCols; i++)
			{
				dataGridView.Columns.Add("Column" + i, "Bit " + i + " (" + hammingCode[i] + ")");

			}

			dataGridView.Rows.Add(numRows);

			for (int i = 0; i < numCols; i++)
			{
				dataGridView.Rows[0].Cells[i].Value = hammingCode[i];
			}
		}

		private char CalculateParityBit(StringBuilder hammingCode, int bitPosition, int hammingCodeLength)
		{
			char parityBit = '0';

			for (int i = bitPosition - 1; i < hammingCode.Length; i++)
			{
				if (i != bitPosition - 1 && ((i + 1) & bitPosition) == bitPosition)
				{
					parityBit ^= hammingCode[i];
				}
			}

			return parityBit;
		}

		private bool IsPowerOfTwo(int number)
		{
			return (number & (number - 1)) == 0;
		}
	}
}
