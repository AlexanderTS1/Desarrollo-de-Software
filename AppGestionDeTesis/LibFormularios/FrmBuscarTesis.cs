using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;
namespace LibFormularios
{
    public partial class FrmBuscarTesis : FrmPadre
    {
        public TextBox CajadeTexto;
        private CTesis oTesis = new CTesis();
        public FrmBuscarTesis()
        {
            InitializeComponent();
            InicializarCamposCboNroTesis();
        }
        public void InicializarCamposCboNroTesis()
        {
            CboTesis.SelectedIndex = 0;
            dgvTesis.DataSource = oTesis.ListaGeneral();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmInscripcion frm = Owner as FrmInscripcion;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = dgvTesis.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}

