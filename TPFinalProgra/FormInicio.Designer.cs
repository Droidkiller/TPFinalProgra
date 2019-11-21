namespace TPFinalProgra
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnNotebooks = new System.Windows.Forms.Button();
            this.btnAlmacenamiento = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnProcesadores = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnMostrarMarcas = new System.Windows.Forms.Button();
            this.btnMostrarNotebooks = new System.Windows.Forms.Button();
            this.btnMostrarCPUs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrarAlm = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteCPU = new System.Windows.Forms.Button();
            this.btnReporteNotebook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotebooks
            // 
            this.btnNotebooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNotebooks.Location = new System.Drawing.Point(154, 462);
            this.btnNotebooks.Name = "btnNotebooks";
            this.btnNotebooks.Size = new System.Drawing.Size(136, 40);
            this.btnNotebooks.TabIndex = 8;
            this.btnNotebooks.Text = "Gestionar notebooks";
            this.btnNotebooks.UseVisualStyleBackColor = true;
            this.btnNotebooks.Click += new System.EventHandler(this.btnNotebooks_Click);
            // 
            // btnAlmacenamiento
            // 
            this.btnAlmacenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlmacenamiento.Location = new System.Drawing.Point(583, 462);
            this.btnAlmacenamiento.Name = "btnAlmacenamiento";
            this.btnAlmacenamiento.Size = new System.Drawing.Size(137, 40);
            this.btnAlmacenamiento.TabIndex = 11;
            this.btnAlmacenamiento.Text = "Gestionar unidades de almacenamiento";
            this.btnAlmacenamiento.UseVisualStyleBackColor = true;
            this.btnAlmacenamiento.Click += new System.EventHandler(this.btnAlmacenamiento_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGraficos.Location = new System.Drawing.Point(440, 462);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(137, 40);
            this.btnGraficos.TabIndex = 10;
            this.btnGraficos.Text = "Gestionar gráficos integrados";
            this.btnGraficos.UseVisualStyleBackColor = true;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnProcesadores
            // 
            this.btnProcesadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcesadores.Location = new System.Drawing.Point(298, 462);
            this.btnProcesadores.Name = "btnProcesadores";
            this.btnProcesadores.Size = new System.Drawing.Size(136, 40);
            this.btnProcesadores.TabIndex = 8;
            this.btnProcesadores.Text = "Gestionar procesadores";
            this.btnProcesadores.UseVisualStyleBackColor = true;
            this.btnProcesadores.Click += new System.EventHandler(this.btnProcesadores_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarcas.Location = new System.Drawing.Point(9, 462);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(137, 40);
            this.btnMarcas.TabIndex = 7;
            this.btnMarcas.Text = "Gestionar marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 34);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(854, 367);
            this.dgv.TabIndex = 15;
            // 
            // btnMostrarMarcas
            // 
            this.btnMostrarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarMarcas.Location = new System.Drawing.Point(9, 416);
            this.btnMostrarMarcas.Name = "btnMostrarMarcas";
            this.btnMostrarMarcas.Size = new System.Drawing.Size(137, 40);
            this.btnMostrarMarcas.TabIndex = 1;
            this.btnMostrarMarcas.Text = "Mostrar marcas";
            this.btnMostrarMarcas.UseVisualStyleBackColor = true;
            this.btnMostrarMarcas.Click += new System.EventHandler(this.btnMostrarMarcas_Click);
            // 
            // btnMostrarNotebooks
            // 
            this.btnMostrarNotebooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarNotebooks.Location = new System.Drawing.Point(154, 416);
            this.btnMostrarNotebooks.Name = "btnMostrarNotebooks";
            this.btnMostrarNotebooks.Size = new System.Drawing.Size(137, 40);
            this.btnMostrarNotebooks.TabIndex = 2;
            this.btnMostrarNotebooks.Text = "Mostrar notebooks";
            this.btnMostrarNotebooks.UseVisualStyleBackColor = true;
            this.btnMostrarNotebooks.Click += new System.EventHandler(this.btnMostrarNotebooks_Click);
            // 
            // btnMostrarCPUs
            // 
            this.btnMostrarCPUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarCPUs.Location = new System.Drawing.Point(297, 416);
            this.btnMostrarCPUs.Name = "btnMostrarCPUs";
            this.btnMostrarCPUs.Size = new System.Drawing.Size(137, 40);
            this.btnMostrarCPUs.TabIndex = 3;
            this.btnMostrarCPUs.Text = "Mostrar procesadores";
            this.btnMostrarCPUs.UseVisualStyleBackColor = true;
            this.btnMostrarCPUs.Click += new System.EventHandler(this.btnMostrarCPUs_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(440, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostrar gráficos integrados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMostrarAlm
            // 
            this.btnMostrarAlm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrarAlm.Location = new System.Drawing.Point(583, 416);
            this.btnMostrarAlm.Name = "btnMostrarAlm";
            this.btnMostrarAlm.Size = new System.Drawing.Size(137, 40);
            this.btnMostrarAlm.TabIndex = 5;
            this.btnMostrarAlm.Text = "Mostrar unidades de almacenamiento";
            this.btnMostrarAlm.UseVisualStyleBackColor = true;
            this.btnMostrarAlm.Click += new System.EventHandler(this.btnMostrarAlm_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(63, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 13);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "nada aún";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mostrando:";
            // 
            // btnReporteCPU
            // 
            this.btnReporteCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporteCPU.Location = new System.Drawing.Point(726, 416);
            this.btnReporteCPU.Name = "btnReporteCPU";
            this.btnReporteCPU.Size = new System.Drawing.Size(137, 40);
            this.btnReporteCPU.TabIndex = 6;
            this.btnReporteCPU.Text = "Mostrar lista (reporte) de procesadores";
            this.btnReporteCPU.UseVisualStyleBackColor = true;
            this.btnReporteCPU.Click += new System.EventHandler(this.btnReporteCPU_Click);
            // 
            // btnReporteNotebook
            // 
            this.btnReporteNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporteNotebook.Location = new System.Drawing.Point(726, 462);
            this.btnReporteNotebook.Name = "btnReporteNotebook";
            this.btnReporteNotebook.Size = new System.Drawing.Size(137, 40);
            this.btnReporteNotebook.TabIndex = 12;
            this.btnReporteNotebook.Text = "Mostrar lista (reporte) de notebooks";
            this.btnReporteNotebook.UseVisualStyleBackColor = true;
            this.btnReporteNotebook.Click += new System.EventHandler(this.btnReporteNotebook_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 514);
            this.Controls.Add(this.btnReporteNotebook);
            this.Controls.Add(this.btnReporteCPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMostrarAlm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMostrarCPUs);
            this.Controls.Add(this.btnMostrarNotebooks);
            this.Controls.Add(this.btnMostrarMarcas);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnProcesadores);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.btnAlmacenamiento);
            this.Controls.Add(this.btnNotebooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.Text = "Trabajo práctico final de programación";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotebooks;
        private System.Windows.Forms.Button btnAlmacenamiento;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnProcesadores;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMostrarMarcas;
        private System.Windows.Forms.Button btnMostrarNotebooks;
        private System.Windows.Forms.Button btnMostrarCPUs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostrarAlm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteCPU;
        private System.Windows.Forms.Button btnReporteNotebook;
    }
}