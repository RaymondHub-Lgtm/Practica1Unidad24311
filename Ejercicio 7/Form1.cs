namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string texto = textBoxElemento.Text.Trim();

            if (!string.IsNullOrEmpty(texto))
            {
                listBoxElementos.Items.Add(texto);
                textBoxElemento.Clear();
                textBoxElemento.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un texto antes de agregar.", "Advertencia");
            }
        }
    }
    
}
