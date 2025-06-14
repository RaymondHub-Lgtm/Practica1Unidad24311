namespace Ejercicio_16
{
    public partial class Form1 : Form

    {
        string operacion = "";
        double numero1 = 0;
        bool nuevaOperacion = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                textPantalla.Text = "";
                nuevaOperacion = false;
            }

            Button btn = (Button)sender;
            textPantalla.Text += btn.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            numero1 = double.Parse(textPantalla.Text);
            nuevaOperacion = true;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            numero1 = double.Parse(textPantalla.Text);
            nuevaOperacion = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            numero1 = double.Parse(textPantalla.Text);
            nuevaOperacion = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operacion = btn.Text;
            numero1 = double.Parse(textPantalla.Text);
            nuevaOperacion = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero2 = double.Parse(textPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    break;
            }

            textPantalla.Text = resultado.ToString();
            nuevaOperacion = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textPantalla.Text = "";
            numero1 = 0;
            operacion = "";
        }
    }
}
