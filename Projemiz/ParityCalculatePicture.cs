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
	public partial class ParityCalculatePicture : Form
	{

		private bool dragging = false;
		private Point dragCursorPoint;
		private Point dragFormPoint;
		public ParityCalculatePicture()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.None;

			this.MouseDown += new System.Windows.Forms.MouseEventHandler(ParityCalculatePicture_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(ParityCalculatePicture_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(ParityCalculatePicture_MouseUp);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();	
		}

		private void ParityCalculatePicture_MouseDown(object sender, MouseEventArgs e)
		{
			dragging = true;
			dragCursorPoint = Cursor.Position;
			dragFormPoint = this.Location;
		}

		private void ParityCalculatePicture_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
				this.Location = Point.Add(dragFormPoint, new Size(dif));
			}
		}

		private void ParityCalculatePicture_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
		}
	}
}
