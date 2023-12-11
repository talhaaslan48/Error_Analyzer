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
	public partial class CRC_NasılÇalışır_Form : Form
	{
		public CRC_NasılÇalışır_Form()
		{
			InitializeComponent();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			CRC form = new CRC();
			form.Show();
			this.Hide();
		}
	}
}
