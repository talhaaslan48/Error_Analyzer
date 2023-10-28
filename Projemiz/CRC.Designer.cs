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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dividendTextBox = new TextBox();
            divisorTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1508, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 4;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(554, 29);
            label2.Name = "label2";
            label2.Size = new Size(631, 89);
            label2.TabIndex = 5;
            label2.Text = "CRC Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 132);
            label1.Name = "label1";
            label1.Size = new Size(1270, 100);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button3
            // 
            button3.Location = new Point(78, 954);
            button3.Name = "button3";
            button3.Size = new Size(182, 54);
            button3.TabIndex = 13;
            button3.Text = "Geri Dönmek İçin Basınız";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dividendTextBox
            // 
            dividendTextBox.Location = new Point(545, 371);
            dividendTextBox.Name = "dividendTextBox";
            dividendTextBox.Size = new Size(227, 27);
            dividendTextBox.TabIndex = 14;
            dividendTextBox.KeyPress += CRCcs_KeyPress;
            // 
            // divisorTextBox
            // 
            divisorTextBox.Location = new Point(545, 474);
            divisorTextBox.Name = "divisorTextBox";
            divisorTextBox.Size = new Size(227, 27);
            divisorTextBox.TabIndex = 15;
            divisorTextBox.KeyPress += CRCcs_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 371);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 16;
            label3.Text = "Dividend :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 474);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 17;
            label4.Text = "Divisor :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1066, 325);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 18;
            label5.Text = "CRC Biti";
            // 
            // button2
            // 
            button2.Location = new Point(663, 564);
            button2.Name = "button2";
            button2.Size = new Size(196, 44);
            button2.TabIndex = 19;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1185, 325);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 20;
            label6.Text = "Sonuç Burada Görülecektir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1185, 421);
            label7.Name = "label7";
            label7.Size = new Size(184, 20);
            label7.TabIndex = 21;
            label7.Text = "Sonuç Burada Görülecektir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1566, 576);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 22;
            label8.Text = "Sonuç Burada Görülecektir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(968, 421);
            label9.Name = "label9";
            label9.Size = new Size(160, 40);
            label9.TabIndex = 23;
            label9.Text = "CRC Biti Eklenmiş Data\r\n(CodeWord)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1196, 568);
            label10.Name = "label10";
            label10.Size = new Size(325, 40);
            label10.TabIndex = 24;
            label10.Text = "Hata Kontrolü \r\nCodeWord ile Data Transmitted Karşılaştırılması";
            // 
            // CRC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(divisorTextBox);
            Controls.Add(dividendTextBox);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "CRC";
            Text = "CRC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox dividendTextBox;
        private TextBox divisorTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}