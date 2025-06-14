namespace Ejercicio_11
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
            dateTimePicker1 = new DateTimePicker();
            botonmosrarfecha = new Button();
            labelfechaseleccionada = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(46, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // botonmosrarfecha
            // 
            botonmosrarfecha.Location = new Point(49, 137);
            botonmosrarfecha.Name = "botonmosrarfecha";
            botonmosrarfecha.Size = new Size(75, 23);
            botonmosrarfecha.TabIndex = 1;
            botonmosrarfecha.Text = "Mostrar Fecha";
            botonmosrarfecha.UseVisualStyleBackColor = true;
            botonmosrarfecha.Click += botonmosrarfecha_Click;
            // 
            // labelfechaseleccionada
            // 
            labelfechaseleccionada.AutoSize = true;
            labelfechaseleccionada.Location = new Point(185, 141);
            labelfechaseleccionada.Name = "labelfechaseleccionada";
            labelfechaseleccionada.Size = new Size(38, 15);
            labelfechaseleccionada.TabIndex = 2;
            labelfechaseleccionada.Text = "Fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelfechaseleccionada);
            Controls.Add(botonmosrarfecha);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button botonmosrarfecha;
        private Label labelfechaseleccionada;
    }
}
