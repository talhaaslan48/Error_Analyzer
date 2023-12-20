namespace Projemiz
{
	partial class KullanımKılavuzu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanımKılavuzu));
			panel1 = new Panel();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			button10 = new Button();
			panel2 = new Panel();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkCyan;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1707, 34);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkCyan;
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(1404, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(160, 195);
			panel3.TabIndex = 22;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(13, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(133, 147);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
			button1.ForeColor = Color.Black;
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(507, 40);
			button1.Name = "button1";
			button1.Size = new Size(667, 61);
			button1.TabIndex = 23;
			button1.Text = "KULLANIM KILAVUZU";
			button1.TextImageRelation = TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.Black;
			button10.Image = (Image)resources.GetObject("button10.Image");
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(12, 40);
			button10.Name = "button10";
			button10.Size = new Size(180, 61);
			button10.TabIndex = 24;
			button10.Text = " Geri Dön..";
			button10.TextImageRelation = TextImageRelation.ImageBeforeText;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Location = new Point(273, 127);
			panel2.Name = "panel2";
			panel2.Size = new Size(1067, 720);
			panel2.TabIndex = 27;
			// 
			// KullanımKılavuzu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1707, 859);
			Controls.Add(panel2);
			Controls.Add(button10);
			Controls.Add(button1);
			Controls.Add(panel3);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "KullanımKılavuzu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "KullanımKılavuzu";
			Load += KullanımKılavuzu_Load;
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private PictureBox pictureBox1;
		private Button button1;
		private Button button10;
		private Panel panel2;
	}
}