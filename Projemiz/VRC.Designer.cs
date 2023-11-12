namespace Projemiz
{
    partial class VRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRC));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1532, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 5;
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
            label2.Size = new Size(627, 89);
            label2.TabIndex = 6;
            label2.Text = "VRC Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 133);
            label1.Name = "label1";
            label1.Size = new Size(1141, 100);
            label1.TabIndex = 7;
            label1.Text = resources.GetString("label1.Text");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(359, 316);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += VRCcs_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 323);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 9;
            label3.Text = "Gönderilen Veri :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 389);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "VRC Biti :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 469);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 11;
            label5.Text = "Data Transmitted:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(359, 389);
            label6.Name = "label6";
            label6.Size = new Size(228, 20);
            label6.TabIndex = 12;
            label6.Text = "Sonuç Burada Görüntülenecektir :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 469);
            label7.Name = "label7";
            label7.Size = new Size(228, 20);
            label7.TabIndex = 13;
            label7.Text = "Sonuç Burada Görüntülenecektir :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1094, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 14;
            textBox2.KeyPress += VRCcs_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(945, 319);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 15;
            label8.Text = "Alınan Veri :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(935, 409);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 16;
            label9.Text = "Hata Analizi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1094, 409);
            label10.Name = "label10";
            label10.Size = new Size(228, 20);
            label10.TabIndex = 17;
            label10.Text = "Sonuç Burada Görüntülenecektir :";
            // 
            // button2
            // 
            button2.Location = new Point(359, 551);
            button2.Name = "button2";
            button2.Size = new Size(215, 61);
            button2.TabIndex = 18;
            button2.Text = "Kontrol ET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1026, 551);
            button3.Name = "button3";
            button3.Size = new Size(215, 61);
            button3.TabIndex = 19;
            button3.Text = "Hata Analiz ET";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // VRC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "VRC";
            Text = "VRC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
        private Button button3;
    }
}