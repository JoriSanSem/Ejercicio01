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
            this.numeroA = new System.Windows.Forms.Label();
            this.rdbtnSuma = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.numA = new System.Windows.Forms.TextBox();
            this.numeroB = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.TextBox();
            this.rdbtnDivision = new System.Windows.Forms.RadioButton();
            this.rdbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rdbtnResta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeroA
            // 
            this.numeroA.AutoSize = true;
            this.numeroA.Location = new System.Drawing.Point(49, 47);
            this.numeroA.Name = "numeroA";
            this.numeroA.Size = new System.Drawing.Size(104, 35);
            this.numeroA.TabIndex = 0;
            this.numeroA.Text = "Número A";
            this.numeroA.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdbtnSuma
            // 
            this.rdbtnSuma.AutoSize = true;
            this.rdbtnSuma.Location = new System.Drawing.Point(414, 45);
            this.rdbtnSuma.Name = "rdbtnSuma";
            this.rdbtnSuma.Size = new System.Drawing.Size(87, 39);
            this.rdbtnSuma.TabIndex = 1;
            this.rdbtnSuma.TabStop = true;
            this.rdbtnSuma.Text = "Suma";
            this.rdbtnSuma.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(257, 164);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(253, 70);
            this.button.TabIndex = 2;
            this.button.Text = "Realizar operación";
            this.button.UseVisualStyleBackColor = true;
            // 
            // numA
            // 
            this.numA.AcceptsTab = true;
            this.numA.Location = new System.Drawing.Point(187, 47);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(192, 40);
            this.numA.TabIndex = 3;
            this.numA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeroB
            // 
            this.numeroB.AutoSize = true;
            this.numeroB.Location = new System.Drawing.Point(49, 98);
            this.numeroB.Name = "numeroB";
            this.numeroB.Size = new System.Drawing.Size(105, 35);
            this.numeroB.TabIndex = 4;
            this.numeroB.Text = "Número B";
            // 
            // numB
            // 
            this.numB.AcceptsTab = true;
            this.numB.Location = new System.Drawing.Point(187, 98);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(192, 40);
            this.numB.TabIndex = 5;
            this.numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbtnDivision
            // 
            this.rdbtnDivision.AutoSize = true;
            this.rdbtnDivision.Location = new System.Drawing.Point(604, 99);
            this.rdbtnDivision.Name = "rdbtnDivision";
            this.rdbtnDivision.Size = new System.Drawing.Size(107, 39);
            this.rdbtnDivision.TabIndex = 6;
            this.rdbtnDivision.TabStop = true;
            this.rdbtnDivision.Text = "División";
            this.rdbtnDivision.UseVisualStyleBackColor = true;
            // 
            // rdbtnMultiplicacion
            // 
            this.rdbtnMultiplicacion.AutoSize = true;
            this.rdbtnMultiplicacion.Location = new System.Drawing.Point(414, 99);
            this.rdbtnMultiplicacion.Name = "rdbtnMultiplicacion";
            this.rdbtnMultiplicacion.Size = new System.Drawing.Size(159, 39);
            this.rdbtnMultiplicacion.TabIndex = 7;
            this.rdbtnMultiplicacion.TabStop = true;
            this.rdbtnMultiplicacion.Text = "Multiplicación";
            this.rdbtnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbtnResta
            // 
            this.rdbtnResta.AutoSize = true;
            this.rdbtnResta.Location = new System.Drawing.Point(604, 45);
            this.rdbtnResta.Name = "rdbtnResta";
            this.rdbtnResta.Size = new System.Drawing.Size(87, 39);
            this.rdbtnResta.TabIndex = 8;
            this.rdbtnResta.TabStop = true;
            this.rdbtnResta.Text = "Resta";
            this.rdbtnResta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Respuesta";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(328, 318);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(84, 35);
            this.answer.TabIndex = 10;
            this.answer.Text = "answer";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(742, 381);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbtnResta);
            this.Controls.Add(this.rdbtnMultiplicacion);
            this.Controls.Add(this.rdbtnDivision);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numeroB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.button);
            this.Controls.Add(this.rdbtnSuma);
            this.Controls.Add(this.numeroA);
            this.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Name = "Form1";
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
        private System.Windows.Forms.Label numeroA;
        private System.Windows.Forms.RadioButton rdbtnSuma;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox numA;
        private System.Windows.Forms.Label numeroB;
        private System.Windows.Forms.TextBox numB;
        private System.Windows.Forms.RadioButton rdbtnDivision;
        private System.Windows.Forms.RadioButton rdbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rdbtnResta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label answer;
    }
}

