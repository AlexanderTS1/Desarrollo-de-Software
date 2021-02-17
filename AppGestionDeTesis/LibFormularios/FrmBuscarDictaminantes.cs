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
    public partial class FrmBuscarDictaminantes : Form
    {
        public TextBox CajadeTexto;
        private CDocente oDocente = new CDocente();
        public FrmBuscarDictaminantes()
        {
            InitializeComponent();
            ListarDictaminantes();
        }
        public void ListarDictaminantes()
        {
            string Consulta = "select distinct CodDictamenDeTesis from TDictaminantesDeTesis";
            dgvDocentes.DataSource = oDocente.Busqueda(Consulta);
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
           
            FrmInscripcion frm = Owner as FrmInscripcion;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInscripcion frm = Owner as FrmInscripcion;
            //frm.CodigoBusqueda.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            CajadeTexto.Text = dgvDocentes.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
        //select * from TDictaminantesDeTesis

    }
}
