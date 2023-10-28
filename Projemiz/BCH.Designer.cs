namespace Projemiz
{
    partial class BCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCH));
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            originalTextBox = new TextBox();
            encodedTextBox = new TextBox();
            receivedTextBox = new TextBox();
            decodedTextBox = new TextBox();
            encodeButton = new Button();
            decodeButton = new Button();
            resultLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ResultLabel1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(554, 29);
            label2.Name = "label2";
            label2.Size = new Size(625, 89);
            label2.TabIndex = 6;
            label2.Text = "BCH Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(1508, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 7;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 132);
            label1.Name = "label1";
            label1.Size = new Size(1267, 120);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // originalTextBox
            // 
            originalTextBox.Location = new Point(339, 419);
            originalTextBox.Name = "originalTextBox";
            originalTextBox.Size = new Size(125, 27);
            originalTextBox.TabIndex = 10;
            // 
            // encodedTextBox
            // 
            encodedTextBox.Location = new Point(339, 525);
            encodedTextBox.Name = "encodedTextBox";
            encodedTextBox.Size = new Size(125, 27);
            encodedTextBox.TabIndex = 11;
            // 
            // receivedTextBox
            // 
            receivedTextBox.Location = new Point(721, 419);
            receivedTextBox.Name = "receivedTextBox";
            receivedTextBox.Size = new Size(125, 27);
            receivedTextBox.TabIndex = 12;
            // 
            // decodedTextBox
            // 
            decodedTextBox.Location = new Point(721, 522);
            decodedTextBox.Name = "decodedTextBox";
            decodedTextBox.Size = new Size(125, 27);
            decodedTextBox.TabIndex = 13;
            // 
            // encodeButton
            // 
            encodeButton.Location = new Point(397, 604);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(94, 29);
            encodeButton.TabIndex = 14;
            encodeButton.Text = "button2";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += encodeButton_Click;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(647, 604);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(94, 29);
            decodeButton.TabIndex = 15;
            decodeButton.Text = "button3";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += decodeButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(1019, 449);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(50, 20);
            resultLabel.TabIndex = 16;
            resultLabel.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 419);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 17;
            label3.Text = " originalData";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 525);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 18;
            label4.Text = "encodedData";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 422);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 19;
            label5.Text = "receivedData";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 525);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 20;
            label6.Text = " decodedData";
            // 
            // ResultLabel1
            // 
            ResultLabel1.AutoSize = true;
            ResultLabel1.Location = new Point(1262, 449);
            ResultLabel1.Name = "ResultLabel1";
            ResultLabel1.Size = new Size(50, 20);
            ResultLabel1.TabIndex = 21;
            ResultLabel1.Text = "label3";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "7 - 4", "8 - 4", "15 - 11", "16 - 11", "31 - 26", "32 - 26" });
            comboBox2.Location = new Point(262, 291);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 22;
            // 
            // BCH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(comboBox2);
            Controls.Add(ResultLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(resultLabel);
            Controls.Add(decodeButton);
            Controls.Add(encodeButton);
            Controls.Add(decodedTextBox);
            Controls.Add(receivedTextBox);
            Controls.Add(encodedTextBox);
            Controls.Add(originalTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "BCH";
            Text = "BCH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox originalTextBox;
        private TextBox encodedTextBox;
        private TextBox receivedTextBox;
        private TextBox decodedTextBox;
        private Button encodeButton;
        private Button decodeButton;
        private Label resultLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label ResultLabel1;
        private ComboBox comboBox2;
    }
}