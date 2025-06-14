namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog1.FileName;
                textcontenido.Text = File.ReadAllText(rutaArchivo);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog1.FileName;
                File.WriteAllText(rutaArchivo, textcontenido.Text);
                MessageBox.Show("Archivo guardado exitosamente.", "Éxito");
            }
        }
    }
    
}
