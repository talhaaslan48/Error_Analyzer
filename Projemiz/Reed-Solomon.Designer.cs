namespace Projemiz
{
    partial class Reed_Solomon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reed_Solomon));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.QRCodeTextBox = new System.Windows.Forms.TextBox();
			this.DecodedTextBox = new System.Windows.Forms.TextBox();
			this.EncodeButton = new System.Windows.Forms.Button();
			this.DecodeButton = new System.Windows.Forms.Button();
			this.QRCodePictureBox = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(461, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(793, 72);
			this.label2.TabIndex = 6;
			this.label2.Text = "Read-Solomon Algoritması";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1280, 165);
			this.label1.TabIndex = 7;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1379, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(188, 41);
			this.button1.TabIndex = 8;
			this.button1.Text = "PDF İndir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(331, 399);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Input:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(579, 406);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Kodlamak istediğiniz metni giriniz.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(578, 447);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(222, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "QR kodunu girebilir ya da tarayabilirsiniz.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1059, 444);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(337, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = " Kodlama ve düzeltme işlemi sonucu elde edilen veriyi gösterir.";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(398, 397);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(135, 23);
			this.InputTextBox.TabIndex = 13;
			// 
			// QRCodeTextBox
			// 
			this.QRCodeTextBox.Location = new System.Drawing.Point(398, 444);
			this.QRCodeTextBox.Name = "QRCodeTextBox";
			this.QRCodeTextBox.Size = new System.Drawing.Size(135, 23);
			this.QRCodeTextBox.TabIndex = 14;
			// 
			// DecodedTextBox
			// 
			this.DecodedTextBox.Location = new System.Drawing.Point(1059, 397);
			this.DecodedTextBox.Name = "DecodedTextBox";
			this.DecodedTextBox.Size = new System.Drawing.Size(195, 23);
			this.DecodedTextBox.TabIndex = 15;
			// 
			// EncodeButton
			// 
			this.EncodeButton.Location = new System.Drawing.Point(855, 402);
			this.EncodeButton.Name = "EncodeButton";
			this.EncodeButton.Size = new System.Drawing.Size(100, 27);
			this.EncodeButton.TabIndex = 16;
			this.EncodeButton.Text = "Encode";
			this.EncodeButton.UseVisualStyleBackColor = true;
			this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
			// 
			// DecodeButton
			// 
			this.DecodeButton.Location = new System.Drawing.Point(855, 447);
			this.DecodeButton.Name = "DecodeButton";
			this.DecodeButton.Size = new System.Drawing.Size(100, 28);
			this.DecodeButton.TabIndex = 17;
			this.DecodeButton.Text = "Decode";
			this.DecodeButton.UseVisualStyleBackColor = true;
			this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
			// 
			// QRCodePictureBox
			// 
			this.QRCodePictureBox.Location = new System.Drawing.Point(816, 530);
			this.QRCodePictureBox.Name = "QRCodePictureBox";
			this.QRCodePictureBox.Size = new System.Drawing.Size(226, 142);
			this.QRCodePictureBox.TabIndex = 18;
			this.QRCodePictureBox.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(45, 700);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(184, 46);
			this.button2.TabIndex = 19;
			this.button2.Text = "Geri Dönmek İçin Basınız";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Reed_Solomon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1664, 775);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.QRCodePictureBox);
			this.Controls.Add(this.DecodeButton);
			this.Controls.Add(this.EncodeButton);
			this.Controls.Add(this.DecodedTextBox);
			this.Controls.Add(this.QRCodeTextBox);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "Reed_Solomon";
			this.Text = "Reed_Solomon";
			((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label label2;
		private Label label1;
		private Button button1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox InputTextBox;
		private TextBox QRCodeTextBox;
		private TextBox DecodedTextBox;
		private Button EncodeButton;
		private Button DecodeButton;
		private PictureBox QRCodePictureBox;
		private Button button2;
	}
}