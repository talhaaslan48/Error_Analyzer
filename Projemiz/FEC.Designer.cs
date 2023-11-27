namespace Projemiz
{
    partial class FEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEC));
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            txtInputData = new TextBox();
            txtRandomBits = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label23 = new Label();
            label24 = new Label();
            btnCheckErrors = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(485, 22);
            label2.Name = "label2";
            label2.Size = new Size(491, 72);
            label2.TabIndex = 4;
            label2.Text = "FEC Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(1340, 107);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(258, 51);
            button1.TabIndex = 5;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 107);
            label1.Name = "label1";
            label1.Size = new Size(1171, 75);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button3
            // 
            button3.Location = new Point(58, 689);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(156, 55);
            button3.TabIndex = 18;
            button3.Text = "Geri Dönmek İçin Lütfen Butona Basınız";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // txtInputData
            // 
            txtInputData.Location = new Point(201, 260);
            txtInputData.Margin = new Padding(3, 2, 3, 2);
            txtInputData.Name = "txtInputData";
            txtInputData.Size = new Size(206, 23);
            txtInputData.TabIndex = 19;
            // 
            // txtRandomBits
            // 
            txtRandomBits.Location = new Point(814, 260);
            txtRandomBits.Margin = new Padding(3, 2, 3, 2);
            txtRandomBits.Name = "txtRandomBits";
            txtRandomBits.Size = new Size(351, 23);
            txtRandomBits.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 263);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 21;
            label3.Text = "Gönderilen Veri :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 262);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 22;
            label4.Text = "Alınan Veri :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 389);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 23;
            label5.Text = "Encoded_Bit_Sequences";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 389);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 24;
            label6.Text = "Corresponding_CodeWord";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(115, 428);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 25;
            label7.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 469);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 26;
            label8.Text = "01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(115, 506);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 27;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 541);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 28;
            label10.Text = "11";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(296, 428);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(37, 15);
            label11.TabIndex = 29;
            label11.Text = "00000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(296, 469);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 30;
            label12.Text = "11100";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(296, 506);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 31;
            label13.Text = "10011";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(296, 541);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 32;
            label14.Text = "01111";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(214, 428);
            label15.Name = "label15";
            label15.Size = new Size(30, 15);
            label15.TabIndex = 33;
            label15.Text = "--->";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(214, 469);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 34;
            label16.Text = "--->";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(214, 506);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 35;
            label17.Text = "--->";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(214, 541);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 36;
            label18.Text = "--->";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(609, 376);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 41;
            label23.Text = "Sonuç :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(723, 376);
            label24.Name = "label24";
            label24.Size = new Size(0, 15);
            label24.TabIndex = 42;
            // 
            // btnCheckErrors
            // 
            btnCheckErrors.Location = new Point(539, 260);
            btnCheckErrors.Margin = new Padding(3, 2, 3, 2);
            btnCheckErrors.Name = "btnCheckErrors";
            btnCheckErrors.Size = new Size(82, 22);
            btnCheckErrors.TabIndex = 43;
            btnCheckErrors.Text = "Hesapla";
            btnCheckErrors.UseVisualStyleBackColor = true;
            btnCheckErrors.Click += btnCheckErrors_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(717, 376);
            listBoxResults.Margin = new Padding(3, 2, 3, 2);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(746, 304);
            listBoxResults.TabIndex = 44;
            // 
            // FEC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(listBoxResults);
            Controls.Add(btnCheckErrors);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRandomBits);
            Controls.Add(txtInputData);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FEC";
            Text = "FEC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Label label1;
        private Button button3;
        private TextBox txtInputData;
        private TextBox txtRandomBits;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label23;
        private Label label24;
        private Button btnCheckErrors;
        private ListBox listBoxResults;
    }
}