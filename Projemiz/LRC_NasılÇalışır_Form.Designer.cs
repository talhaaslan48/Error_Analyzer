﻿namespace Projemiz
{
	partial class LRC_NasılÇalışır_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LRC_NasılÇalışır_Form));
			panel1 = new Panel();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			button10 = new Button();
			label3 = new Label();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkCyan;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1432, 24);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkCyan;
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(1095, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(160, 187);
			panel3.TabIndex = 23;
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
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(826, 304);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(574, 287);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 27;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(21, 133);
			label1.Name = "label1";
			label1.Size = new Size(776, 600);
			label1.TabIndex = 28;
			label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(220, 79);
			label2.Name = "label2";
			label2.Size = new Size(489, 42);
			label2.TabIndex = 29;
			label2.Text = "LRC Algoritması Nasıl Çalışır?";
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.Black;
			button10.Image = (Image)resources.GetObject("button10.Image");
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(21, 69);
			button10.Name = "button10";
			button10.Size = new Size(166, 61);
			button10.TabIndex = 30;
			button10.Text = " Geri Dön..";
			button10.TextImageRelation = TextImageRelation.ImageBeforeText;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(21, 32);
			label3.Name = "label3";
			label3.Size = new Size(334, 17);
			label3.TabIndex = 46;
			label3.Text = "Formu boş noktalarından tutarak hareket ettirebilirsiniz..\r\n";
			// 
			// LRC_NasılÇalışır_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1432, 756);
			Controls.Add(label3);
			Controls.Add(button10);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox2);
			Controls.Add(panel3);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LRC_NasılÇalışır_Form";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LRC_NasılÇalışır_Form";
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label2;
		private Button button10;
		private Label label3;
	}
}