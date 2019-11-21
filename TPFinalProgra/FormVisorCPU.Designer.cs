namespace TPFinalProgra
{
    partial class FormVisorCPU
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS = new TPFinalProgra.DS();
            this.ProcesadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcesadorTableAdapter = new TPFinalProgra.DSTableAdapters.ProcesadorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcesadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS";
            reportDataSource1.Value = this.ProcesadorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPFinalProgra.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(486, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProcesadorBindingSource
            // 
            this.ProcesadorBindingSource.DataMember = "Procesador";
            this.ProcesadorBindingSource.DataSource = this.DS;
            // 
            // ProcesadorTableAdapter
            // 
            this.ProcesadorTableAdapter.ClearBeforeFill = true;
            // 
            // FormVisorCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormVisorCPU";
            this.Text = "FormVisorCPU";
            this.Load += new System.EventHandler(this.FormVisorCPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcesadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProcesadorBindingSource;
        private DS DS;
        private DSTableAdapters.ProcesadorTableAdapter ProcesadorTableAdapter;
    }
}