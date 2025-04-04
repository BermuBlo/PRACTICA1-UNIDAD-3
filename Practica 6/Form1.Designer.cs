namespace Practica_6
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            valor = new TextBox();
            resultado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 69);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingresa valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 154);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 1;
            label2.Text = "Opciones de conversion";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(115, 192);
            button1.Name = "button1";
            button1.Size = new Size(141, 40);
            button1.TabIndex = 2;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(262, 192);
            button2.Name = "button2";
            button2.Size = new Size(141, 40);
            button2.TabIndex = 3;
            button2.Text = "Centígrados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(185, 238);
            button3.Name = "button3";
            button3.Size = new Size(141, 40);
            button3.TabIndex = 4;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 339);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Resultado en grados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(139, 382);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 6;
            label4.Text = "Equivalente en grados:";
            // 
            // valor
            // 
            valor.Font = new Font("Segoe UI", 12F);
            valor.Location = new Point(252, 73);
            valor.Name = "valor";
            valor.Size = new Size(125, 34);
            valor.TabIndex = 7;
            // 
            // resultado
            // 
            resultado.Font = new Font("Segoe UI", 12F);
            resultado.Location = new Point(185, 442);
            resultado.Name = "resultado";
            resultado.Size = new Size(125, 34);
            resultado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 37);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "Datos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 533);
            Controls.Add(label5);
            Controls.Add(resultado);
            Controls.Add(valor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private TextBox valor;
        private TextBox resultado;
        private Label label5;
    }
}
