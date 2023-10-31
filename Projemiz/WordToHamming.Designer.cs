namespace Projemiz
{
    partial class WordToHamming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordToHamming));
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            txtInput = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(638, 12);
            label2.Name = "label2";
            label2.Size = new Size(720, 89);
            label2.TabIndex = 7;
            label2.Text = "Word To Hamming";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 143);
            label1.Name = "label1";
            label1.Size = new Size(1139, 60);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            button1.Location = new Point(1508, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 9;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(78, 954);
            button3.Name = "button3";
            button3.Size = new Size(182, 54);
            button3.TabIndex = 13;
            button3.Text = "Geri Dönmek İçin Basınız";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(365, 343);
            txtInput.MaxLength = 8;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 14;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(661, 441);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(206, 39);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "LRC Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // WordToHamming
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnCalculate);
            Controls.Add(txtInput);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WordToHamming";
            Text = "WordToHamming";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private TextBox txtInput;
        private Button btnCalculate;
    }
}