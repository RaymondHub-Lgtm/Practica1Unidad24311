namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (double.TryParse(TextoEntrada.Text, out double numero))
            {
               Resultado.Text = $"Entrada v�lida: {numero}";
                Resultado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un n�mero v�lido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Resultado.Text = "Entrada no v�lida.";
                Resultado.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
        
