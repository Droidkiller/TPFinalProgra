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
    public partial class FormProcesador : Form
    {
        private Procesador p;
        public FormProcesador()
        {
            InitializeComponent();
        }

        #region Metodos
        private void Buscar(string buscado)
        {
            dgv.DataSource = null;
            dgv.DataSource = Procesador.Buscar(buscado);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtModelo.Text = "";
            numFrecuencia.Value = 0;
            numNucleos.Value = 0;
            cmbGraficos.Text = "";
            cmbMarca.Text = "";
            pnlDatos.Enabled = true;
        }

        private void CargarSeleccionado()
        {
            txtModelo.Text = p.Modelo;
            numFrecuencia.Value = (decimal)p.Frecuencia;
            numNucleos.Value = p.NroNucleos;
            cmbGraficos.Text = p.Graficos.ToString();
            cmbMarca.Text = p.Marca.ToString();
        }
        #endregion
        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FormProcesador_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Procesador.Buscar();
            cmbGraficos.DataSource = Graficos.Buscar();
            cmbMarca.DataSource = Marca.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            p = new Procesador();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                ZonaDatos(true);
                p = dgv.CurrentRow.DataBoundItem as Procesador;
                CargarSeleccionado();

            }
            else
                MessageBox.Show("Seleccione un procesador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    p = dgv.CurrentRow.DataBoundItem as Procesador;
                    if (MessageBox.Show("¿Desea eliminar el procesador " + p.ToString() + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        p.Eliminar();
                        Buscar(txtBuscar.Text);
                    }
                }
                else
                    MessageBox.Show("Seleccione un procesador", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {                
                 MessageBox.Show("No se pudo eliminar el procesador debido a que se encuentra en uso por una de las notebooks", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            p = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Modelo = txtModelo.Text;
                p.Frecuencia = (double)numFrecuencia.Value;
                p.NroNucleos = (int)numNucleos.Value;
                p.Graficos = cmbGraficos.SelectedItem as Graficos;
                p.Marca = cmbMarca.SelectedItem as Marca;
                p.Guardar();
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
        #endregion

    }
}
