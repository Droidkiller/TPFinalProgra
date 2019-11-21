namespace TPFinalProgra
{
    partial class FormProcesador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.numFrecuencia = new System.Windows.Forms.NumericUpDown();
            this.numNucleos = new System.Windows.Forms.NumericUpDown();
            this.lblNroNucleos = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbGraficos = new System.Windows.Forms.ComboBox();
            this.lblGraficos = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGHz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecuencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNucleos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 63);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(677, 208);
            this.dgv.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(38, 278);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(119, 278);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(202, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 17);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(225, 14);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(160, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(16, 43);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFrecuencia.Size = new System.Drawing.Size(63, 13);
            this.lblFrecuencia.TabIndex = 8;
            this.lblFrecuencia.Text = "Frecuencia:";
            // 
            // numFrecuencia
            // 
            this.numFrecuencia.Location = new System.Drawing.Point(225, 41);
            this.numFrecuencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFrecuencia.Name = "numFrecuencia";
            this.numFrecuencia.Size = new System.Drawing.Size(160, 20);
            this.numFrecuencia.TabIndex = 9;
            // 
            // numNucleos
            // 
            this.numNucleos.Location = new System.Drawing.Point(225, 68);
            this.numNucleos.Name = "numNucleos";
            this.numNucleos.Size = new System.Drawing.Size(160, 20);
            this.numNucleos.TabIndex = 11;
            // 
            // lblNroNucleos
            // 
            this.lblNroNucleos.AutoSize = true;
            this.lblNroNucleos.Location = new System.Drawing.Point(16, 70);
            this.lblNroNucleos.Name = "lblNroNucleos";
            this.lblNroNucleos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNroNucleos.Size = new System.Drawing.Size(102, 13);
            this.lblNroNucleos.TabIndex = 10;
            this.lblNroNucleos.Text = "Número de núcleos:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 98);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(225, 95);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(160, 21);
            this.cmbMarca.TabIndex = 13;
            // 
            // cmbGraficos
            // 
            this.cmbGraficos.FormattingEnabled = true;
            this.cmbGraficos.Location = new System.Drawing.Point(225, 122);
            this.cmbGraficos.Name = "cmbGraficos";
            this.cmbGraficos.Size = new System.Drawing.Size(160, 21);
            this.cmbGraficos.TabIndex = 15;
            // 
            // lblGraficos
            // 
            this.lblGraficos.AutoSize = true;
            this.lblGraficos.Location = new System.Drawing.Point(16, 125);
            this.lblGraficos.Name = "lblGraficos";
            this.lblGraficos.Size = new System.Drawing.Size(46, 13);
            this.lblGraficos.TabIndex = 14;
            this.lblGraficos.Text = "Graficos";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblGHz);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.cmbGraficos);
            this.pnlDatos.Controls.Add(this.lblGraficos);
            this.pnlDatos.Controls.Add(this.cmbMarca);
            this.pnlDatos.Controls.Add(this.lblMarca);
            this.pnlDatos.Controls.Add(this.numNucleos);
            this.pnlDatos.Controls.Add(this.lblNroNucleos);
            this.pnlDatos.Controls.Add(this.numFrecuencia);
            this.pnlDatos.Controls.Add(this.lblFrecuencia);
            this.pnlDatos.Controls.Add(this.txtModelo);
            this.pnlDatos.Controls.Add(this.lblModelo);
            this.pnlDatos.Enabled = false;
            this.pnlDatos.Location = new System.Drawing.Point(22, 325);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(430, 186);
            this.pnlDatos.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(32, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblGHz
            // 
            this.lblGHz.AutoSize = true;
            this.lblGHz.Location = new System.Drawing.Point(391, 43);
            this.lblGHz.Name = "lblGHz";
            this.lblGHz.Size = new System.Drawing.Size(28, 13);
            this.lblGHz.TabIndex = 18;
            this.lblGHz.Text = "GHz";
            // 
            // FormProcesador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 576);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgv);
            this.Name = "FormProcesador";
            this.Text = "FormProcesador";
            this.Load += new System.EventHandler(this.FormProcesador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrecuencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNucleos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.NumericUpDown numFrecuencia;
        private System.Windows.Forms.NumericUpDown numNucleos;
        private System.Windows.Forms.Label lblNroNucleos;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbGraficos;
        private System.Windows.Forms.Label lblGraficos;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblGHz;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}