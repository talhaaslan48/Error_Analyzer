namespace Projemiz
{
    public partial class FormAnaSyf : Form
    {
        public FormAnaSyf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hamming form1 = new Hamming();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAnaSyf_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WordToHamming form2 = new WordToHamming();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LRCcs form3 = new LRCcs();
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRC form4 = new CRC();
            form4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FEC form5 = new FEC();
            form5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BCH form6 = new BCH();
            form6.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reed_Solomon form7 = new Reed_Solomon();
            form7.Show();
            this.Hide();
        }
    }
}