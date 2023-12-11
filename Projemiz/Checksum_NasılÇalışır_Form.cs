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
	public partial class Checksum_NasılÇalışır_Form : Form
	{
		public Checksum_NasılÇalışır_Form()
		{
			InitializeComponent();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Reed_Solomon form = new Reed_Solomon();
			form.Show();
			this.Hide();
		}
	}
}
