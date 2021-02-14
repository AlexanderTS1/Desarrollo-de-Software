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
    public partial class FrmBuscarDocente : FrmPadre
    {
        public TextBox CajadeTexto;
        private CDocente oDocente = new CDocente();
        public FrmBuscarDocente()
        {
            InitializeComponent();
            InicializarCamposCboNroEstudiantes();
        }
        public void InicializarCamposCboNroEstudiantes()
        {
            CboCategoria.SelectedIndex = 0;
            dgvDocentes.DataSource = oDocente.ListaGeneral();
            dgvDocentes.Columns["CodDocente"].Visible = false;
            dgvDocentes.Columns["Correo"].Visible = false;
            dgvDocentes.Columns["NumeroCelular"].Visible = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string Consulta = "select * from TDocente where " + CboCategoria.SelectedItem.ToString() + " like'" + TxtBuscar.Text + "%';";
            dgvDocentes.DataSource = oDocente.Busqueda(Consulta);
            dgvDocentes.Columns["CodDocente"].Visible = false;
            dgvDocentes.Columns["Correo"].Visible = false;
            dgvDocentes.Columns["NumeroCelular"].Visible = false;
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmInscripcion frm = Owner as FrmInscripcion;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        
    }
}
