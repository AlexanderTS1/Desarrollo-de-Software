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
    public partial class FrmDictamenTesis : FrmPadre
    {
        private CDictaminanteDeTesis oDictaminanteDeTesis=new CDictaminanteDeTesis();
        public TextBox CajadeTexto;
        private CDocente oDocente = new CDocente();
        private CTesis oTesis = new CTesis();
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public string aBusqueda;
        private CRequisitoXTramite oRequsitosXTramite;
        public FrmDictamenTesis()
        {
            InitializeComponent();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            oTesis = new CTesis();
            oPlanDeTesis = new CPlanDeTesis();
            oDictaminanteDeTesis = new CDictaminanteDeTesis();
            LlenarDatosCboCodDictamenDeTesis();
        }
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, string codigodocente)
        {
            CDocente docente = new CDocente();
            if (docente.ExisteClavePrimaria(codigodocente))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = docente.ValorAtributo("Nombres");
                tbox2.Text = docente.ValorAtributo("Apellidos");
                //tbox3.Text = docente.ValorAtributo("DNI");

            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear(); //tbox3.Clear();
            }
        }
        /*private void BtnBusquedaDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodDocente;
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtCodDocente.Text);
        }*/
        public void RefrescarTxt()
        {
            TxtApellidosDocente.Text = "";
            TxtNombresDocente.Text = "";
            // TxtDNIDocente.Text = "";
        }
        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtCodDocente.Text);
                //if (oDictaminanteDeTesis.VerificarSiEmitioEvaluacion(CboCodDictaminantes.Text, TxtCodDocente.Text))
                //{
                //    GbxRubrica.Enabled = false;
                //    LblNotificacion.Visible = true;
                //    LblNotificacion.Text = "Usted ya reviso este plan de tesis";
                //}
                //else
                //{
                //    GbxRubrica.Enabled = true;
                //    LblNotificacion.Visible = false;
                //}
                //if (TxtCodDocente.Text == "")
                //    RefrescarTxt();
            }
            catch
            {

            }
        }
        public void ConsultarTesis(TextBox tbox1, string codigotesis)
        {
            CTesis tesis = new CTesis();
            if (tesis.ExisteClavePrimaria(codigotesis))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesis.ValorAtributo("Titulo");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear();
            }
        }

        /*private void BtnBusquedaTesis_Click(object sender, EventArgs e)
        {
            FrmBuscarTesis A = new FrmBuscarTesis();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesis;
            ConsultarTesis(TxtNombreTesis, TxtCodTesis.Text);
        }
        */
        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmBuscarDictaminantes A = new FrmBuscarDictaminantes();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodDictaminantes;
            ConsultarTesis(TxtNombreTesis, TxtCodTesis.Text);
        }
        */
        public void LlenarDatosDocente()
        {
            TxtCodTesis.Text = oDictaminanteDeTesis.MostrarCodTesis(CboCodDictaminantes.Text);
            DataRowView oDataRowView = CboCodDictaminantes.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["CodDictamenDeTesis"] as string;
            }
            CboCodDocente.DataSource = oDictaminanteDeTesis.ListarDocentesDictaminantes(sValue);
            CboCodDocente.DisplayMember = "CodDocente";
            CboCodDocente.ValueMember = "CodDocente";
            //-- dejar el combo sin libro seleccionado
            CboCodDocente.SelectedIndex = -1;
        }
        public void LlenarDatosCboCodDictamenDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodDictaminantes.DataSource = oDictaminanteDeTesis.ListarCodGrupoDictaminantes();
                CboCodDictaminantes.DisplayMember = "CodDictamenDeTesis";
                CboCodDictaminantes.ValueMember = "CodDictamenDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodDictaminantes.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        private void CboCodDictaminantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarDatosDocente();
            }
            catch
            {

            }
        }
        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, CboCodDocente.Text);
                if (oDictaminanteDeTesis.VerificarSiEmitioEvaluacion(CboCodDictaminantes.Text, CboCodDocente.Text))
                {
                    GboRubrica.Enabled = false;
                    LblNotificacion.Visible = true;
                    LblNotificacion.Text = "Usted ya reviso este plan de tesis";
                }
                else
                {
                    GboRubrica.Enabled = true;
                    LblNotificacion.Visible = false;
                }
                if (CboCodDocente.Text == "")
                    RefrescarTxt();
            }
            catch
            {

            }

        }

        private void TxtCodTesis_TextChanged(object sender, EventArgs e)
        {
            DgvInteresados.DataSource = oDictaminanteDeTesis.ListarInteresados(TxtCodTesis.Text);
            DgvTesis.DataSource = oDictaminanteDeTesis.ListarDatosTesis(TxtCodTesis.Text);
        }
    }
}