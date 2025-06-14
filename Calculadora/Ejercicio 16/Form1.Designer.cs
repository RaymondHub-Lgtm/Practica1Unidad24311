namespace Ejercicio_16
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
            textPantalla = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnpnt = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // textPantalla
            // 
            textPantalla.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPantalla.Location = new Point(10, 12);
            textPantalla.Name = "textPantalla";
            textPantalla.ReadOnly = true;
            textPantalla.Size = new Size(208, 46);
            textPantalla.TabIndex = 0;
            textPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Location = new Point(10, 124);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 39);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(61, 124);
            btn2.Name = "btn2";
            btn2.Size = new Size(48, 39);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(115, 124);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 39);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(10, 169);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 40);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(61, 169);
            btn5.Name = "btn5";
            btn5.Size = new Size(48, 40);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(115, 169);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 40);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(10, 215);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 40);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(61, 215);
            btn8.Name = "btn8";
            btn8.Size = new Size(48, 40);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(115, 215);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 40);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(10, 261);
            btn0.Name = "btn0";
            btn0.Size = new Size(99, 29);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnpnt
            // 
            btnpnt.Location = new Point(115, 261);
            btnpnt.Name = "btnpnt";
            btnpnt.Size = new Size(50, 29);
            btnpnt.TabIndex = 11;
            btnpnt.Text = ".";
            btnpnt.UseVisualStyleBackColor = true;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.Info;
            btnSuma.Location = new Point(10, 80);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(45, 38);
            btnSuma.TabIndex = 12;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = SystemColors.Info;
            btnResta.Location = new Point(61, 80);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(48, 38);
            btnResta.TabIndex = 13;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.Info;
            btnMulti.Location = new Point(115, 80);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(50, 38);
            btnMulti.TabIndex = 14;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.Info;
            btnDiv.Location = new Point(171, 80);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(47, 38);
            btnDiv.TabIndex = 15;
            btnDiv.Text = "\\";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Info;
            btnClear.Location = new Point(171, 124);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 62);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.Info;
            btnIgual.Location = new Point(171, 192);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(47, 98);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 309);
            Controls.Add(btnIgual);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btnpnt);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(textPantalla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textPantalla;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnpnt;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDiv;
        private Button btnClear;
        private Button btnIgual;
    }
}
