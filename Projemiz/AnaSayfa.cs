namespace Projemiz
{
	public partial class FormAnaSayfa : Form
	{
		public FormAnaSayfa()
		{
			InitializeComponent();

			// Label'� ba�lang��ta gizle
			label1.Visible = false;

			// Butonun MouseHover olay�n� tan�mlay�n
			button10.MouseHover += new EventHandler(button10_MouseHover);

			// Butonun MouseLeave olay�n� tan�mlay�n
			button10.MouseLeave += new EventHandler(button10_MouseLeave);

			label1.Font = button10.Font;
			label1.ForeColor = button10.ForeColor;
			label1.BackColor = button10.BackColor;
			label1.TextAlign = ContentAlignment.MiddleCenter;
		}




		private void FormAnaSayfa_Load(object sender, EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		}



		private void button3_Click(object sender, EventArgs e)
		{

			LRCcs form3 = new LRCcs();
			form3.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			CRC form4 = new CRC();
			form4.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SingleCharacterForm form1 = new SingleCharacterForm();
			form1.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			FEC form5 = new FEC();
			form5.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			VRC form6 = new VRC();
			form6.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Reed_Solomon form7 = new Reed_Solomon();
			form7.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SingleCharacterForm7 form7 = new SingleCharacterForm7();
			form7.Show();
			this.Hide();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Kullan�mK�lavuzu form = new Kullan�mK�lavuzu();
			form.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			BizKimizForm form = new BizKimizForm();
			form.Show();
			this.Hide();
		}

		private void btnGoogleForm_Click(object sender, EventArgs e)
		{
			string googleFormUrl = "https://docs.google.com/forms/d/1WyDjwQgvjOUPXpTsu0kuYI-0ZsrbD7zHEUkKrDF46dU/edit?hl=tr";
			// Varsay�lan web taray�c�s�n� ba�lat
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
			{
				FileName = googleFormUrl,
				UseShellExecute = true
			});
		}

		private void FormAnaSayfa_Load_1(object sender, EventArgs e)
		{

		}

		private void FormAnaSayfa_MouseHover(object sender, EventArgs e)
		{

		}

		private void button10_MouseHover(object sender, EventArgs e)
		{
			// Fare butonun �zerine geldi�inde label'� g�ster
			label1.Text = "��k��";
			label1.Visible = true;
		}

		private void button10_MouseLeave(object sender, EventArgs e)
		{
			// Fare butonun �zerinden ayr�ld���nda label'� gizle
			label1.Visible = false;
		}
	}
}