namespace Projemiz
{
	partial class Checksum_NasılÇalışır_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checksum_NasılÇalışır_Form));
			panel1 = new Panel();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			label1 = new Label();
			button10 = new Button();
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
			panel1.Size = new Size(1313, 27);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkCyan;
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(1071, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(160, 189);
			panel3.TabIndex = 24;
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
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(225, 52);
			label2.Name = "label2";
			label2.Size = new Size(410, 42);
			label2.TabIndex = 30;
			label2.Text = "Checksum Nasıl Çalışır?";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(31, 154);
			label1.Name = "label1";
			label1.Size = new Size(1002, 476);
			label1.TabIndex = 31;
			label1.Text = resources.GetString("label1.Text");
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.Black;
			button10.Image = (Image)resources.GetObject("button10.Image");
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(31, 49);
			button10.Name = "button10";
			button10.Size = new Size(166, 61);
			button10.TabIndex = 32;
			button10.Text = " Geri Dön..";
			button10.TextImageRelation = TextImageRelation.ImageBeforeText;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// Checksum_NasılÇalışır_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1313, 706);
			Controls.Add(button10);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(panel3);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Checksum_NasılÇalışır_Form";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Checksum_NasılÇalışır_Form";
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label1;
		private Button button10;
	}
}