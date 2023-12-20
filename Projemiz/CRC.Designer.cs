namespace Projemiz
{
    partial class CRC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRC));
			label2 = new Label();
			label1 = new Label();
			dividendTextBox = new TextBox();
			divisorTextBox = new TextBox();
			label3 = new Label();
			label4 = new Label();
			button2 = new Button();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			TestTextBox = new TextBox();
			label12 = new Label();
			label13 = new Label();
			TestEtButton = new Button();
			label14 = new Label();
			panel2 = new Panel();
			panel1 = new Panel();
			panel3 = new Panel();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			button5 = new Button();
			button3 = new Button();
			button10 = new Button();
			groupBox1 = new GroupBox();
			label16 = new Label();
			label11 = new Label();
			label15 = new Label();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(270, 53);
			label2.Name = "label2";
			label2.Size = new Size(400, 58);
			label2.TabIndex = 3;
			label2.Text = "CRC Algoritması\r\n";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(107, 151);
			label1.Name = "label1";
			label1.Size = new Size(1208, 60);
			label1.TabIndex = 5;
			label1.Text = resources.GetString("label1.Text");
			// 
			// dividendTextBox
			// 
			dividendTextBox.Location = new Point(234, 518);
			dividendTextBox.Margin = new Padding(3, 2, 3, 2);
			dividendTextBox.Name = "dividendTextBox";
			dividendTextBox.Size = new Size(183, 23);
			dividendTextBox.TabIndex = 6;
			dividendTextBox.KeyPress += dividendTextBox_KeyPress;
			// 
			// divisorTextBox
			// 
			divisorTextBox.Location = new Point(234, 595);
			divisorTextBox.Margin = new Padding(3, 2, 3, 2);
			divisorTextBox.Name = "divisorTextBox";
			divisorTextBox.Size = new Size(183, 23);
			divisorTextBox.TabIndex = 7;
			divisorTextBox.KeyPress += divisorTextBox_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Linen;
			label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(107, 519);
			label3.Name = "label3";
			label3.Size = new Size(98, 22);
			label3.TabIndex = 8;
			label3.Text = "Dividend:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Linen;
			label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(107, 595);
			label4.Name = "label4";
			label4.Size = new Size(73, 22);
			label4.TabIndex = 9;
			label4.Text = "Divisor:";
			// 
			// button2
			// 
			button2.BackColor = Color.IndianRed;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			button2.Location = new Point(537, 527);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(201, 91);
			button2.TabIndex = 10;
			button2.Text = "Hesaplama Yap";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click_3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Linen;
			label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(1025, 513);
			label5.Name = "label5";
			label5.Size = new Size(80, 21);
			label5.TabIndex = 11;
			label5.Text = "CRC Biti :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(1111, 517);
			label6.Name = "label6";
			label6.Size = new Size(0, 17);
			label6.TabIndex = 12;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(1111, 567);
			label7.Name = "label7";
			label7.Size = new Size(0, 17);
			label7.TabIndex = 13;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(1111, 614);
			label8.Name = "label8";
			label8.Size = new Size(0, 17);
			label8.TabIndex = 14;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Linen;
			label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(836, 563);
			label9.Name = "label9";
			label9.Size = new Size(269, 21);
			label9.TabIndex = 15;
			label9.Text = "CodeWord CRC ile Data Birleşimi :";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Linen;
			label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label10.Location = new Point(927, 610);
			label10.Name = "label10";
			label10.Size = new Size(178, 21);
			label10.TabIndex = 16;
			label10.Text = "Hata Kontrol Sonucu :";
			// 
			// TestTextBox
			// 
			TestTextBox.Location = new Point(47, 80);
			TestTextBox.Name = "TestTextBox";
			TestTextBox.Size = new Size(220, 27);
			TestTextBox.TabIndex = 19;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.Linen;
			label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label12.Location = new Point(47, 200);
			label12.Name = "label12";
			label12.Size = new Size(178, 21);
			label12.TabIndex = 20;
			label12.Text = "Hata Kontrol Sonucu :";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label13.Location = new Point(231, 204);
			label13.Name = "label13";
			label13.Size = new Size(0, 17);
			label13.TabIndex = 21;
			// 
			// TestEtButton
			// 
			TestEtButton.FlatStyle = FlatStyle.Flat;
			TestEtButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			TestEtButton.Location = new Point(47, 130);
			TestEtButton.Name = "TestEtButton";
			TestEtButton.Size = new Size(220, 37);
			TestEtButton.TabIndex = 22;
			TestEtButton.Text = "Test Et";
			TestEtButton.UseVisualStyleBackColor = true;
			TestEtButton.Click += TestEtButton_Click;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(155, 63);
			label14.Name = "label14";
			label14.Size = new Size(0, 21);
			label14.TabIndex = 23;
			// 
			// panel2
			// 
			panel2.BackColor = Color.CadetBlue;
			panel2.Location = new Point(254, 53);
			panel2.Name = "panel2";
			panel2.Size = new Size(10, 67);
			panel2.TabIndex = 44;
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkCyan;
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1805, 21);
			panel1.TabIndex = 45;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkCyan;
			panel3.Controls.Add(pictureBox1);
			panel3.Location = new Point(1526, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(195, 237);
			panel3.TabIndex = 46;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(15, 29);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(163, 185);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = Color.Black;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(107, 255);
			button1.Name = "button1";
			button1.Size = new Size(166, 61);
			button1.TabIndex = 47;
			button1.Text = " Nasıl Çalışır?";
			button1.TextImageRelation = TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// button5
			// 
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button5.ForeColor = Color.Black;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.ImageAlign = ContentAlignment.MiddleLeft;
			button5.Location = new Point(1237, 255);
			button5.Name = "button5";
			button5.Size = new Size(264, 61);
			button5.TabIndex = 50;
			button5.Text = "Ders Videosuna Erişebilirsiniz";
			button5.TextImageRelation = TextImageRelation.ImageBeforeText;
			button5.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button3.ForeColor = Color.Black;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.ImageAlign = ContentAlignment.MiddleLeft;
			button3.Location = new Point(1526, 255);
			button3.Name = "button3";
			button3.Size = new Size(195, 61);
			button3.TabIndex = 49;
			button3.Text = "      Ders Notu       İndirebilirsiniz";
			button3.TextImageRelation = TextImageRelation.ImageBeforeText;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button10
			// 
			button10.FlatAppearance.BorderSize = 0;
			button10.FlatStyle = FlatStyle.Flat;
			button10.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			button10.ForeColor = Color.Black;
			button10.Image = (Image)resources.GetObject("button10.Image");
			button10.ImageAlign = ContentAlignment.MiddleLeft;
			button10.Location = new Point(28, 53);
			button10.Name = "button10";
			button10.Size = new Size(166, 61);
			button10.TabIndex = 51;
			button10.Text = " Geri Dön..";
			button10.TextImageRelation = TextImageRelation.ImageBeforeText;
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.Silver;
			groupBox1.Controls.Add(label16);
			groupBox1.Controls.Add(TestEtButton);
			groupBox1.Controls.Add(TestTextBox);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(label14);
			groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(537, 685);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(750, 268);
			groupBox1.TabIndex = 52;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kendiniz test edebilirsiniz:";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label16.Location = new Point(47, 42);
			label16.Name = "label16";
			label16.Size = new Size(652, 21);
			label16.TabIndex = 55;
			label16.Text = "Textbox üzerinde bitleri dilediğiniz gibi değiştirerek sonucu tekrar kontrol edebilirsiniz.";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label11.Location = new Point(107, 419);
			label11.Name = "label11";
			label11.Size = new Size(599, 21);
			label11.TabIndex = 53;
			label11.Text = "Dividend: \"CRC hesaplaması için kullanılacak veri, genellikle mesajın bit dizisi.\"";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label15.Location = new Point(107, 458);
			label15.Name = "label15";
			label15.Size = new Size(563, 21);
			label15.TabIndex = 54;
			label15.Text = "Divisor: \"Seçilen CRC polinomunu temsil eden, sabit uzunluktaki bit dizisi.\"";
			// 
			// CRC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(1805, 991);
			Controls.Add(label15);
			Controls.Add(label11);
			Controls.Add(groupBox1);
			Controls.Add(button10);
			Controls.Add(button5);
			Controls.Add(button3);
			Controls.Add(button1);
			Controls.Add(panel3);
			Controls.Add(panel1);
			Controls.Add(panel2);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(divisorTextBox);
			Controls.Add(dividendTextBox);
			Controls.Add(label1);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "CRC";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "CRC";
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
        private Label label1;
        private TextBox dividendTextBox;
        private TextBox divisorTextBox;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox TestTextBox;
        private Label label12;
        private Label label13;
        private Button TestEtButton;
        private Label label14;
		private Panel panel2;
		private Panel panel1;
		private Panel panel3;
		private PictureBox pictureBox1;
		private Button button1;
		private Button button5;
		private Button button3;
		private Button button10;
		private GroupBox groupBox1;
		private Label label11;
		private Label label15;
		private Label label16;
	}
}