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
		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public Checksum_NasılÇalışır_Form()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;

			this.MouseDown += new System.Windows.Forms.MouseEventHandler(Checksum_NasılÇalışır_Form_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(Checksum_NasılÇalışır_Form_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(Checksum_NasılÇalışır_Form_MouseUp);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Reed_Solomon form = new Reed_Solomon();
			form.Show();
			this.Hide();
		}
		private void Checksum_NasılÇalışır_Form_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}

		private void Checksum_NasılÇalışır_Form_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void Checksum_NasılÇalışır_Form_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}
