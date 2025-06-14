namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonconvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                labelResultado.Text = $"Equivale a: {fahrenheit:F2} °F";
            }
            else
            {
                labelResultado.Text = "Por favor, ingrese un número válido.";
            }
        }
    }
}
