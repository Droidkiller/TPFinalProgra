using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;

namespace TPFinalProgra
{
    public partial class FormNotebook : Form
    {
        private Notebook n;
        public FormNotebook()
        {
            InitializeComponent();
        }

        #region Metodos
        private void Buscar(string buscado)
        {
            dgv.DataSource = null;
            dgv.DataSource = Notebook.Buscar(buscado);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtModelo.Text = "";
            numMemoria.Value = 0;
            numPantalla.Value = 0;
            numPeso.Value = 0;
            cmbAlm.Text = "";
            cmbCpu.Text = "";
            cmbMarca.Text = "";
            pnlDatos.Enabled = mostrar;
        }

        private void CargarSeleccionado()
        {
            txtModelo.Text = n.Modelo;
            numMemoria.Value = n.Memoria;
            numPantalla.Value = (decimal)n.TamañoPantalla;
            numPeso.Value = (decimal)n.Peso;
            cmbAlm.Text = n.Alm.ToString();
            cmbCpu.Text = n.Cpu.ToString();
            cmbMarca.Text = n.Marca.ToString();
        }
        #endregion

        private void FormNotebook_Load(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Notebook.Buscar();
            cmbAlm.DataSource = Almacenamiento.Buscar();
            cmbCpu.DataSource = Procesador.Buscar();
            cmbMarca.DataSource = Marca.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            n = new Notebook();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                ZonaDatos(true);
                n = dgv.CurrentRow.DataBoundItem as Notebook;
                CargarSeleccionado();
            }
            else
                MessageBox.Show("Seleccione una notebook", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    n = dgv.CurrentRow.DataBoundItem as Notebook;
                    if (MessageBox.Show("¿Desea eliminar la notebook " + n.ToString() + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        n.Eliminar();
                        Buscar(txtBuscar.Text);
                    }
                }
                else
                    MessageBox.Show("Seleccione una unidad de almacenamiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            n = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                n.Modelo = txtModelo.Text;
                n.TamañoPantalla = (double)numPantalla.Value;
                n.Memoria = (int)numMemoria.Value;
                n.Peso = (double)numPeso.Value;
                n.Alm = cmbAlm.SelectedItem as Almacenamiento;
                n.Cpu = cmbCpu.SelectedItem as Procesador;
                n.Marca = cmbMarca.SelectedItem as Marca;
                n.Guardar();
                ZonaDatos(false);
                Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
