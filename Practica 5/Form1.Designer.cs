namespace Practica_5
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
            label3 = new Label();
            labelResultado = new Label();
            textBoxBase = new TextBox();
            textBoxAltura = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 35);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 0;
            label1.Text = "Area Triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(79, 129);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 1;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(79, 186);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(79, 302);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(52, 28);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "Area";
            // 
            // textBoxBase
            // 
            textBoxBase.Font = new Font("Segoe UI", 12F);
            textBoxBase.Location = new Point(192, 133);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(166, 34);
            textBoxBase.TabIndex = 4;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Font = new Font("Segoe UI", 12F);
            textBoxAltura.Location = new Point(192, 190);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(166, 34);
            textBoxAltura.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(192, 391);
            button1.Name = "button1";
            button1.Size = new Size(166, 47);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(button1);
            Controls.Add(textBoxAltura);
            Controls.Add(textBoxBase);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelResultado;
        private TextBox textBoxBase;
        private TextBox textBoxAltura;
        private Button button1;
    }
}
