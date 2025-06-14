namespace Ejercicio_12
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
            label1 = new Label();
            textCelsius = new TextBox();
            botonconvertir = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura En Celsius:";
            // 
            // textCelsius
            // 
            textCelsius.Location = new Point(44, 105);
            textCelsius.Name = "textCelsius";
            textCelsius.Size = new Size(100, 23);
            textCelsius.TabIndex = 1;
            // 
            // botonconvertir
            // 
            botonconvertir.Location = new Point(44, 150);
            botonconvertir.Name = "botonconvertir";
            botonconvertir.Size = new Size(75, 23);
            botonconvertir.TabIndex = 2;
            botonconvertir.Text = "Convertir";
            botonconvertir.UseVisualStyleBackColor = true;
            botonconvertir.Click += botonconvertir_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(189, 182);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(labelResultado);
            Controls.Add(botonconvertir);
            Controls.Add(textCelsius);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCelsius;
        private Button botonconvertir;
        private Label labelResultado;
    }
}
