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
    public partial class FrmNombrarDictaminantescs : FrmPadre
    {
        private CDictaminanteDeTesis oDictaminanteDeTesis;
        public FrmNombrarDictaminantescs()
        {
            InitializeComponent();
            oDictaminanteDeTesis = new CDictaminanteDeTesis();
            LlenarTesisPendientes();
            InicializarCamposCboNroDocente();
        }
        public void InicializarCamposCboNroDocente()
        {
            GboEvaluador1.Visible = true;
            GboEvaluador2.Visible = false;
            GboEvaluador3.Visible = false;

        }
        private void CboNroDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboNroDocente.Text == "1")
            {
                GboEvaluador1.Visible = true;
                GboEvaluador2.Visible = false;
                GboEvaluador3.Visible = false;

            }
            if (CboNroDocente.Text == "2")
            {
                GboEvaluador1.Visible = true;
                GboEvaluador2.Visible = true;
                GboEvaluador3.Visible = false;
            }
            if (CboNroDocente.Text == "3")
            {
                GboEvaluador1.Visible = true;
                GboEvaluador2.Visible = true;
                GboEvaluador3.Visible = true;
            }
        }
        public void LlenarTesisPendientes()
        {
            DgvTesisSinDictaminantes.DataSource = oDictaminanteDeTesis.TesisPendientesDeDictamen();
            DgvTesisSinDictaminantes.Columns["CodTesis"].Visible = false;
            DgvTesisSinDictaminantes.Columns["CodEvaluacionPlanDeTesis"].Visible = false;
            /*
            DgvTesisPendientesDeCR.Columns["CodDictamenDeTesis"].Visible = false;
            DgvTesisPendientesDeCR.Columns["CodSustentacionOral"].Visible = false;
            */
        }
        private void btnBuscarDocente1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente1;
        }

        private void btnBuscarDocente2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente2;
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;
        }
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, TextBox tbox3, string codigotesista)
        {
            CDocente docente = new CDocente();
            if (codigotesista != "")
            {
                if (docente.ExisteClavePrimaria(codigotesista))
                {
                    //-- Recuperar atributos, el primer atributo es la clave 
                    tbox1.Text = docente.ValorAtributo("Nombres");
                    tbox2.Text = docente.ValorAtributo("Apellidos");
                    tbox3.Text = docente.ValorAtributo("Dni");
                }
                else
                {
                    tbox1.Clear(); tbox2.Clear(); tbox3.Clear();
                }
            }
        }

        private void txtCodDocente2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente2, TxtApellidosDocente2, TxtDNIDocente2, txtCodDocente2.Text);
        }

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, txtCodDocente.Text);
        }

        private void txtCodDocente1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente1, TxtApellidosDocente1, TxtDNIDocente1, txtCodDocente1.Text);
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisSinDictaminantes.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtNroExpediente.Text = DgvTesisSinDictaminantes.CurrentRow.Cells["NroExpediente"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                //DgvInteresados.DataSource = oDictaminanteDeTesis.ListarInteresados(TxtCodTesis.Text);
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }

            //
            //TxtCodTesis.Text = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oDictaminanteDeTesis.GenerarCodigoNombrarComisionRevisora();


            TxtCodDictaminantesDeTesis.Text = codigo;
        }

        

        private void BtnNombrarDictaminante_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((TxtCodDictaminantesDeTesis.Text == "") || (txtCodDocente.Text == "") || (txtCodDocente1.Text == "") || (txtCodDocente2.Text == "")))
                {
                    //AGREGAR EXPEDIENTE
                    oDictaminanteDeTesis.UpdateExpediente(TxtNroExpediente.Text, TxtCodDictaminantesDeTesis.Text);

                    //Agregamos Docentes a la Comision Revisora
                    List<string> ComisionRevisora = new List<string>();
                    ComisionRevisora.Add(txtCodDocente.Text);
                    ComisionRevisora.Add(txtCodDocente1.Text);
                    ComisionRevisora.Add(txtCodDocente2.Text);
                    oDictaminanteDeTesis.AgregarDocentesDictaminantes(ComisionRevisora, TxtCodDictaminantesDeTesis.Text);
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    LlenarTesisPendientes();
                }
                else
                {
                    MessageBox.Show("GENERE CODIGO PARA LA EVALUACION DE PLAN DE TESIS", "ALERTA");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
    }
}
