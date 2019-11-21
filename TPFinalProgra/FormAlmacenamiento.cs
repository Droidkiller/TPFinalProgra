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
    public partial class FormAlmacenamiento : Form
    {
        private Almacenamiento a;
        public FormAlmacenamiento()
        {
            InitializeComponent();
        }

        #region Metodos
        private void Buscar(string buscado)
        {
            dgv.DataSource = null;
            dgv.DataSource = Almacenamiento.Buscar(buscado);
        }

        private void ZonaDatos(bool mostrar)
        {
            txtModelo.Text = "";
            numCapacidad.Value = 0;
            numVelocidad.Value = 0;
            txtTipo.Text = "";
            cmbMarca.Text = "";
            pnlDatos.Enabled = mostrar;
        }

        private void CargarSeleccionado()
        {
            txtModelo.Text = a.Modelo;
            numCapacidad.Value = a.Capacidad;
            numVelocidad.Value = (decimal)a.Velocidad;
            txtTipo.Text = a.Tipo;
            cmbMarca.Text = a.Marca.ToString();
        }
        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
            a = new Almacenamiento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void FormAlmacenamiento_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Almacenamiento.Buscar();
            cmbMarca.DataSource = Marca.Buscar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                ZonaDatos(true);
                a = dgv.CurrentRow.DataBoundItem as Almacenamiento;
                CargarSeleccionado();

            }
            else
                MessageBox.Show("Seleccione una unidad de almacenamiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    a = dgv.CurrentRow.DataBoundItem as Almacenamiento;
                    if (MessageBox.Show("¿Desea eliminar la unidad de almacenamiento " + a.ToString() + "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        a.Eliminar();
                        Buscar(txtBuscar.Text);
                    }
                }
                else
                    MessageBox.Show("Seleccione una unidad de almacenamiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo eliminar el almacenamiento debido a que está en uso por una de las notebooks existentes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
            a = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                a.Modelo = txtModelo.Text;
                a.Velocidad = (double)numVelocidad.Value;
                a.Capacidad = (int)numCapacidad.Value;
                a.Tipo = txtTipo.Text;
                a.Marca = cmbMarca.SelectedItem as Marca;
                a.Guardar();
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
