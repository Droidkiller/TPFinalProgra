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
    public partial class FormGraficos : Form
    {
        public FormGraficos()
        {
            InitializeComponent();
        }

        #region Metodos
        private void ZonaDatos(bool mostrar)
        {
            numID.Value = 0;
            txtModelo.Text = "";
            pnlDatos.Enabled = mostrar;
        }

        private void Buscar()
        {
            dgvGraficos.DataSource = null;
            dgvGraficos.DataSource = Graficos.Buscar();
        }

        private Graficos ObtenerSeleccionado()
        {
            if (dgvGraficos.CurrentRow != null)
                return dgvGraficos.CurrentRow.DataBoundItem as Graficos;

            return null;
        }
        #endregion

        #region Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Graficos g = ObtenerSeleccionado();
            if (g != null)
            {
                ZonaDatos(true);
                numID.Value = g.Id;
                txtModelo.Text = g.Modelo;
            }
            else
                MessageBox.Show("Seleccione los gráficos a modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar los gráficos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Graficos g= ObtenerSeleccionado();
                if (g != null)
                {
                    g.Eliminar();
                    Buscar();
                }
                else
                    MessageBox.Show("Seleccione los gráficos a eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Graficos g = new Graficos();
                g.Id = (int)numID.Value;
                g.Modelo = txtModelo.Text;
                g.Guardar();
                ZonaDatos(false);
                MessageBox.Show("Se guardo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ZonaDatos(false);
        }

        private void FormGraficos_Load(object sender, EventArgs e)
        {
            Buscar();
        }
        #endregion

    }
}
