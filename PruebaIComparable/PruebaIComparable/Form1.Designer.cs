namespace PruebaIComparable
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
            this.lbPrueba = new System.Windows.Forms.ListBox();
            this.btCrearPersonas = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPrueba
            // 
            this.lbPrueba.FormattingEnabled = true;
            this.lbPrueba.Location = new System.Drawing.Point(12, 12);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(304, 251);
            this.lbPrueba.TabIndex = 0;
            // 
            // btCrearPersonas
            // 
            this.btCrearPersonas.Location = new System.Drawing.Point(322, 12);
            this.btCrearPersonas.Name = "btCrearPersonas";
            this.btCrearPersonas.Size = new System.Drawing.Size(96, 32);
            this.btCrearPersonas.TabIndex = 1;
            this.btCrearPersonas.Text = "Crear";
            this.btCrearPersonas.UseVisualStyleBackColor = true;
            this.btCrearPersonas.Click += new System.EventHandler(this.btCrearPersonas_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(322, 50);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(96, 32);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscado
            // 
            this.tbBuscado.Location = new System.Drawing.Point(424, 57);
            this.tbBuscado.Name = "tbBuscado";
            this.tbBuscado.Size = new System.Drawing.Size(100, 20);
            this.tbBuscado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 270);
            this.Controls.Add(this.tbBuscado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCrearPersonas);
            this.Controls.Add(this.lbPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPrueba;
        private System.Windows.Forms.Button btCrearPersonas;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscado;
    }
}

