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
	public partial class SingleCharacterForm7 : Form
	{
		public SingleCharacterForm7()
		{
			InitializeComponent();
		}
		Hamming h;

		string P1a, P2a, P3a, P4a, P1b, P2b, P3b;

		string BinaryPosition;

		string BinaryData = "";

		bool devam = false;

		void Reset()
		{
			groupBox2.Visible = false;
			groupBox3.Visible = false;
			groupBox4.Visible = false;
			groupBox5.Visible = false;
			lblCh.Text = "";
			lblChf.Text = "";
			ClearTextBoxT();
			txtD1.Clear();
			txtD2.Clear();
			txtD3.Clear();
			txtD4.Clear();


		}

		void SetBinaryDataToTextBox(string b)
		{
			txtD1.Text = b[3].ToString();
			txtD2.Text = b[2].ToString();
			txtD3.Text = b[1].ToString();
			txtD4.Text = b[0].ToString();

		}

		void CalculateParity1()
		{
			lblP1a.Text = "";
			lblP1b.Text = "";
			lblP2a.Text = "";
			lblP2b.Text = "";
			lblP3a.Text = "";
			lblP3b.Text = "";
			lblP4a.Text = "";
			//P1----------------------------------------
			lblP1a.Text = "P1 = D1 + D2 + D4";
			lblP1b.Text = " =  " + txtD1.Text + " + " + txtD2.Text + " + " + txtD4.Text;
			P1a = h.XorOperator(txtD1.Text, txtD2.Text, txtD4.Text);
			lblP1b.Text = lblP1b.Text + "  =   " + P1a;
			//P2----------------------------------------
			lblP2a.Text = "P2 = D1 + D3 + D4";
			lblP2b.Text = " =  " + txtD1.Text + " + " + txtD3.Text + " + " + txtD4.Text;
			P2a = h.XorOperator(txtD1.Text, txtD3.Text, txtD4.Text);
			lblP2b.Text = lblP2b.Text + "  =   " + P2a;
			//P3----------------------------------------
			lblP3a.Text = "P3 = D2 + D3 + D4";
			lblP3b.Text = " =  " + txtD2.Text + " + " + txtD3.Text + " + " + txtD4.Text;
			P3a = h.XorOperator(txtD2.Text, txtD3.Text, txtD4.Text);
			lblP3b.Text = lblP3b.Text + "  =   " + P3a;

			// Set Code Word to TextBox
			txtP1.Text = P1a;
			txtP2.Text = P2a;
			txtP3.Text = P3a;

			txtD1c.Text = txtD1.Text;
			txtD2c.Text = txtD2.Text;
			txtD3c.Text = txtD3.Text;
			txtD4c.Text = txtD4.Text;

		}

		void CalculateParity2()
		{
			lblP1c.Text = "";
			lblP1d.Text = "";
			lblP2c.Text = "";
			lblP2d.Text = "";
			lblP3c.Text = "";
			lblP3d.Text = "";
			//P1----------------------------------------
			lblP1c.Text = "P1 = D1 + D2 + D4";
			lblP1d.Text = " =  " + txtD1r.Text + " + " + txtD2r.Text + " + " + txtD4r.Text;
			P1b = h.XorOperator(txtD1r.Text, txtD2r.Text, txtD4r.Text);
			lblP1d.Text = lblP1d.Text + "  =   " + P1b;
			//P2----------------------------------------
			lblP2c.Text = "P2 = D1 + D3 + D4";
			lblP2d.Text = " =  " + txtD1r.Text + " + " + txtD3r.Text + " + " + txtD4r.Text;
			P2b = h.XorOperator(txtD1r.Text, txtD3r.Text, txtD4r.Text);
			lblP2d.Text = lblP2d.Text + "  =   " + P2b;
			//P3----------------------------------------
			lblP3c.Text = "P3 = D2 + D3 + D4";
			lblP3d.Text = " =  " + txtD2r.Text + " + " + txtD3r.Text + " + " + txtD4r.Text;
			P3b = h.XorOperator(txtD2r.Text, txtD3r.Text, txtD4r.Text);
			lblP3d.Text = lblP3d.Text + "  =   " + P3b;



		}

		void ClearTextBoxT()
		{
			txtD1t.Clear(); txtD2t.Clear(); txtD3t.Clear(); txtD4t.Clear();
			txtP1t.Clear(); txtP2t.Clear(); txtP3t.Clear();
			//---------------------------------------------------------------------------
			progressBar1.Value = 0;
			button3.Visible = false;
			devam = false;
			//---------------------------------------------------------------------------
			txtD1t.BackColor = txtD1c.BackColor; txtD2t.BackColor = txtD2c.BackColor; txtD3t.BackColor = txtD3c.BackColor; txtD4t.BackColor = txtD4c.BackColor;
			txtP1t.BackColor = txtP1.BackColor; txtP2t.BackColor = txtP2.BackColor; txtP3t.BackColor = txtP3.BackColor;
			//----------------------------------------------------------------------------
			txtD1r.Clear(); txtD2r.Clear(); txtD3r.Clear(); txtD4r.Clear();
			txtP1r.Clear(); txtP2r.Clear(); txtP3r.Clear();
			//---------------------------------------------------------------------------
			txtD1f.Clear(); txtD2f.Clear(); txtD3f.Clear(); txtD4f.Clear();
			txtD1f.BackColor = txtD1r.BackColor; txtD2f.BackColor = txtD2r.BackColor; txtD3f.BackColor = txtD3r.BackColor; txtD4f.BackColor = txtD4r.BackColor;
			//---------------------------------------------------------------------------
			UnLockT();
		}

		void LockT()
		{
			txtD1t.Enabled = false;
			txtD2t.Enabled = false;
			txtD3t.Enabled = false;
			txtD4t.Enabled = false;

			txtP1t.Enabled = false;
			txtP2t.Enabled = false;
			txtP3t.Enabled = false;

		}
		void UnLockT()
		{
			txtD1t.Enabled = true;
			txtD2t.Enabled = true;
			txtD3t.Enabled = true;
			txtD4t.Enabled = true;

			txtP1t.Enabled = true;
			txtP2t.Enabled = true;
			txtP3t.Enabled = true;

		}
		private void button1_Click(object sender, EventArgs e)
		{
			//Hamming Kodu Oluştur Butonu
			if (txtData.Text.Trim() != "")
			{
				if (radioButton1.Checked)
				{
					//Binary control
					if (h.IsBinary(txtData.Text))
					{
						if (h.IsFourDigit(txtData.Text))
						{
							//8 bit binary data
							BinaryData = txtData.Text;
							lblCh.Text = "(" + h.BinaryToHexChar(BinaryData.Substring(0, 4)) + ")hex";
							groupBox2.Visible = true;
							groupBox3.Visible = true;
							SetBinaryDataToTextBox(BinaryData);
							CalculateParity1();
						}
						else
						{ MessageBox.Show("Binary dijit sayısı 4 tane olmalıdır!"); }
					}
					else
					{ MessageBox.Show("Geçersiz binary formatı!"); }
				}
				//radioButton1.Checked End .......................................

				if (radioButton2.Checked)
				{
					//Hex control
					if (h.IsOneDigit(txtData.Text))
					{
						if (h.IsHex(txtData.Text.ToUpper()))
						{
							//1 digit Hex data
							BinaryData = h.HexStringToBinary(txtData.Text[0].ToString());
							lblCh.Text = "(" + txtData.Text.ToUpper() + ")hex";
							groupBox2.Visible = true;
							groupBox3.Visible = true;
							SetBinaryDataToTextBox(BinaryData);
							CalculateParity1();
						}
						else
						{ MessageBox.Show("Geçersiz Hex formatı!"); }
					}
					else
					{ MessageBox.Show("Hex hane sayısı 1 tane olmalıdır!"); }
				}
				//radioButton2.Checked End .......................................

			}
			else
			{
				MessageBox.Show("Veri metin kutusunu boş bıraktınız!");
			}
		}

		private void SingleCharacterForm7_Load(object sender, EventArgs e)
		{
			h = new Hamming();
			txtData.MaxLength = 2;
			lblCh.Text = "";
			lblChf.Text = "";
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			Reset();
			txtData.Clear();
			txtData.Focus();
			if (radioButton2.Checked)
			{ txtData.MaxLength = 2; }
			else if (radioButton1.Checked)
			{ txtData.MaxLength = 8; }
			else
			{ txtData.MaxLength = 1; }
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			Reset();
			txtData.Clear();
			txtData.Focus();
			if (radioButton1.Checked)
			{ txtData.MaxLength = 8; }
			else if (radioButton2.Checked)
			{ txtData.MaxLength = 2; }
			else
			{ txtData.MaxLength = 1; }
		}


		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ParityCalculatePicture frm = new ParityCalculatePicture();
			frm.ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			progressBar1.Value = progressBar1.Value + 2;

			if (progressBar1.Value > 50 && devam == false)
			{
				timer1.Stop();
				txtP1t.Text = txtP1.Text;
				txtP2t.Text = txtP2.Text;
				txtD1t.Text = txtD1c.Text;
				txtP3t.Text = txtP3.Text;
				txtD2t.Text = txtD2c.Text;
				txtD3t.Text = txtD3c.Text;
				txtD4t.Text = txtD4c.Text;

				groupBox4.Visible = true;
			}
			if (progressBar1.Value == 100)
			{
				timer1.Stop();
				button3.Visible = false;
				groupBox5.Visible = true;
				LockT();
				//verilerin aktarılması
				txtD1r.Text = txtD1t.Text;
				txtD2r.Text = txtD2t.Text;
				txtD3r.Text = txtD3t.Text;
				txtD4r.Text = txtD4t.Text;

				txtP1r.Text = txtP1t.Text;
				txtP2r.Text = txtP2t.Text;
				txtP3r.Text = txtP3t.Text;

				//-------------------------
				CalculateParity2();
				//-------------------------

				txtP3ilk.Text = txtP3r.Text;
				txtP2ilk.Text = txtP2r.Text;
				txtP1ilk.Text = txtP1r.Text;
				//-------------------------

				txtP3son.Text = P3b;
				txtP2son.Text = P2b;
				txtP1son.Text = P1b;
				//-------------------------
				txtK1.Text = h.XorOperator(txtP1ilk.Text, txtP1son.Text);
				txtK2.Text = h.XorOperator(txtP2ilk.Text, txtP2son.Text);
				txtK3.Text = h.XorOperator(txtP3ilk.Text, txtP3son.Text);

				//-------------------------
				BinaryPosition = txtK3.Text + txtK2.Text + txtK1.Text;
				lblDecimal.Text = Convert.ToString(Convert.ToInt32(BinaryPosition, 2));
				//-------------------------
				string ReceivedData = txtD4r.Text + txtD3r.Text + txtD2r.Text + txtD1r.Text;
				string AddText = "";
				if (lblDecimal.Text != "0")
				{
					txtD1f.Text = ReceivedData[3].ToString();
					txtD2f.Text = ReceivedData[2].ToString();
					txtD3f.Text = ReceivedData[1].ToString();
					txtD4f.Text = ReceivedData[0].ToString();

					switch (lblDecimal.Text)
					{
						case "1": AddText = "P1"; break;
						case "2": AddText = "P2"; break;
						case "3": AddText = "D1"; txtD1f.BackColor = Color.LightPink; break;
						case "4": AddText = "P3"; break;
						case "5": AddText = "D2"; txtD2f.BackColor = Color.LightPink; break;
						case "6": AddText = "D3"; txtD3f.BackColor = Color.LightPink; break;
						case "7": AddText = "D4"; txtD4f.BackColor = Color.LightPink; break;
						case "8": AddText = "P4"; break;
						default: MessageBox.Show("Algılanamayan hata durumu, hata düzeltilemez!"); break;
					}
					int kontrol = Convert.ToInt32(lblDecimal.Text);
					if (kontrol >= 1 && kontrol <= 7)
					{
						MessageBox.Show(lblDecimal.Text + ".konumlu " + AddText + " nolu bit'te hata vardır!");
					}
					switch (lblDecimal.Text)
					{
						case "1": break;
						case "2": break;
						case "3":
							txtD1f.BackColor = Color.LightGreen;
							txtD1f.Text = h.NotOperator(txtD1f.Text);
							break;
						case "4": break;
						case "5":
							txtD2f.BackColor = Color.LightGreen;
							txtD2f.Text = h.NotOperator(txtD2f.Text);
							break;
						case "6":
							txtD3f.BackColor = Color.LightGreen;
							txtD3f.Text = h.NotOperator(txtD3f.Text);
							break;
						case "7":
							txtD4f.BackColor = Color.LightGreen;
							txtD4f.Text = h.NotOperator(txtD4f.Text);
							break;
						case "8": break;
						default: break;
					}

					lblChf.Text = "(" + h.BinaryToHexChar(txtD4f.Text + txtD3f.Text + txtD2f.Text + txtD1f.Text) + ")hex";
				}
				else
				{
					txtD1f.Text = ReceivedData[3].ToString();
					txtD2f.Text = ReceivedData[2].ToString();
					txtD3f.Text = ReceivedData[1].ToString();
					txtD4f.Text = ReceivedData[0].ToString();
					lblChf.Text = "(" + h.BinaryToHexChar(ReceivedData.Substring(0, 4)) + ")hex";
					MessageBox.Show("Hatalı Bit yoktur.");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ClearTextBoxT();
			lblChf.Text = "";
			timer1.Start();
			button3.Visible = true;
			groupBox4.Visible = false;
			groupBox5.Visible = false;
		}


		private void txtD4t_Click(object sender, EventArgs e)
		{
			if (txtD4t.Text == "1")
				txtD4t.Text = "0";
			else
				txtD4t.Text = "1";
			if (txtD4t.Text != txtD4c.Text)
				txtD4t.BackColor = Color.Orange;
			else
				txtD4t.BackColor = txtD4c.BackColor;
		}

		private void txtD3t_Click(object sender, EventArgs e)
		{
			if (txtD3t.Text == "1")
				txtD3t.Text = "0";
			else
				txtD3t.Text = "1";
			if (txtD3t.Text != txtD3c.Text)
				txtD3t.BackColor = Color.Orange;
			else
				txtD3t.BackColor = txtD3c.BackColor;
		}

		private void txtD2t_Click(object sender, EventArgs e)
		{
			if (txtD2t.Text == "1")
				txtD2t.Text = "0";
			else
				txtD2t.Text = "1";
			if (txtD2t.Text != txtD2c.Text)
				txtD2t.BackColor = Color.Orange;
			else
				txtD2t.BackColor = txtD2c.BackColor;
		}

		private void txtP3t_Click(object sender, EventArgs e)
		{
			if (txtP3t.Text == "1")
				txtP3t.Text = "0";
			else
				txtP3t.Text = "1";
			if (txtP3t.Text != txtP3.Text)
				txtP3t.BackColor = Color.Orange;
			else
				txtP3t.BackColor = txtP3.BackColor;
		}

		private void txtD1t_Click(object sender, EventArgs e)
		{
			if (txtD1t.Text == "1")
				txtD1t.Text = "0";
			else
				txtD1t.Text = "1";
			if (txtD1t.Text != txtD1c.Text)
				txtD1t.BackColor = Color.Orange;
			else
				txtD1t.BackColor = txtD1c.BackColor;
		}

		private void txtP2t_Click(object sender, EventArgs e)
		{
			if (txtP2t.Text == "1")
				txtP2t.Text = "0";
			else
				txtP2t.Text = "1";
			if (txtP2t.Text != txtP2.Text)
				txtP2t.BackColor = Color.Orange;
			else
				txtP2t.BackColor = txtP2.BackColor;
		}

		private void txtP1t_Click(object sender, EventArgs e)
		{
			if (txtP1t.Text == "1")
				txtP1t.Text = "0";
			else
				txtP1t.Text = "1";
			if (txtP1t.Text != txtP1.Text)
				txtP1t.BackColor = Color.Orange;
			else
				txtP1t.BackColor = txtP1.BackColor;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			devam = true;
			timer1.Start();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string pdfDosyaYolu = "C:\\Users\\90545\\Desktop\\bitirme projesi\\pdfler\\Hamming7,4_DersNotu.pdf";

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

		private void button4_Click(object sender, EventArgs e)
		{
			Hamming7 form = new Hamming7();
			form.ShowDialog();
			this.Hide();
		}
	}
}
