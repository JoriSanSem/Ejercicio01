namespace Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textN1 = new System.Windows.Forms.TextBox();
            this.textN2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdSumar = new System.Windows.Forms.RadioButton();
            this.rdMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdDividir = new System.Windows.Forms.RadioButton();
            this.rdRestar = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textN1
            // 
            this.textN1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN1.Location = new System.Drawing.Point(205, 47);
            this.textN1.Margin = new System.Windows.Forms.Padding(8);
            this.textN1.Name = "textN1";
            this.textN1.Size = new System.Drawing.Size(77, 39);
            this.textN1.TabIndex = 2;
            // 
            // textN2
            // 
            this.textN2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN2.Location = new System.Drawing.Point(205, 103);
            this.textN2.Margin = new System.Windows.Forms.Padding(8);
            this.textN2.Name = "textN2";
            this.textN2.Size = new System.Drawing.Size(77, 39);
            this.textN2.TabIndex = 3;
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(205, 169);
            this.textResultado.Margin = new System.Windows.Forms.Padding(8);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(77, 39);
            this.textResultado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdSumar
            // 
            this.rdSumar.AutoSize = true;
            this.rdSumar.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSumar.Location = new System.Drawing.Point(356, 47);
            this.rdSumar.Name = "rdSumar";
            this.rdSumar.Size = new System.Drawing.Size(97, 39);
            this.rdSumar.TabIndex = 6;
            this.rdSumar.TabStop = true;
            this.rdSumar.Text = "Sumar";
            this.rdSumar.UseVisualStyleBackColor = true;
            this.rdSumar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdMultiplicar
            // 
            this.rdMultiplicar.AutoSize = true;
            this.rdMultiplicar.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultiplicar.Location = new System.Drawing.Point(356, 92);
            this.rdMultiplicar.Name = "rdMultiplicar";
            this.rdMultiplicar.Size = new System.Drawing.Size(131, 39);
            this.rdMultiplicar.TabIndex = 7;
            this.rdMultiplicar.TabStop = true;
            this.rdMultiplicar.Text = "Multiplicar";
            this.rdMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdDividir
            // 
            this.rdDividir.AutoSize = true;
            this.rdDividir.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDividir.Location = new System.Drawing.Point(556, 91);
            this.rdDividir.Name = "rdDividir";
            this.rdDividir.Size = new System.Drawing.Size(95, 39);
            this.rdDividir.TabIndex = 8;
            this.rdDividir.TabStop = true;
            this.rdDividir.Text = "Dividir";
            this.rdDividir.UseVisualStyleBackColor = true;
            // 
            // rdRestar
            // 
            this.rdRestar.AutoSize = true;
            this.rdRestar.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRestar.Location = new System.Drawing.Point(556, 46);
            this.rdRestar.Name = "rdRestar";
            this.rdRestar.Size = new System.Drawing.Size(97, 39);
            this.rdRestar.TabIndex = 9;
            this.rdRestar.TabStop = true;
            this.rdRestar.Text = "Restar";
            this.rdRestar.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Agency FB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(423, 157);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(194, 61);
            this.btn.TabIndex = 10;
            this.btn.Text = "Realizar operación";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rdRestar);
            this.Controls.Add(this.rdDividir);
            this.Controls.Add(this.rdMultiplicar);
            this.Controls.Add(this.rdSumar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textN2);
            this.Controls.Add(this.textN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textN1;
        private System.Windows.Forms.TextBox textN2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdSumar;
        private System.Windows.Forms.RadioButton rdMultiplicar;
        private System.Windows.Forms.RadioButton rdDividir;
        private System.Windows.Forms.RadioButton rdRestar;
        private System.Windows.Forms.Button btn;
    }
}

