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
    public partial class FrmBuscarTesista : FrmPadre
    {
        public TextBox CajadeTexto;
        private CTesista oTesista = new CTesista();
        public FrmBuscarTesista()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            CboCategoria.SelectedIndex = 0;
            dgvTesista.DataSource = oTesista.ListaGeneral();
            dgvTesista.Columns["CodTesista"].Visible = false;
            dgvTesista.Columns["CorreoElectronico"].Visible = false;
            dgvTesista.Columns["telefono"].Visible = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TTesista where " + CboCategoria.SelectedItem.ToString() + " like'" + TxtBuscar.Text + "%';";
            dgvTesista.DataSource = oTesista.Busqueda(Consulta);
            dgvTesista.Columns["CodTesista"].Visible = false;
            dgvTesista.Columns["CorreoElectronico"].Visible = false;
            dgvTesista.Columns["telefono"].Visible = false;
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmInscripcion frm = Owner as FrmInscripcion;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = dgvTesista.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

    }
}

