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
			this.label2 = new System.Windows.Forms.Label();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(558, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(575, 72);
			this.label2.TabIndex = 7;
			this.label2.Text = "Word To Hamming";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(370, 329);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(166, 23);
			this.InputTextBox.TabIndex = 8;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Location = new System.Drawing.Point(793, 329);
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.Size = new System.Drawing.Size(165, 23);
			this.ResultTextBox.TabIndex = 9;
			// 
			// WordToHamming
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1664, 775);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.label2);
			this.Name = "WordToHamming";
			this.Text = "WordToHamming";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label label2;
		private TextBox InputTextBox;
		private TextBox ResultTextBox;
	}
}