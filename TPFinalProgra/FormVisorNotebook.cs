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
    public partial class FormVisorNotebook : Form
    {
        public FormVisorNotebook()
        {
            InitializeComponent();
        }

        private void FormVisorNotebook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Notebook' table. You can move, or remove it, as needed.
            this.NotebookTableAdapter.Connection.ConnectionString = Conexion.DarStrConexion();
            this.NotebookTableAdapter.Fill(this.DS.Notebook);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
