namespace Ejercicio_15
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
            textcontenido = new TextBox();
            botonAbrir = new Button();
            botonGuardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textcontenido
            // 
            textcontenido.Dock = DockStyle.Fill;
            textcontenido.Location = new Point(0, 0);
            textcontenido.Multiline = true;
            textcontenido.Name = "textcontenido";
            textcontenido.ScrollBars = ScrollBars.Both;
            textcontenido.Size = new Size(478, 450);
            textcontenido.TabIndex = 0;
            // 
            // botonAbrir
            // 
            botonAbrir.Location = new Point(17, 46);
            botonAbrir.Name = "botonAbrir";
            botonAbrir.Size = new Size(75, 23);
            botonAbrir.TabIndex = 1;
            botonAbrir.Text = "Abrir Archivo";
            botonAbrir.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(16, 90);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(75, 23);
            botonGuardar.TabIndex = 2;
            botonGuardar.Text = "Guardar Archivo";
            botonGuardar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(botonGuardar);
            Controls.Add(botonAbrir);
            Controls.Add(textcontenido);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textcontenido;
        private Button botonAbrir;
        private Button botonGuardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
