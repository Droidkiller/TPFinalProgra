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
    public partial class FormVisorCPU : Form
    {
        public FormVisorCPU()
        {
            InitializeComponent();
        }

        private void FormVisorCPU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Procesador' table. You can move, or remove it, as needed.
            this.ProcesadorTableAdapter.Connection.ConnectionString = Conexion.DarStrConexion();
            this.ProcesadorTableAdapter.Fill(this.DS.Procesador);

            this.reportViewer1.RefreshReport();
        }
    }
}
