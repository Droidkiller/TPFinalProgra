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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void ZonaDatos(bool mostrar)
        {
            numIdMarca.Value = 0;
            txtNombreMarca.Text = "";
            pnlDatos.Enabled = mostrar;
        }

        private void Buscar()
        {
            dgvMarca.DataSource = null;
            dgvMarca.DataSource = Marca.Buscar();
        }

        private Marca ObtenerSeleccionado()
        {
            if (dgvMarca.CurrentRow != null)
                return dgvMarca.CurrentRow.DataBoundItem as Marca;

            return null;
        }
        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            ZonaDatos(true);
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca m = new Marca();
                m.Id = (int)numIdMarca.Value;
                m.Nombre = txtNombreMarca.Text;
                m.Guardar();
                ZonaDatos(false);
                MessageBox.Show("Se guardo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModMarca_Click(object sender, EventArgs e)
        {
            Marca m = ObtenerSeleccionado();
            if (m != null)
            {
                ZonaDatos(true);
                numIdMarca.Value = m.Id;
                txtNombreMarca.Text = m.Nombre;
            }
            else
                MessageBox.Show("Seleccione una marca", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMarca_Load(object sender, EventArgs e)
        {
            dgvMarca.DataSource = null;
            dgvMarca.DataSource = Marca.Buscar();
        }

        private void btnDelMarca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Marca m = ObtenerSeleccionado();
                if (m != null)
                {
                    m.Eliminar();
                    Buscar();
                }
                else
                    MessageBox.Show("Seleccione una marca", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }+
}
