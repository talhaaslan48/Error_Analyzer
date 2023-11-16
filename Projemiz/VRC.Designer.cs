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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonYenile = new Button();
            label5 = new Label();
            button3 = new Button();
            label4 = new Label();
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(649, 322);
            label9.Name = "label9";
            label9.Size = new Size(28, 38);
            label9.TabIndex = 26;
            label9.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(484, 322);
            label8.Name = "label8";
            label8.Size = new Size(28, 38);
            label8.TabIndex = 25;
            label8.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(319, 322);
            label7.Name = "label7";
            label7.Size = new Size(28, 38);
            label7.TabIndex = 24;
            label7.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 287);
            label3.Name = "label3";
            label3.Size = new Size(390, 20);
            label3.TabIndex = 23;
            label3.Text = "Lütfen Her Kutuya 8 bitlik binary sayınızı yazınız . ( 0 ve 1 )";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(683, 333);
            textBox4.MaxLength = 8;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += VRCcs_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(518, 333);
            textBox3.MaxLength = 8;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += VRCcs_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 333);
            textBox2.MaxLength = 8;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += VRCcs_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 333);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += VRCcs_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(353, 416);
            button2.Name = "button2";
            button2.Size = new Size(206, 39);
            button2.TabIndex = 27;
            button2.Text = "LRC Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(906, 556);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 29;
            label6.Text = "LRC Kodu :";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(1037, 377);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(330, 207);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // buttonYenile
            // 
            buttonYenile.Location = new Point(185, 760);
            buttonYenile.Name = "buttonYenile";
            buttonYenile.Size = new Size(206, 60);
            buttonYenile.TabIndex = 33;
            buttonYenile.Text = "Tekrar İşlem Yapmak İçin Basınız";
            buttonYenile.UseVisualStyleBackColor = true;
            buttonYenile.Click += buttonYenile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 691);
            label5.Name = "label5";
            label5.Size = new Size(0, 38);
            label5.TabIndex = 32;
            // 
            // button3
            // 
            button3.Location = new Point(100, 945);
            button3.Name = "button3";
            button3.Size = new Size(182, 54);
            button3.TabIndex = 31;
            button3.Text = "Geri Dönmek İçin Basınız";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(197, 691);
            label4.Name = "label4";
            label4.Size = new Size(162, 38);
            label4.TabIndex = 30;
            label4.Text = "LRC Sonuç :";
            // 
            // VRC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonYenile);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonYenile;
        private Label label5;
        private Button button3;
        private Label label4;
    }
}