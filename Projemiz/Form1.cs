namespace Projemiz
{
    public partial class FormAnaSyf : Form
    {
        public FormAnaSyf()
        {
            InitializeComponent();
        }


     

        private void FormAnaSyf_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }


        private void FormAnaSyf_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hamming form1 = new Hamming();
            form1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WordToHamming form2 = new WordToHamming();
            form2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LRCcs form3 = new LRCcs();
            form3.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CRC form4 = new CRC();
            form4.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FEC form5 = new FEC();
            form5.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BCH form6 = new BCH();
            form6.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Reed_Solomon form7 = new Reed_Solomon();
            form7.Show();
            this.Hide();
        }
    }
}