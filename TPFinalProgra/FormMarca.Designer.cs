﻿namespace TPFinalProgra
{
    partial class FormMarca
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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnAddMarca = new System.Windows.Forms.Button();
            this.btnModMarca = new System.Windows.Forms.Button();
            this.btnDelMarca = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.numIdMarca = new System.Windows.Forms.NumericUpDown();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdMarca)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(12, 12);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.Size = new System.Drawing.Size(612, 157);
            this.dgvMarca.TabIndex = 0;
            this.dgvMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellContentClick);
            // 
            // btnAddMarca
            // 
            this.btnAddMarca.Location = new System.Drawing.Point(26, 176);
            this.btnAddMarca.Name = "btnAddMarca";
            this.btnAddMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAddMarca.TabIndex = 1;
            this.btnAddMarca.Text = "Nuevo";
            this.btnAddMarca.UseVisualStyleBackColor = true;
            this.btnAddMarca.Click += new System.EventHandler(this.btnAddMarca_Click);
            // 
            // btnModMarca
            // 
            this.btnModMarca.Location = new System.Drawing.Point(108, 175);
            this.btnModMarca.Name = "btnModMarca";
            this.btnModMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModMarca.TabIndex = 2;
            this.btnModMarca.Text = "Modificar";
            this.btnModMarca.UseVisualStyleBackColor = true;
            this.btnModMarca.Click += new System.EventHandler(this.btnModMarca_Click);
            // 
            // btnDelMarca
            // 
            this.btnDelMarca.Location = new System.Drawing.Point(190, 174);
            this.btnDelMarca.Name = "btnDelMarca";
            this.btnDelMarca.Size = new System.Drawing.Size(75, 23);
            this.btnDelMarca.TabIndex = 3;
            this.btnDelMarca.Text = "Eliminar";
            this.btnDelMarca.UseVisualStyleBackColor = true;
            this.btnDelMarca.Click += new System.EventHandler(this.btnDelMarca_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 12);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // numIdMarca
            // 
            this.numIdMarca.Location = new System.Drawing.Point(16, 37);
            this.numIdMarca.Name = "numIdMarca";
            this.numIdMarca.Size = new System.Drawing.Size(57, 20);
            this.numIdMarca.TabIndex = 5;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(16, 64);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(132, 20);
            this.txtNombreMarca.TabIndex = 6;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(203, 33);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMarca.TabIndex = 7;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(203, 60);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 8;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnCancelarMarca);
            this.pnlDatos.Controls.Add(this.btnGuardarMarca);
            this.pnlDatos.Controls.Add(this.txtNombreMarca);
            this.pnlDatos.Controls.Add(this.numIdMarca);
            this.pnlDatos.Controls.Add(this.lblMarca);
            this.pnlDatos.Enabled = false;
            this.pnlDatos.Location = new System.Drawing.Point(10, 221);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(317, 105);
            this.pnlDatos.TabIndex = 9;
            // 
            // FormMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 343);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.btnDelMarca);
            this.Controls.Add(this.btnModMarca);
            this.Controls.Add(this.btnAddMarca);
            this.Controls.Add(this.dgvMarca);
            this.Name = "FormMarca";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.FormMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdMarca)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnAddMarca;
        private System.Windows.Forms.Button btnModMarca;
        private System.Windows.Forms.Button btnDelMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown numIdMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Panel pnlDatos;
    }
}
