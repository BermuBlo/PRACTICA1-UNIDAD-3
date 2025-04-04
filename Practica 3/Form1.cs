namespace Practica_3
{
    public partial class SumarNumeros : Form
    {
        public SumarNumeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int suma = num1 + num2;
            label3.Text = "Sum = " + suma;
        }

        
    }
}
