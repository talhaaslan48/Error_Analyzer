namespace Projemiz
{
	partial class VRC_NasılÇalışır_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRC_NasılÇalışır_Form));
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			button10 = new Button();
			panel1 = new Panel();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(886, 292);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(522, 436);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 43;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(24, 197);
			label1.Name = "label1";
			label1.Size = new Size(916, 400);
			label1.TabIndex = 42;
			label1.Text = resources.GetString("label1.Text");
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(261, 85);
			label2.Name = "label2";
			label2.Size = new Size(527, 44);
			label2.TabIndex = 41;
			label2.Text = "VRC Algoritması Nasıl Çalışır?";
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkCyan;
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(1204, 26);
			panel3.Name = "panel3";
			panel3.Size = new Size(160, 190);
			panel3.TabIndex = 40;
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
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.Black;
			button10.Image = (Image)resources.GetObject("button10.Image");
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(34, 84);
			button10.Name = "button10";
			button10.Size = new Size(166, 61);
			button10.TabIndex = 39;
			button10.Text = " Geri Dön..";
			button10.TextImageRelation = TextImageRelation.ImageBeforeText;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkCyan;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1432, 31);
			panel1.TabIndex = 44;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(34, 46);
			label3.Name = "label3";
			label3.Size = new Size(334, 17);
			label3.TabIndex = 45;
			label3.Text = "Formu boş noktalarından tutarak hareket ettirebilirsiniz..\r\n";
			// 
			// VRC_NasılÇalışır_Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1432, 756);
			Controls.Add(label3);
			Controls.Add(panel1);
			Controls.Add(pictureBox2);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(panel3);
			Controls.Add(button10);
			FormBorderStyle = FormBorderStyle.None;
			Name = "VRC_NasılÇalışır_Form";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "VRC_NasılÇalışır_Form";
			MouseDown += VRC_NasılÇalışır_Form_MouseDown;
			MouseMove += VRC_NasılÇalışır_Form_MouseMove;
			MouseUp += VRC_NasılÇalışır_Form_MouseUp;
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox2;
		private Label label1;
		private Label label2;
		private Panel panel3;
		private PictureBox pictureBox1;
		private Button button10;
		private Panel panel1;
		private Label label3;
	}
}