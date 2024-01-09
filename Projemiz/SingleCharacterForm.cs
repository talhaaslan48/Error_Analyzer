using Projemiz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Projemiz
{
	public partial class SingleCharacterForm : Form
	{
		Hamming h; 

		string P1a, P2a, P3a, P4a, P1b, P2b, P3b, P4b;

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
			txtD5.Clear();
			txtD6.Clear();
			txtD7.Clear();
			txtD8.Clear();

		}

		void SetBinaryDataToTextBox(string b)
		{
			txtD1.Text = b[7].ToString();
			txtD2.Text = b[6].ToString();
			txtD3.Text = b[5].ToString();
			txtD4.Text = b[4].ToString();
			txtD5.Text = b[3].ToString();
			txtD6.Text = b[2].ToString();
			txtD7.Text = b[1].ToString();
			txtD8.Text = b[0].ToString();
		}

		public SingleCharacterForm()
		{
			InitializeComponent();
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
			lblP4b.Text = "";
			//P1----------------------------------------
			lblP1a.Text = "P1 = D1 + D2 + D4 + D5 + D7";
			lblP1b.Text = " =  " + txtD1.Text + " + " + txtD2.Text + " + " + txtD4.Text + " + " + txtD5.Text + " + " + txtD7.Text;
			P1a = h.XorOperator(txtD1.Text, txtD2.Text, txtD4.Text, txtD5.Text, txtD7.Text);
			lblP1b.Text = lblP1b.Text + "  =   " + P1a;
			//P2----------------------------------------
			lblP2a.Text = "P2 = D1 + D3 + D4 + D6 + D7";
			lblP2b.Text = " =  " + txtD1.Text + " + " + txtD3.Text + " + " + txtD4.Text + " + " + txtD6.Text + " + " + txtD7.Text;
			P2a = h.XorOperator(txtD1.Text, txtD3.Text, txtD4.Text, txtD6.Text, txtD7.Text);
			lblP2b.Text = lblP2b.Text + "  =   " + P2a;
			//P3----------------------------------------
			lblP3a.Text = "P3 = D2 + D3 + D4 + D8";
			lblP3b.Text = " =  " + txtD2.Text + " + " + txtD3.Text + " + " + txtD4.Text + " + " + txtD8.Text;
			P3a = h.XorOperator(txtD2.Text, txtD3.Text, txtD4.Text, txtD8.Text);
			lblP3b.Text = lblP3b.Text + "  =   " + P3a;
			//P4----------------------------------------
			lblP4a.Text = "P4 = D5 + D6 + D7 + D8";
			lblP4b.Text = " =  " + txtD5.Text + " + " + txtD6.Text + " + " + txtD7.Text + " + " + txtD8.Text;
			P4a = h.XorOperator(txtD5.Text, txtD6.Text, txtD7.Text, txtD8.Text);
			lblP4b.Text = lblP4b.Text + "  =   " + P4a;
			// Set Code Word to TextBox
			txtP1.Text = P1a;
			txtP2.Text = P2a;
			txtP3.Text = P3a;
			txtP4.Text = P4a;
			txtD1c.Text = txtD1.Text;
			txtD2c.Text = txtD2.Text;
			txtD3c.Text = txtD3.Text;
			txtD4c.Text = txtD4.Text;
			txtD5c.Text = txtD5.Text;
			txtD6c.Text = txtD6.Text;
			txtD7c.Text = txtD7.Text;
			txtD8c.Text = txtD8.Text;
		}

		void CalculateParity2()
		{
			lblP1c.Text = "";
			lblP1d.Text = "";
			lblP2c.Text = "";
			lblP2d.Text = "";
			lblP3c.Text = "";
			lblP3d.Text = "";
			lblP4c.Text = "";
			lblP4d.Text = "";
			//P1----------------------------------------
			lblP1c.Text = "P1 = D1 + D2 + D4 + D5 + D7";
			lblP1d.Text = " =  " + txtD1r.Text + " + " + txtD2r.Text + " + " + txtD4r.Text + " + " + txtD5r.Text + " + " + txtD7r.Text;
			P1b = h.XorOperator(txtD1r.Text, txtD2r.Text, txtD4r.Text, txtD5r.Text, txtD7r.Text);
			lblP1d.Text = lblP1d.Text + "  =   " + P1b;
			//P2----------------------------------------
			lblP2c.Text = "P2 = D1 + D3 + D4 + D6 + D7";
			lblP2d.Text = " =  " + txtD1r.Text + " + " + txtD3r.Text + " + " + txtD4r.Text + " + " + txtD6r.Text + " + " + txtD7r.Text;
			P2b = h.XorOperator(txtD1r.Text, txtD3r.Text, txtD4r.Text, txtD6r.Text, txtD7r.Text);
			lblP2d.Text = lblP2d.Text + "  =   " + P2b;
			//P3----------------------------------------
			lblP3c.Text = "P3 = D2 + D3 + D4 + D8";
			lblP3d.Text = " =  " + txtD2r.Text + " + " + txtD3r.Text + " + " + txtD4r.Text + " + " + txtD8r.Text;
			P3b = h.XorOperator(txtD2r.Text, txtD3r.Text, txtD4r.Text, txtD8r.Text);
			lblP3d.Text = lblP3d.Text + "  =   " + P3b;
			//P4----------------------------------------
			lblP4c.Text = "P4 = D5 + D6 + D7 + D8";
			lblP4d.Text = " =  " + txtD5r.Text + " + " + txtD6r.Text + " + " + txtD7r.Text + " + " + txtD8r.Text;
			P4b = h.XorOperator(txtD5r.Text, txtD6r.Text, txtD7r.Text, txtD8r.Text);
			lblP4d.Text = lblP4d.Text + "  =   " + P4b;
			// 


		}

		void ClearTextBoxT()
		{
			txtD1t.Clear(); txtD2t.Clear(); txtD3t.Clear(); txtD4t.Clear(); txtD5t.Clear(); txtD6t.Clear(); txtD7t.Clear(); txtD8t.Clear();
			txtP1t.Clear(); txtP2t.Clear(); txtP3t.Clear(); txtP4t.Clear();
			//---------------------------------------------------------------------------
			progressBar1.Value = 0;
			button3.Visible = false;
			devam = false;
			//---------------------------------------------------------------------------
			txtD1t.BackColor = txtD1c.BackColor; txtD2t.BackColor = txtD2c.BackColor; txtD3t.BackColor = txtD3c.BackColor; txtD4t.BackColor = txtD4c.BackColor; txtD5t.BackColor = txtD5c.BackColor; txtD6t.BackColor = txtD6c.BackColor; txtD7t.BackColor = txtD7c.BackColor; txtD8t.BackColor = txtD8c.BackColor;
			txtP1t.BackColor = txtP1.BackColor; txtP2t.BackColor = txtP2.BackColor; txtP3t.BackColor = txtP3.BackColor; txtP4t.BackColor = txtP4.BackColor;
			//----------------------------------------------------------------------------
			txtD1r.Clear(); txtD2r.Clear(); txtD3r.Clear(); txtD4r.Clear(); txtD5r.Clear(); txtD6r.Clear(); txtD7r.Clear(); txtD8r.Clear();
			txtP1r.Clear(); txtP2r.Clear(); txtP3r.Clear(); txtP4r.Clear();
			//---------------------------------------------------------------------------
			txtD1f.Clear(); txtD2f.Clear(); txtD3f.Clear(); txtD4f.Clear(); txtD5f.Clear(); txtD6f.Clear(); txtD7f.Clear(); txtD8f.Clear();
			txtD1f.BackColor = txtD1r.BackColor; txtD2f.BackColor = txtD2r.BackColor; txtD3f.BackColor = txtD3r.BackColor; txtD4f.BackColor = txtD4r.BackColor; txtD5f.BackColor = txtD5r.BackColor; txtD6f.BackColor = txtD6r.BackColor; txtD7f.BackColor = txtD7r.BackColor; txtD8f.BackColor = txtD8r.BackColor;
			//---------------------------------------------------------------------------
			UnLockT();
		}

		void LockT()
		{
			txtD1t.Enabled = false;
			txtD2t.Enabled = false;
			txtD3t.Enabled = false;
			txtD4t.Enabled = false;
			txtD5t.Enabled = false;
			txtD6t.Enabled = false;
			txtD7t.Enabled = false;
			txtD8t.Enabled = false;
			txtP1t.Enabled = false;
			txtP2t.Enabled = false;
			txtP3t.Enabled = false;
			txtP4t.Enabled = false;
		}
		void UnLockT()
		{
			txtD1t.Enabled = true;
			txtD2t.Enabled = true;
			txtD3t.Enabled = true;
			txtD4t.Enabled = true;
			txtD5t.Enabled = true;
			txtD6t.Enabled = true;
			txtD7t.Enabled = true;
			txtD8t.Enabled = true;
			txtP1t.Enabled = true;
			txtP2t.Enabled = true;
			txtP3t.Enabled = true;
			txtP4t.Enabled = true;
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
						if (h.IsEightDigit(txtData.Text))
						{
							//8 bit binary data
							BinaryData = txtData.Text;
							lblCh.Text = "(" + h.BinaryToHex(BinaryData.Substring(0, 4)) + h.BinaryToHex(BinaryData.Substring(4, 4)) + ")hex";
							groupBox2.Visible = true;
							groupBox3.Visible = true;
							SetBinaryDataToTextBox(BinaryData);
							CalculateParity1();
						}
						else
						{ MessageBox.Show("Binary dijit sayısı 8 tane olmalıdır!"); }
					}
					else
					{ MessageBox.Show("Geçersiz binary formatı!"); }
				}
				//radioButton1.Checked End .......................................

				if (radioButton2.Checked)
				{
					//Hex control
					if (h.IsTwoDigit(txtData.Text))
					{
						if (h.IsHex(txtData.Text.ToUpper()))
						{
							//2 digit Hex data
							BinaryData = h.HexStringToBinary(txtData.Text[0].ToString()) + h.HexStringToBinary(txtData.Text[1].ToString());
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
					{ MessageBox.Show("Hex hane sayısı 2 tane olmalıdır!"); }
				}
				//radioButton2.Checked End .......................................

				if (radioButton3.Checked)
				{

					char k;
					string tmp;
					k = Convert.ToChar(txtData.Text);
					tmp = Convert.ToByte(k).ToString("x2"); //Convert char to hexadecimal
					lblCh.Text = "(" + tmp.ToUpper() + ")hex";
					BinaryData = h.HexStringToBinary(tmp);
					groupBox2.Visible = true;
					groupBox3.Visible = true;
					SetBinaryDataToTextBox(BinaryData);
					CalculateParity1();

				}
				//radioButton3.Checked End .......................................
			}
			else
			{
				MessageBox.Show("Veri metin kutusunu boş bıraktınız!");
			}
		}

		private void SingleCharacterForm_Load(object sender, EventArgs e)
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

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			Reset();
			txtData.Clear();
			txtData.Focus();
			if (radioButton3.Checked)
			{ txtData.MaxLength = 1; }
			else if (radioButton2.Checked)
			{ txtData.MaxLength = 2; }
			else
			{ txtData.MaxLength = 8; }
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
				txtP4t.Text = txtP4.Text;
				txtD5t.Text = txtD5c.Text;
				txtD6t.Text = txtD6c.Text;
				txtD7t.Text = txtD7c.Text;
				txtD8t.Text = txtD8c.Text;
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
				txtD5r.Text = txtD5t.Text;
				txtD6r.Text = txtD6t.Text;
				txtD7r.Text = txtD7t.Text;
				txtD8r.Text = txtD8t.Text;
				txtP1r.Text = txtP1t.Text;
				txtP2r.Text = txtP2t.Text;
				txtP3r.Text = txtP3t.Text;
				txtP4r.Text = txtP4t.Text;
				//-------------------------
				CalculateParity2();
				//-------------------------
				txtP4ilk.Text = txtP4r.Text;
				txtP3ilk.Text = txtP3r.Text;
				txtP2ilk.Text = txtP2r.Text;
				txtP1ilk.Text = txtP1r.Text;
				//-------------------------
				txtP4son.Text = P4b;
				txtP3son.Text = P3b;
				txtP2son.Text = P2b;
				txtP1son.Text = P1b;
				//-------------------------
				txtK1.Text = h.XorOperator(txtP1ilk.Text, txtP1son.Text);
				txtK2.Text = h.XorOperator(txtP2ilk.Text, txtP2son.Text);
				txtK3.Text = h.XorOperator(txtP3ilk.Text, txtP3son.Text);
				txtK4.Text = h.XorOperator(txtP4ilk.Text, txtP4son.Text);
				//-------------------------
				BinaryPosition = txtK4.Text + txtK3.Text + txtK2.Text + txtK1.Text;
				lblDecimal.Text = Convert.ToString(Convert.ToInt32(BinaryPosition, 2));
				//-------------------------
				string ReceivedData = txtD8r.Text + txtD7r.Text + txtD6r.Text + txtD5r.Text + txtD4r.Text + txtD3r.Text + txtD2r.Text + txtD1r.Text;
				string AddText = "";
				if (lblDecimal.Text != "0")
				{
					txtD1f.Text = ReceivedData[7].ToString();
					txtD2f.Text = ReceivedData[6].ToString();
					txtD3f.Text = ReceivedData[5].ToString();
					txtD4f.Text = ReceivedData[4].ToString();
					txtD5f.Text = ReceivedData[3].ToString();
					txtD6f.Text = ReceivedData[2].ToString();
					txtD7f.Text = ReceivedData[1].ToString();
					txtD8f.Text = ReceivedData[0].ToString();
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
						case "9": AddText = "D5"; txtD5f.BackColor = Color.LightPink; break;
						case "10": AddText = "D6"; txtD6f.BackColor = Color.LightPink; break;
						case "11": AddText = "D7"; txtD7f.BackColor = Color.LightPink; break;
						case "12": AddText = "D8"; txtD8f.BackColor = Color.LightPink; break;
						default: MessageBox.Show("Algılanamayan hata durumu, hata düzeltilemez!"); break;
					}
					int kontrol = Convert.ToInt32(lblDecimal.Text);
					if (kontrol >= 1 && kontrol <= 12)
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
						case "9":
							txtD5f.BackColor = Color.LightGreen;
							txtD5f.Text = h.NotOperator(txtD5f.Text);
							break;
						case "10":
							txtD6f.BackColor = Color.LightGreen;
							txtD6f.Text = h.NotOperator(txtD6f.Text);
							break;
						case "11":
							txtD7f.BackColor = Color.LightGreen;
							txtD7f.Text = h.NotOperator(txtD7f.Text);
							break;
						case "12":
							txtD8f.BackColor = Color.LightGreen;
							txtD8f.Text = h.NotOperator(txtD8f.Text);
							break;
						default: break;
					}

					lblChf.Text = "(" + h.BinaryToHex(txtD8f.Text + txtD7f.Text + txtD6f.Text + txtD5f.Text) + h.BinaryToHex(txtD4f.Text + txtD3f.Text + txtD2f.Text + txtD1f.Text) + ")hex";
				}
				else
				{
					txtD1f.Text = ReceivedData[7].ToString();
					txtD2f.Text = ReceivedData[6].ToString();
					txtD3f.Text = ReceivedData[5].ToString();
					txtD4f.Text = ReceivedData[4].ToString();
					txtD5f.Text = ReceivedData[3].ToString();
					txtD6f.Text = ReceivedData[2].ToString();
					txtD7f.Text = ReceivedData[1].ToString();
					txtD8f.Text = ReceivedData[0].ToString();
					lblChf.Text = "(" + h.BinaryToHex(ReceivedData.Substring(0, 4)) + h.BinaryToHex(ReceivedData.Substring(4, 4)) + ")hex";
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

		private void txtD8t_Click(object sender, EventArgs e)
		{
			if (txtD8t.Text == "1")
				txtD8t.Text = "0";
			else
				txtD8t.Text = "1";
			if (txtD8t.Text != txtD8c.Text)
				txtD8t.BackColor = Color.Orange;
			else
				txtD8t.BackColor = txtD8c.BackColor;
		}

		private void txtD7t_Click(object sender, EventArgs e)
		{
			if (txtD7t.Text == "1")
				txtD7t.Text = "0";
			else
				txtD7t.Text = "1";
			if (txtD7t.Text != txtD8c.Text)
				txtD7t.BackColor = Color.Orange;
			else
				txtD7t.BackColor = txtD7c.BackColor;
		}

		private void txtD6t_Click(object sender, EventArgs e)
		{
			if (txtD6t.Text == "1")
				txtD6t.Text = "0";
			else
				txtD6t.Text = "1";
			if (txtD6t.Text != txtD6c.Text)
				txtD6t.BackColor = Color.Orange;
			else
				txtD6t.BackColor = txtD6c.BackColor;
		}

		private void txtD5t_Click(object sender, EventArgs e)
		{
			if (txtD5t.Text == "1")
				txtD5t.Text = "0";
			else
				txtD5t.Text = "1";
			if (txtD5t.Text != txtD5c.Text)
				txtD5t.BackColor = Color.Orange;
			else
				txtD5t.BackColor = txtD5c.BackColor;
		}

		private void txtP4t_Click(object sender, EventArgs e)
		{
			if (txtP4t.Text == "1")
				txtP4t.Text = "0";
			else
				txtP4t.Text = "1";
			if (txtP4t.Text != txtP4.Text)
				txtP4t.BackColor = Color.Orange;
			else
				txtP4t.BackColor = txtP4.BackColor;
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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string pdfDosyaYolu = "C:\\Users\\90545\\Desktop\\bitirme projesi\\pdfler\\Hamming12,8_DersNotu.pdf";

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
			Hamming12 form = new Hamming12();
			form.ShowDialog();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				// YouTube video URL'si
				string url = "https://youtu.be/I2Y_prNJJkY";

				// Varsayılan web tarayıcısını belirterek URL'yi aç
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
	}
}
