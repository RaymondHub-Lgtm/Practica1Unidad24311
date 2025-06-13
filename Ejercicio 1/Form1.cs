namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombre = "Raymond Jimenez";
            string matricula = "LR-2024-01392";
            label1.Text = $"¡Bienvenido al formulario de {nombre} y {matricula}!";
        }
        }
    }

