namespace Practica_2
{
    public partial class InvertirNumeros : Form
    {
        public InvertirNumeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);
            label5.Text = d.ToString();
            label6.Text = c.ToString();
            label7.Text = b.ToString();
            label8.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
