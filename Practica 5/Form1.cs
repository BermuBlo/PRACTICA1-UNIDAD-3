using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores desde los TextBox
                double baseTriangulo = double.Parse(textBoxBase.Text);
                double alturaTriangulo = double.Parse(textBoxAltura.Text);

                // Calcular �rea
                double area = (baseTriangulo * alturaTriangulo) / 2;

                // Mostrar resultado
                labelResultado.Text = "�rea del tri�ngulo: " + area.ToString("0.##");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa n�meros v�lidos para base y altura.");
            }
        }
    }
    
}
