namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, height;
            double BaseArea, LateralArea, TotalArea;
            double Volume;

            Radius = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text); 

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * height;
            TotalArea = 2 * Math.PI * Radius * (Radius + height);
            Volume = Math.PI * Radius * Radius * height;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = Volume.ToString("0.##");
        }
    }
}
