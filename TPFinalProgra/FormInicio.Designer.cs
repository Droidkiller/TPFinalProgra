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
            this.btnNotebooks = new System.Windows.Forms.Button();
            this.btnAlmacenamiento = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnProcesadores = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotebooks
            // 
            this.btnNotebooks.Location = new System.Drawing.Point(12, 12);
            this.btnNotebooks.Name = "btnNotebooks";
            this.btnNotebooks.Size = new System.Drawing.Size(332, 54);
            this.btnNotebooks.TabIndex = 0;
            this.btnNotebooks.Text = "Gestionar Notebooks";
            this.btnNotebooks.UseVisualStyleBackColor = true;
            // 
            // btnAlmacenamiento
            // 
            this.btnAlmacenamiento.Location = new System.Drawing.Point(12, 72);
            this.btnAlmacenamiento.Name = "btnAlmacenamiento";
            this.btnAlmacenamiento.Size = new System.Drawing.Size(332, 54);
            this.btnAlmacenamiento.TabIndex = 1;
            this.btnAlmacenamiento.Text = "Gestionar unidades de almacenamiento";
            this.btnAlmacenamiento.UseVisualStyleBackColor = true;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Location = new System.Drawing.Point(12, 192);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(332, 54);
            this.btnGraficos.TabIndex = 2;
            this.btnGraficos.Text = "Gestionar gráficos integrados";
            this.btnGraficos.UseVisualStyleBackColor = true;
            // 
            // btnProcesadores
            // 
            this.btnProcesadores.Location = new System.Drawing.Point(12, 132);
            this.btnProcesadores.Name = "btnProcesadores";
            this.btnProcesadores.Size = new System.Drawing.Size(332, 54);
            this.btnProcesadores.TabIndex = 3;
            this.btnProcesadores.Text = "Gestionar procesadores";
            this.btnProcesadores.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(12, 252);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(332, 54);
            this.btnMarcas.TabIndex = 4;
            this.btnMarcas.Text = "Gestionar marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 319);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnProcesadores);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.btnAlmacenamiento);
            this.Controls.Add(this.btnNotebooks);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotebooks;
        private System.Windows.Forms.Button btnAlmacenamiento;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnProcesadores;
        private System.Windows.Forms.Button btnMarcas;
    }
}