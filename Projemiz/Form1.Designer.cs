namespace Projemiz
{
    partial class FormAnaSyf
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSyf));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(9, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(381, 753);
			this.panel1.TabIndex = 0;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(22, 550);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(328, 38);
			this.button7.TabIndex = 6;
			this.button7.Text = "Read-Solomon Algoritması";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(22, 345);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(328, 33);
			this.button4.TabIndex = 5;
			this.button4.Text = "CRC Algoritması";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(22, 413);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(328, 34);
			this.button5.TabIndex = 4;
			this.button5.Text = "FEC Algoritması";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(22, 480);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(328, 36);
			this.button6.TabIndex = 3;
			this.button6.Text = "BCH Algoritması";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(22, 276);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(328, 33);
			this.button3.TabIndex = 2;
			this.button3.Text = "LRC Algoritması";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(328, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Word to Hamming";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(328, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Hamming Algoritmassı";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(729, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(426, 72);
			this.label1.TabIndex = 1;
			this.label1.Text = "ErrorAnalyzer";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(507, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(924, 293);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// FormAnaSyf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1493, 791);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "FormAnaSyf";
			this.Text = "Ana Sayfa";
			this.Load += new System.EventHandler(this.FormAnaSyf_Load_1);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}