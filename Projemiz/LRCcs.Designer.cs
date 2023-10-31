namespace Projemiz
{
    partial class LRCcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LRCcs));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            buttonYenile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 132);
            label1.Name = "label1";
            label1.Size = new Size(1216, 100);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(554, 29);
            label2.Name = "label2";
            label2.Size = new Size(612, 89);
            label2.TabIndex = 2;
            label2.Text = "LRC Algoritması\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(1508, 143);
            button1.Name = "button1";
            button1.Size = new Size(295, 68);
            button1.TabIndex = 3;
            button1.Text = "PDF İndir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 351);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += LRCcs_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 351);
            textBox2.MaxLength = 8;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += LRCcs_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(519, 351);
            textBox3.MaxLength = 8;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += LRCcs_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(670, 351);
            textBox4.MaxLength = 8;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyPress += LRCcs_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 305);
            label3.Name = "label3";
            label3.Size = new Size(390, 20);
            label3.TabIndex = 8;
            label3.Text = "Lütfen Her Kutuya 8 bitlik binary sayınızı yazınız . ( 0 ve 1 )";
            // 
            // button2
            // 
            button2.Location = new Point(389, 407);
            button2.Name = "button2";
            button2.Size = new Size(206, 39);
            button2.TabIndex = 9;
            button2.Text = "LRC Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(175, 700);
            label4.Name = "label4";
            label4.Size = new Size(162, 38);
            label4.TabIndex = 11;
            label4.Text = "LRC Sonuç :";
            // 
            // button3
            // 
            button3.Location = new Point(78, 954);
            button3.Name = "button3";
            button3.Size = new Size(182, 54);
            button3.TabIndex = 12;
            button3.Text = "Geri Dönmek İçin Basınız";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Location = new Point(1058, 351);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(330, 207);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(317, 700);
            label5.Name = "label5";
            label5.Size = new Size(0, 38);
            label5.TabIndex = 13;
            // 
            // buttonYenile
            // 
            buttonYenile.Location = new Point(163, 769);
            buttonYenile.Name = "buttonYenile";
            buttonYenile.Size = new Size(206, 60);
            buttonYenile.TabIndex = 14;
            buttonYenile.Text = "Tekrar İşlem Yapmak İçin Basınız";
            buttonYenile.UseVisualStyleBackColor = true;
            buttonYenile.Click += buttonYenile_Click;
            // 
            // LRCcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonYenile);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LRCcs";
            Text = "LRCcs";
            TopMost = true;
            Load += LRCcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Button buttonYenile;
    }
}