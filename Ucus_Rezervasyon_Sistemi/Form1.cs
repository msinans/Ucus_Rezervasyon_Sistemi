namespace Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Ad-Soyad: " +  textBox1.Text + " Yolcu T.C. No: " + maskedTextBox2.Text + " Yolcu Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydý Yapýldý!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            comboBox1.Text = ("");
            comboBox2.Text = ("");
            dateTimePicker1.Text = ("01 Ocak 2000");
            maskedTextBox1.Text = ("");
            maskedTextBox2.Clear();
            maskedTextBox3.Text = ("");
            textBox1.Text = ("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* var sehir = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = sehir; */

            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;


        }
    }
}