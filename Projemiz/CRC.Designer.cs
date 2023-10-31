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
            button1 = new Button();
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
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(554, 29);
            label2.Name = "label2";
            label2.Size = new Size(631, 89);
            label2.TabIndex = 3;
            label2.Text = "CRC Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(1508, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 4;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 132);
            label1.Name = "label1";
            label1.Size = new Size(1216, 100);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dividendTextBox
            // 
            dividendTextBox.Location = new Point(415, 422);
            dividendTextBox.Name = "dividendTextBox";
            dividendTextBox.Size = new Size(152, 27);
            dividendTextBox.TabIndex = 6;
            dividendTextBox.KeyPress += CRCcs_KeyPress;
            // 
            // divisorTextBox
            // 
            divisorTextBox.Location = new Point(415, 525);
            divisorTextBox.Name = "divisorTextBox";
            divisorTextBox.Size = new Size(152, 27);
            divisorTextBox.TabIndex = 7;
            divisorTextBox.KeyPress += CRCcs_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 422);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Dividend:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 525);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Divisor";
            // 
            // button2
            // 
            button2.Location = new Point(714, 466);
            button2.Name = "button2";
            button2.Size = new Size(136, 45);
            button2.TabIndex = 10;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1056, 373);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 11;
            label5.Text = "CRC Biti :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1272, 373);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 12;
            label6.Text = "Sonuç Burada Görülecektir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1272, 447);
            label7.Name = "label7";
            label7.Size = new Size(184, 20);
            label7.TabIndex = 13;
            label7.Text = "Sonuç Burada Görülecektir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1272, 525);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 14;
            label8.Text = "Sonuç Burada Görülecektir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(978, 451);
            label9.Name = "label9";
            label9.Size = new Size(228, 20);
            label9.TabIndex = 15;
            label9.Text = "CodeWord CRC ile Data Birleşimi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1021, 525);
            label10.Name = "label10";
            label10.Size = new Size(146, 20);
            label10.TabIndex = 16;
            label10.Text = "Hata Kontrol Sonucu";
            // 
            // button3
            // 
            button3.Location = new Point(180, 899);
            button3.Name = "button3";
            button3.Size = new Size(178, 73);
            button3.TabIndex = 17;
            button3.Text = "Geri Dönmek İçin Lütfen Butona Basınız";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // CRC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button3);
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
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "CRC";
            Text = "CRC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
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
        private Button button3;
    }
}