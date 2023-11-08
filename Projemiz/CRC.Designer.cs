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
            label11 = new Label();
            TestTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            TestEtButton = new Button();
            label14 = new Label();
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
            button1.Location = new Point(1532, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 4;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
           
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 134);
            label1.Name = "label1";
            label1.Size = new Size(1465, 140);
            label1.TabIndex = 5;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dividendTextBox
            // 
            dividendTextBox.Location = new Point(251, 411);
            dividendTextBox.Name = "dividendTextBox";
            dividendTextBox.Size = new Size(153, 27);
            dividendTextBox.TabIndex = 6;
            // 
            // divisorTextBox
            // 
            divisorTextBox.Location = new Point(251, 519);
            divisorTextBox.Name = "divisorTextBox";
            divisorTextBox.Size = new Size(153, 27);
            divisorTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 417);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Dividend:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 521);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 9;
            label4.Text = "Divisor:";
            // 
            // button2
            // 
            button2.Location = new Point(551, 463);
            button2.Name = "button2";
            button2.Size = new Size(136, 45);
            button2.TabIndex = 10;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(930, 456);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 11;
            label5.Text = "CRC Biti :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1019, 456);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 12;
            label6.Text = "Sonuç Burada Görülecektir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1019, 529);
            label7.Name = "label7";
            label7.Size = new Size(184, 20);
            label7.TabIndex = 13;
            label7.Text = "Sonuç Burada Görülecektir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1019, 620);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 14;
            label8.Text = "Sonuç Burada Görülecektir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(782, 529);
            label9.Name = "label9";
            label9.Size = new Size(235, 20);
            label9.TabIndex = 15;
            label9.Text = "CodeWord CRC ile Data Birleşimi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(854, 620);
            label10.Name = "label10";
            label10.Size = new Size(153, 20);
            label10.TabIndex = 16;
            label10.Text = "Hata Kontrol Sonucu :";
            // 
            // button3
            // 
            button3.Location = new Point(66, 919);
            button3.Name = "button3";
            button3.Size = new Size(178, 73);
            button3.TabIndex = 17;
            button3.Text = "Geri Dönmek İçin Lütfen Butona Basınız";
            button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1317, 385);
            label11.Name = "label11";
            label11.Size = new Size(206, 23);
            label11.TabIndex = 18;
            label11.Text = "Kendiniz test edebilirsiniz:";
            // 
            // TestTextBox
            // 
            TestTextBox.Location = new Point(1317, 445);
            TestTextBox.Margin = new Padding(3, 4, 3, 4);
            TestTextBox.Name = "TestTextBox";
            TestTextBox.Size = new Size(251, 27);
            TestTextBox.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1320, 620);
            label12.Name = "label12";
            label12.Size = new Size(153, 20);
            label12.TabIndex = 20;
            label12.Text = "Hata Kontrol Sonucu :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1482, 620);
            label13.Name = "label13";
            label13.Size = new Size(184, 20);
            label13.TabIndex = 21;
            label13.Text = "Sonuç Burada Görülecektir";
            // 
            // TestEtButton
            // 
            TestEtButton.Location = new Point(1317, 529);
            TestEtButton.Margin = new Padding(3, 4, 3, 4);
            TestEtButton.Name = "TestEtButton";
            TestEtButton.Size = new Size(160, 39);
            TestEtButton.TabIndex = 22;
            TestEtButton.Text = "Test Et";
            TestEtButton.UseVisualStyleBackColor = true;
            TestEtButton.Click += TestEtButton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1320, 423);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 23;
            // 
            // CRC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label14);
            Controls.Add(TestEtButton);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(TestTextBox);
            Controls.Add(label11);
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
        private Label label11;
        private TextBox TestTextBox;
        private Label label12;
        private Label label13;
        private Button TestEtButton;
        private Label label14;
    }
}