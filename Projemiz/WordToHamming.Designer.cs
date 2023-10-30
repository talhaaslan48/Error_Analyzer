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
			this.GirdiMetnitxt = new System.Windows.Forms.TextBox();
			this.HammingKodutxt = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
			// GirdiMetnitxt
			// 
			this.GirdiMetnitxt.Location = new System.Drawing.Point(353, 291);
			this.GirdiMetnitxt.Name = "GirdiMetnitxt";
			this.GirdiMetnitxt.Size = new System.Drawing.Size(169, 23);
			this.GirdiMetnitxt.TabIndex = 8;
			// 
			// HammingKodutxt
			// 
			this.HammingKodutxt.Location = new System.Drawing.Point(731, 291);
			this.HammingKodutxt.Name = "HammingKodutxt";
			this.HammingKodutxt.Size = new System.Drawing.Size(204, 23);
			this.HammingKodutxt.TabIndex = 9;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(571, 291);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(91, 23);
			this.btnCalculate.TabIndex = 10;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(274, 295);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Input:";
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(991, 291);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(529, 171);
			this.dataGridView.TabIndex = 12;
			// 
			// WordToHamming
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1664, 775);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.HammingKodutxt);
			this.Controls.Add(this.GirdiMetnitxt);
			this.Controls.Add(this.label2);
			this.Name = "WordToHamming";
			this.Text = "WordToHamming";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Label label2;
		private TextBox GirdiMetnitxt;
		private TextBox HammingKodutxt;
		private Button btnCalculate;
		private Label label1;
		private DataGridView dataGridView;
	}
}