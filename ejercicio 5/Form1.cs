namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opci�n 1";
            }
            else if (radioButton2.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opci�n 2";
            }
            else if (radioButton3.Checked)
            {
                labelResultado.Text = "Seleccionaste: Opci�n 3";
            }
            else
            {
                labelResultado.Text = "No se seleccion� ninguna opci�n.";
            }
        }
    }
}
        
    

