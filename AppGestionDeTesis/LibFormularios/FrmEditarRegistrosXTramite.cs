using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibClases;
namespace LibFormularios
{
    public partial class FrmEditarRegistrosXTramite : FrmPadre
    {
        private CRequisitoXTramite oRequisitoXTramite;
        private CTramite oTramite;
        private CRequisito oRequisito;
        private CDocente oDocente;
        public FrmEditarRegistrosXTramite()
        {
            InitializeComponent();
            oRequisitoXTramite = new CRequisitoXTramite();
            oTramite = new CTramite();
            oRequisito = new CRequisito();
            oDocente = new CDocente();
        }
        public void LlenarListaRequisitos()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                ChlRequisitosXTramite.DataSource = oRequisitoXTramite.ListarRequisitoXTramite(CboCodTramite.Text);
                ChlRequisitosXTramite.DisplayMember = "TipoRequisito";
                ChlRequisitosXTramite.ValueMember = "TipoRequisito";
                //-- dejar el combo sin libro seleccionado
                ChlRequisitosXTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }
        private void SeleccionarTodo()
        {
            for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
            {
                ChlRequisitosXTramite.SetItemChecked(j, false);
            }


            DataRowView oDataRowView = CboCodTramite.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["CodTramite"] as string;
            }



            DataTable dt = oRequisitoXTramite.ListarRequisitoXTramite(sValue);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //MessageBox.Show("dora"+dt.Rows[i]["CodRequisito"].ToString());
                //MessageBox.Show("hola" + drv["CodRequisito"].ToString());
                for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
                {
                    DataRowView drv = ChlRequisitosXTramite.Items[j] as DataRowView;

                    //MessageBox.Show("hola" + drv["CodRequisito"].ToString());
                    if (dt.Rows[i]["CodRequisito"].ToString().CompareTo(drv["CodRequisito"].ToString()) == 0)
                    {
                        ChlRequisitosXTramite.SetItemChecked(j, true);
                    }

                }

            }

            /*
            //DataTable dt2 = oRequisitoXTramite.ListarRequisitoXTramite(CboCodTramite.Text);
            for (int i = 0; i < ChlRequisitosXTramite.Items.Count; i++)
            {
                DataRowView drv = ChlRequisitosXTramite.Items[i] as DataRowView;

                MessageBox.Show("hola"+drv["CodRequisito"].ToString());
            }


            for (int k = 0; k < ChlRequisitosXTramite.Items.Count; k++)
            {
                
                ChlRequisitosXTramite.SetItemChecked(k, true);
            }
            */

        }
        public void LlenarTodosLosRequisitos()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                ChlRequisitosXTramite.DataSource = oRequisito.ListarTodosLosRequisitos();
                ChlRequisitosXTramite.DisplayMember = "TipoRequisito";
                ChlRequisitosXTramite.ValueMember = "TipoRequisito";
                //-- dejar el combo sin libro seleccionado
                ChlRequisitosXTramite.SelectedIndex = -1;
                SeleccionarTodo();
            }
            catch
            {

            }
        }

        public void LlenarCboTramites()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodTramite.DataSource = oTramite.ListaGeneral();
                CboCodTramite.DisplayMember = "Tipo";
                CboCodTramite.ValueMember = "Tipo";
                //-- dejar el combo sin libro seleccionado
                CboCodTramite.SelectedIndex = -1;
            }
            catch
            {

            }
        }


        public void CambioDeRequisitoXTramite()
        {
            try
            {
                List<string> CadenaRequisitos = new List<string>();
                for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
                {
                    DataRowView drv = ChlRequisitosXTramite.Items[j] as DataRowView;
                    if (ChlRequisitosXTramite.GetItemChecked(j))
                    {
                        //MessageBox.Show("hola" + drv["CodRequisito"].ToString());
                        CadenaRequisitos.Add(drv["CodRequisito"].ToString());
                    }

                }
                /*for (int k=0;k< ChlRequisitosXTramite.Items.Count;k++)
                {
                    //MessageBox.Show(ChlRequisitosXTramite.Items[k].ToString());
                }
                */


                oRequisitoXTramite.GuardarCambiosRequisitosXTramite(CboCodTramite.Text, CadenaRequisitos);
                MessageBox.Show("Cambios guardados");
            }
            catch
            {

            }
        }
        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenarTodosLosRequisitos();
        }

        private void FrmEditarRegistrosXTramite_Load(object sender, EventArgs e)
        {
            LlenarListaRequisitos();
            LlenarCboTramites();
        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            CambioDeRequisitoXTramite();
        }
    }
}
