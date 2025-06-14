namespace Ejercicio_13
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            botonniniciar = new Button();
            botondetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(41, 73);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 0;
            // 
            // botonniniciar
            // 
            botonniniciar.Location = new Point(43, 136);
            botonniniciar.Name = "botonniniciar";
            botonniniciar.Size = new Size(75, 23);
            botonniniciar.TabIndex = 1;
            botonniniciar.Text = "Iniciar";
            botonniniciar.UseVisualStyleBackColor = true;
            botonniniciar.Click += botonniniciar_Click;
            // 
            // botondetener
            // 
            botondetener.Location = new Point(159, 136);
            botondetener.Name = "botondetener";
            botondetener.Size = new Size(75, 23);
            botondetener.TabIndex = 2;
            botondetener.Text = "Detener";
            botondetener.UseVisualStyleBackColor = true;
            botondetener.Click += botondetener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 249);
            Controls.Add(botondetener);
            Controls.Add(botonniniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button botonniniciar;
        private Button botondetener;
        private System.Windows.Forms.Timer timer1;
    }
}
