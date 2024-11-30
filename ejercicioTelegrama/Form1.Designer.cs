namespace ejercicioTelegrama
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
            this.labeltexto = new System.Windows.Forms.Label();
            this.checkBoxurgente = new System.Windows.Forms.CheckBox();
            this.labelcoste = new System.Windows.Forms.Label();
            this.textBoxtexto = new System.Windows.Forms.TextBox();
            this.textBoxcoste = new System.Windows.Forms.TextBox();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltexto
            // 
            this.labeltexto.AutoSize = true;
            this.labeltexto.Location = new System.Drawing.Point(85, 59);
            this.labeltexto.Name = "labeltexto";
            this.labeltexto.Size = new System.Drawing.Size(51, 20);
            this.labeltexto.TabIndex = 0;
            this.labeltexto.Text = "Texto";
            // 
            // checkBoxurgente
            // 
            this.checkBoxurgente.AutoSize = true;
            this.checkBoxurgente.Location = new System.Drawing.Point(88, 296);
            this.checkBoxurgente.Name = "checkBoxurgente";
            this.checkBoxurgente.Size = new System.Drawing.Size(84, 20);
            this.checkBoxurgente.TabIndex = 1;
            this.checkBoxurgente.Text = "Urgente?";
            this.checkBoxurgente.UseVisualStyleBackColor = true;
            // 
            // labelcoste
            // 
            this.labelcoste.AutoSize = true;
            this.labelcoste.Location = new System.Drawing.Point(85, 364);
            this.labelcoste.Name = "labelcoste";
            this.labelcoste.Size = new System.Drawing.Size(45, 16);
            this.labelcoste.TabIndex = 2;
            this.labelcoste.Text = "Coste:";
            // 
            // textBoxtexto
            // 
            this.textBoxtexto.Location = new System.Drawing.Point(88, 82);
            this.textBoxtexto.Multiline = true;
            this.textBoxtexto.Name = "textBoxtexto";
            this.textBoxtexto.Size = new System.Drawing.Size(629, 173);
            this.textBoxtexto.TabIndex = 3;
            this.textBoxtexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxcoste
            // 
            this.textBoxcoste.Location = new System.Drawing.Point(136, 358);
            this.textBoxcoste.Name = "textBoxcoste";
            this.textBoxcoste.Size = new System.Drawing.Size(100, 22);
            this.textBoxcoste.TabIndex = 4;
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(506, 325);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(211, 55);
            this.buttoncalcular.TabIndex = 5;
            this.buttoncalcular.Text = "Calcular";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.textBoxcoste);
            this.Controls.Add(this.textBoxtexto);
            this.Controls.Add(this.labelcoste);
            this.Controls.Add(this.checkBoxurgente);
            this.Controls.Add(this.labeltexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltexto;
        private System.Windows.Forms.CheckBox checkBoxurgente;
        private System.Windows.Forms.Label labelcoste;
        private System.Windows.Forms.TextBox textBoxtexto;
        private System.Windows.Forms.TextBox textBoxcoste;
        private System.Windows.Forms.Button buttoncalcular;
    }
}

