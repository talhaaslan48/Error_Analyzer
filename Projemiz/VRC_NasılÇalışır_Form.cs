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
	public partial class VRC_NasılÇalışır_Form : Form
	{
		public VRC_NasılÇalışır_Form()
		{
			InitializeComponent();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			VRC form = new VRC();
			form.Show();
			this.Hide();
		}
	}
}
