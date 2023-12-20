using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace Projemiz
{
	public partial class KullanımKılavuzu : Form
	{
		public KullanımKılavuzu()
		{
			InitializeComponent();

		}

		private void button10_Click(object sender, EventArgs e)
		{
			FormAnaSayfa form = new FormAnaSayfa();
			form.Show();
			this.Hide();
		}

		private void KullanımKılavuzu_Load(object sender, EventArgs e)
		{
			var pdfDocument = PdfDocument.Load("C:\\Users\\90545\\Desktop\\bitirme projesi\\ERROR ANALYZER KULLANIM KILAVUZU.pdf");
			var pdfViewer = new PdfViewer
			{
				Document = pdfDocument,
				Dock = DockStyle.Fill
			};

			panel2.AutoScroll = true;
			panel2.Controls.Add(pdfViewer);
		}
	}
}
