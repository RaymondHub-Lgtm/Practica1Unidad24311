namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColores.Items.Add("Rojo");
            comboBoxColores.Items.Add("Verde");
            comboBoxColores.Items.Add("Azul");
        }

        private void comboBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string colorSeleccionado = comboBoxColores.SelectedItem.ToString();

                switch (colorSeleccionado)
                {
                    case "Rojo":
                        this.BackColor = Color.Red;
                        break;
                    case "Verde":
                        this.BackColor = Color.Green;
                        break;
                    case "Azul":
                        this.BackColor = Color.Blue;
                        break;
                }
            }
        }
    }
}
