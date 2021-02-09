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
    public partial class FrmInscripcion : FrmPadre
    {
        private CTramite oTramite;
        private CDocente oDocente;
        private CRequisitoXTramite oRequsitosXTramite;
        private CTesis oTesis;
        //private TextBox codigoBusquedaDocente;
        //private TextBox codigoBusquedaTesista1;
        //private TextBox codigoBusquedaTesista2;
        //private TextBox codigoBusquedaTesista3;
        public string aBusqueda;
        public FrmInscripcion()
        {
            InitializeComponent();
            InicializarNroEstudiantes();
            oTramite = new CTramite();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            LlenarCboTramites();
            //LlenarCboDocentes();

        }
        // ================= EVENTOS ==============================
        private void TxtCodTesis_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        public void InicializarNroEstudiantes()
        {
            GboTesista1.Visible = true;
            GboTesista2.Visible = false;
            GboTesista3.Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboNroTesistas.Text == "1")
            {
                GboTesista1.Visible = true;
                GboTesista2.Visible = false;
                GboTesista3.Visible = false;
            }
            if (CboNroTesistas.Text=="2")
            {
                GboTesista1.Visible = true; 
                GboTesista2.Visible = true;
                GboTesista3.Visible = false;
            }
            if (CboNroTesistas.Text == "3")
            {
                GboTesista1.Visible = true;
                GboTesista2.Visible = true;
                GboTesista3.Visible = true;
            }
        }

        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboTipoTramite.DataSource = oTramite.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboTipoTramite.ValueMember = "Tipo";
                //-- dejar el combo sin libro seleccionado
                CboTipoTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        /*public void LlenarCboDocentes()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboDocente.DataSource = oDocente.ListaGeneral();
                //CboCodDocente.DisplayMember = "Correo";
                CboDocente.ValueMember = "Apellidos";
                //-- dejar el combo sin libro seleccionado
                CboDocente.SelectedIndex = -1;
            }
            catch
            {

            }
        }*/

        public void RellenarRequisitosXTramite()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                /*
                DataRowView drv = CboCodTramite.SelectedItem as DataRowView;
                //string CodigoTramite = drv["CodTramite"].ToString();
                string CodigoTramite = drv["CodTramite"].ToString();
                MessageBox.Show(CodigoTramite);
                */
                DataRowView oDataRowView = CboTipoTramite.SelectedItem as DataRowView;
                string sValue = string.Empty;

                if (oDataRowView != null)
                {
                    sValue = oDataRowView.Row["CodTramite"] as string;
                }



                ChlRequisitosXTramite.DataSource = oRequsitosXTramite.ListarRequisitoXTramiteNombres(sValue);
                //ChlRequisitosXTramite.DataSource = oRequsitosXTramite.ListaGeneral();
                ChlRequisitosXTramite.DisplayMember = "TipoRequisito";
                ChlRequisitosXTramite.ValueMember = "TipoRequisito";
                //-- dejar el combo sin libro seleccionado
                ChlRequisitosXTramite.SelectedIndex = -1;

            }
            catch
            {
                //MessageBox.Show("error");
            }
        }
        
    }
}
