namespace practica4p3
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
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.textBoxCubo = new System.Windows.Forms.TextBox();
            this.textBoxCuadrado = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.Location = new System.Drawing.Point(147, 86);
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(156, 20);
            this.textBoxIngresar.TabIndex = 0;
            // 
            // textBoxCubo
            // 
            this.textBoxCubo.Location = new System.Drawing.Point(316, 204);
            this.textBoxCubo.Name = "textBoxCubo";
            this.textBoxCubo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCubo.TabIndex = 1;
            // 
            // textBoxCuadrado
            // 
            this.textBoxCuadrado.Location = new System.Drawing.Point(106, 204);
            this.textBoxCuadrado.Name = "textBoxCuadrado";
            this.textBoxCuadrado.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuadrado.TabIndex = 2;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(388, 134);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Cuadrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor al Cubo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxCuadrado);
            this.Controls.Add(this.textBoxCubo);
            this.Controls.Add(this.textBoxIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIngresar;
        private System.Windows.Forms.TextBox textBoxCubo;
        private System.Windows.Forms.TextBox textBoxCuadrado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

