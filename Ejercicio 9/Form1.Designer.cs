namespace Ejercicio_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextoEntrada = new TextBox();
            botonValidar = new Button();
            labelresultado = new Label();
            Resultado = new Label();
            SuspendLayout();
            // 
            // TextoEntrada
            // 
            TextoEntrada.Location = new Point(33, 59);
            TextoEntrada.Name = "TextoEntrada";
            TextoEntrada.Size = new Size(100, 23);
            TextoEntrada.TabIndex = 0;
            // 
            // botonValidar
            // 
            botonValidar.Location = new Point(33, 107);
            botonValidar.Name = "botonValidar";
            botonValidar.Size = new Size(75, 23);
            botonValidar.TabIndex = 1;
            botonValidar.Text = "Validar Numero";
            botonValidar.UseVisualStyleBackColor = true;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(189, 59);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 15);
            labelresultado.TabIndex = 2;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(179, 65);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(0, 15);
            Resultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(Resultado);
            Controls.Add(labelresultado);
            Controls.Add(botonValidar);
            Controls.Add(TextoEntrada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextoEntrada;
        private Button botonValidar;
        private Label labelresultado;
        private Label Resultado;
    }
}
