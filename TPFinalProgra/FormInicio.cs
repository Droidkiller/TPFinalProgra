using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace TPFinalProgra
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnNotebooks_Click(object sender, EventArgs e)
        {
            FormNotebook f = new FormNotebook();
            f.ShowDialog();
        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            FormAlmacenamiento f = new FormAlmacenamiento();
            f.ShowDialog();
        }

        private void btnProcesadores_Click(object sender, EventArgs e)
        {
            FormProcesador f = new FormProcesador();
            f.ShowDialog();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            FormGraficos f = new FormGraficos();
            f.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FormMarca f = new FormMarca();
            f.ShowDialog();
        }

        private void btnMostrarMarcas_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Marca.Buscar();
            lblTitulo.Text = "marcas";
        }

        private void btnMostrarNotebooks_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Notebook.Buscar();
            lblTitulo.Text = "notebooks";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Graficos.Buscar();
            lblTitulo.Text = "gráficos integrados";
        }

        private void btnMostrarCPUs_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Procesador.Buscar();
            lblTitulo.Text = "procesadores";
        }

        private void btnMostrarAlm_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Almacenamiento.Buscar();
            lblTitulo.Text = "unidades de almacenamiento";
        }

        private void btnReporteCPU_Click(object sender, EventArgs e)
        {
            FormVisorCPU f = new FormVisorCPU();
            f.ShowDialog();
        }

        private void btnReporteNotebook_Click(object sender, EventArgs e)
        {
            FormVisorNotebook f = new FormVisorNotebook();
            f.ShowDialog();
        }
    }
}
