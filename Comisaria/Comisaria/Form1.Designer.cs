namespace Comisaria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCreacionComisaria = new System.Windows.Forms.Button();
            this.btListarIncidentes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlacaAgente = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upNroGuardia = new System.Windows.Forms.NumericUpDown();
            this.upDesdeInicio = new System.Windows.Forms.NumericUpDown();
            this.upDesdeFinal = new System.Windows.Forms.NumericUpDown();
            this.upDuracionM = new System.Windows.Forms.NumericUpDown();
            this.btAsignacionDeLasGuardias = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoIncidente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHoraInicio = new System.Windows.Forms.NumericUpDown();
            this.cbHoraFinal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.btRegistrarIncidente = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upNroGuardia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDesdeInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDesdeFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDuracionM)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHoraFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btListarIncidentes);
            this.groupBox1.Controls.Add(this.btCreacionComisaria);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion comisaría";
            // 
            // btCreacionComisaria
            // 
            this.btCreacionComisaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreacionComisaria.Location = new System.Drawing.Point(6, 19);
            this.btCreacionComisaria.Name = "btCreacionComisaria";
            this.btCreacionComisaria.Size = new System.Drawing.Size(189, 62);
            this.btCreacionComisaria.TabIndex = 0;
            this.btCreacionComisaria.Text = "Creación de comisaria";
            this.btCreacionComisaria.UseVisualStyleBackColor = true;
            // 
            // btListarIncidentes
            // 
            this.btListarIncidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarIncidentes.Location = new System.Drawing.Point(201, 19);
            this.btListarIncidentes.Name = "btListarIncidentes";
            this.btListarIncidentes.Size = new System.Drawing.Size(174, 62);
            this.btListarIncidentes.TabIndex = 1;
            this.btListarIncidentes.Text = "Listar incidentes";
            this.btListarIncidentes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbPlacaAgente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones sobre el agente ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa de Agente";
            // 
            // cbPlacaAgente
            // 
            this.cbPlacaAgente.FormattingEnabled = true;
            this.cbPlacaAgente.Location = new System.Drawing.Point(120, 15);
            this.cbPlacaAgente.Name = "cbPlacaAgente";
            this.cbPlacaAgente.Size = new System.Drawing.Size(121, 21);
            this.cbPlacaAgente.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAsignacionDeLasGuardias);
            this.groupBox3.Controls.Add(this.upDuracionM);
            this.groupBox3.Controls.Add(this.upDesdeFinal);
            this.groupBox3.Controls.Add(this.upDesdeInicio);
            this.groupBox3.Controls.Add(this.upNroGuardia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administración de guardias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Guardia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Duracion en M";
            // 
            // upNroGuardia
            // 
            this.upNroGuardia.Location = new System.Drawing.Point(100, 16);
            this.upNroGuardia.Name = "upNroGuardia";
            this.upNroGuardia.Size = new System.Drawing.Size(120, 20);
            this.upNroGuardia.TabIndex = 3;
            // 
            // upDesdeInicio
            // 
            this.upDesdeInicio.Location = new System.Drawing.Point(100, 42);
            this.upDesdeInicio.Name = "upDesdeInicio";
            this.upDesdeInicio.Size = new System.Drawing.Size(48, 20);
            this.upDesdeInicio.TabIndex = 4;
            // 
            // upDesdeFinal
            // 
            this.upDesdeFinal.Location = new System.Drawing.Point(154, 42);
            this.upDesdeFinal.Name = "upDesdeFinal";
            this.upDesdeFinal.Size = new System.Drawing.Size(48, 20);
            this.upDesdeFinal.TabIndex = 5;
            // 
            // upDuracionM
            // 
            this.upDuracionM.Location = new System.Drawing.Point(100, 68);
            this.upDuracionM.Name = "upDuracionM";
            this.upDuracionM.Size = new System.Drawing.Size(120, 20);
            this.upDuracionM.TabIndex = 5;
            // 
            // btAsignacionDeLasGuardias
            // 
            this.btAsignacionDeLasGuardias.Location = new System.Drawing.Point(241, 25);
            this.btAsignacionDeLasGuardias.Name = "btAsignacionDeLasGuardias";
            this.btAsignacionDeLasGuardias.Size = new System.Drawing.Size(102, 51);
            this.btAsignacionDeLasGuardias.TabIndex = 6;
            this.btAsignacionDeLasGuardias.Text = "Asignacion de las guardias";
            this.btAsignacionDeLasGuardias.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRegistrarIncidente);
            this.groupBox4.Controls.Add(this.tbMotivo);
            this.groupBox4.Controls.Add(this.tbDni);
            this.groupBox4.Controls.Add(this.tbPersona);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbHoraFinal);
            this.groupBox4.Controls.Add(this.cbHoraInicio);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbTipoIncidente);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(10, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 204);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administracion de incidentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo incidente";
            // 
            // cbTipoIncidente
            // 
            this.cbTipoIncidente.FormattingEnabled = true;
            this.cbTipoIncidente.Location = new System.Drawing.Point(110, 16);
            this.cbTipoIncidente.Name = "cbTipoIncidente";
            this.cbTipoIncidente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoIncidente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hora";
            // 
            // cbHoraInicio
            // 
            this.cbHoraInicio.Location = new System.Drawing.Point(110, 43);
            this.cbHoraInicio.Name = "cbHoraInicio";
            this.cbHoraInicio.Size = new System.Drawing.Size(48, 20);
            this.cbHoraInicio.TabIndex = 5;
            // 
            // cbHoraFinal
            // 
            this.cbHoraFinal.Location = new System.Drawing.Point(164, 43);
            this.cbHoraFinal.Name = "cbHoraFinal";
            this.cbHoraFinal.Size = new System.Drawing.Size(48, 20);
            this.cbHoraFinal.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Persona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Motivo: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "DNI";
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(110, 71);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(100, 20);
            this.tbPersona.TabIndex = 10;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(250, 71);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 11;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(110, 97);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(240, 54);
            this.tbMotivo.TabIndex = 12;
            // 
            // btRegistrarIncidente
            // 
            this.btRegistrarIncidente.Location = new System.Drawing.Point(110, 157);
            this.btRegistrarIncidente.Name = "btRegistrarIncidente";
            this.btRegistrarIncidente.Size = new System.Drawing.Size(144, 41);
            this.btRegistrarIncidente.TabIndex = 13;
            this.btRegistrarIncidente.Text = "Registrar Incidentes";
            this.btRegistrarIncidente.UseVisualStyleBackColor = true;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(132, 480);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(144, 36);
            this.btCerrar.TabIndex = 14;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 522);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upNroGuardia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDesdeInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDesdeFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDuracionM)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHoraFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btListarIncidentes;
        private System.Windows.Forms.Button btCreacionComisaria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown upDesdeFinal;
        private System.Windows.Forms.NumericUpDown upDesdeInicio;
        private System.Windows.Forms.NumericUpDown upNroGuardia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlacaAgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAsignacionDeLasGuardias;
        private System.Windows.Forms.NumericUpDown upDuracionM;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbTipoIncidente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cbHoraFinal;
        private System.Windows.Forms.NumericUpDown cbHoraInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRegistrarIncidente;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCerrar;
    }
}

