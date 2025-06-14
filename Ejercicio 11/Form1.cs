namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonmosrarfecha_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            labelfechaseleccionada.Text = "Fecha seleccionada: " + fechaSeleccionada.ToShortDateString();
        }
    }
}
