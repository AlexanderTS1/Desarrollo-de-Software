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
    public partial class FrmGenerarExpediente : FrmPadre
    {
        protected CTramite oTramite;
        CDocente oDocente = new CDocente();
        CTesis oTesis = new CTesis();
        public FrmGenerarExpediente()
        {
            InitializeComponent();
            oTramite = new CTramite();
            // Create new Checkbox Column
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "";
            CBColumn.FalseValue = "0";
            CBColumn.TrueValue = "1";
            DgvTramitesDeInscripcion.Columns.Insert(0, CBColumn);
            //InicializarGrid();
            //ccf.Visible = false;
        }

        public void InicializarGrid()
        {
            DgvTramitesDeInscripcion.DataSource = oDocente.ListaGeneral();
            DgvTramitesDeInscripcion.Columns["CodDocente"].Visible = false;
            DgvTramitesDeInscripcion.Columns["Correo"].Visible = false;
            DgvTramitesDeInscripcion.Columns["Telefono"].Visible = false;
            DgvTramitesDeInscripcion.Columns["Dni"].Visible = false;
        }

        private void RellenarTablaTramites()
        {
            DgvTramitesDeInscripcion.DataSource = oTramite.ListaTramitesDeInscripcionDeTesis();
        }
        private void FrmGenerarExpediente_Load(object sender, EventArgs e)
        {
            RellenarTablaTramites();
        }

        private void BtnGenerarTramite_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();

            //oTramite.GenerarExpediente(lista);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTramitesDeInscripcion.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtCodTramite.Text = DgvTramitesDeInscripcion.CurrentRow.Cells["CodTramITTesis"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }
        }

        
    }
}

