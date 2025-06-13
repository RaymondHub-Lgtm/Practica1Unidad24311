namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonsumar_Click(object sender, EventArgs e)
        {
            bool esNumero1 = double.TryParse(textBox1.Text, out double numero1);
            bool esNumero2 = double.TryParse(textBox2.Text, out double numero2);
            if (esNumero1 && esNumero2)
            {
                double resultado = numero1 + numero2;
                labelResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                labelResultado.Text = "Por favor, ingresa números válidos.";

            }
        }

        

        }
}
