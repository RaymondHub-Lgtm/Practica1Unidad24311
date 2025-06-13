namespace Ejercicio_7
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
            textBoxElemento = new TextBox();
            buttonAgregar = new Button();
            listBoxElementos = new ListBox();
            SuspendLayout();
            // 
            // textBoxElemento
            // 
            textBoxElemento.Location = new Point(60, 73);
            textBoxElemento.Name = "textBoxElemento";
            textBoxElemento.Size = new Size(100, 23);
            textBoxElemento.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(239, 73);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // listBoxElementos
            // 
            listBoxElementos.FormattingEnabled = true;
            listBoxElementos.ItemHeight = 15;
            listBoxElementos.Location = new Point(60, 131);
            listBoxElementos.Name = "listBoxElementos";
            listBoxElementos.Size = new Size(188, 94);
            listBoxElementos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxElementos);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxElemento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxElemento;
        private Button buttonAgregar;
        private ListBox listBoxElementos;
    }
}
