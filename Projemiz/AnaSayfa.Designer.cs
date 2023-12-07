namespace Projemiz
{
    partial class FormAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
			panel1 = new Panel();
			button7 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button3 = new Button();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			button2 = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button4);
			panel1.Controls.Add(button5);
			panel1.Controls.Add(button6);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button1);
			panel1.Location = new Point(9, 7);
			panel1.Name = "panel1";
			panel1.Size = new Size(381, 753);
			panel1.TabIndex = 0;
			// 
			// button7
			// 
			button7.Location = new Point(22, 506);
			button7.Name = "button7";
			button7.Size = new Size(328, 38);
			button7.TabIndex = 6;
			button7.Text = "Read-Solomon Algoritması";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button4
			// 
			button4.Location = new Point(22, 301);
			button4.Name = "button4";
			button4.Size = new Size(328, 33);
			button4.TabIndex = 5;
			button4.Text = "CRC Algoritması";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(22, 369);
			button5.Name = "button5";
			button5.Size = new Size(328, 34);
			button5.TabIndex = 4;
			button5.Text = "FEC Algoritması";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Location = new Point(22, 436);
			button6.Name = "button6";
			button6.Size = new Size(328, 36);
			button6.TabIndex = 3;
			button6.Text = "VRC Algoritması";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button3
			// 
			button3.Location = new Point(22, 232);
			button3.Name = "button3";
			button3.Size = new Size(328, 33);
			button3.TabIndex = 2;
			button3.Text = "LRC Algoritması";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(22, 118);
			button1.Name = "button1";
			button1.Size = new Size(328, 34);
			button1.TabIndex = 0;
			button1.Text = "Hamming Algoritmassı";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(729, 21);
			label1.Name = "label1";
			label1.Size = new Size(426, 72);
			label1.TabIndex = 1;
			label1.Text = "ErrorAnalyzer";
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(507, 283);
			label2.Name = "label2";
			label2.Size = new Size(924, 293);
			label2.TabIndex = 2;
			label2.Text = resources.GetString("label2.Text");
			// 
			// button2
			// 
			button2.Location = new Point(22, 175);
			button2.Name = "button2";
			button2.Size = new Size(328, 34);
			button2.TabIndex = 7;
			button2.Text = "Hamming Algoritması 7.4";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// FormAnaSayfa
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1664, 791);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(panel1);
			Name = "FormAnaSayfa";
			Text = "Ana Sayfa";
			WindowState = FormWindowState.Maximized;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button1;
        private Label label1;
        private Label label2;
		private Button button2;
	}
}