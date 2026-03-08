namespace TP_MODUL3_103022400073
{
    public partial class Form1 : Form
    {

        int angka1 = 0;
        int angka2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tampilkanAngka(string angka)
        {
            output.Text += angka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            string[] parts = output.Text.Split(new string[] { " + " }, StringSplitOptions.None);
            string lastNumber = parts[parts.Length - 1];

            angka1 += int.Parse(lastNumber);

            output.Text += " + ";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string[] parts = output.Text.Split(new string[] { " + " }, StringSplitOptions.None);
            if (parts.Length > 1)
            {
                angka2 = int.Parse(parts[parts.Length - 1]);
                angka1 += angka2;
            }
            output.Text = angka1.ToString();
            angka1 = 0;
        }
    }
}
