namespace ejercicio_8
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void botoncontador_Click(object sender, EventArgs e)
        {
            contador++;
            labelcontador.Text = $"Presionado {contador} veces";
        }
    }
}
