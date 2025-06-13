namespace ejercicio_8
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
            botoncontador = new Button();
            labelcontador = new Label();
            SuspendLayout();
            // 
            // botoncontador
            // 
            botoncontador.Location = new Point(36, 72);
            botoncontador.Name = "botoncontador";
            botoncontador.Size = new Size(75, 23);
            botoncontador.TabIndex = 0;
            botoncontador.Text = "Haz Click Aqui";
            botoncontador.UseVisualStyleBackColor = true;
            botoncontador.Click += botoncontador_Click;
            // 
            // labelcontador
            // 
            labelcontador.AutoSize = true;
            labelcontador.Location = new Point(36, 164);
            labelcontador.Name = "labelcontador";
            labelcontador.Size = new Size(108, 15);
            labelcontador.TabIndex = 1;
            labelcontador.Text = "Precionado 0 Veces";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 371);
            Controls.Add(labelcontador);
            Controls.Add(botoncontador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botoncontador;
        private Label labelcontador;
    }
}
