namespace Projemiz
{
    partial class Reed_Solomon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reed_Solomon));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(461, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(793, 72);
			this.label2.TabIndex = 6;
			this.label2.Text = "Read-Solomon Algoritması";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1013, 75);
			this.label1.TabIndex = 7;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// Reed_Solomon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1664, 775);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "Reed_Solomon";
			this.Text = "Reed_Solomon";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label label2;
		private Label label1;
	}
}