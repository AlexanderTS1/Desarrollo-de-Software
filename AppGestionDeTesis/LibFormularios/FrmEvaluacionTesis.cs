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
    public partial class FrmEvaluacionTesis : FrmPadre
    {
        public TextBox CajadeTexto;
        private CDocente oDocente = new CDocente();
        private CTesista cTesista = new CTesista();
        private CTesis oTesis = new CTesis();
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public string aBusqueda;
        public FrmEvaluacionTesis()
        {
            InitializeComponent();
            oDocente = new CDocente();
            oTesis = new CTesis();
            cTesista = new CTesista();
            oPlanDeTesis = new CPlanDeTesis();
            LlenarDatosCboCodRevisionDeTesis();
        }

        public void LlenarDatosCboCodRevisionDeTesis()
        {
            try
            {
                //-- muestra la lista de libros en el combo
                CboCodComisionRevisora.DataSource = oPlanDeTesis.ListarCodComisionRevisora();
                CboCodComisionRevisora.DisplayMember = "CodEvaluacionPlanDeTesis";
                CboCodComisionRevisora.ValueMember = "CodEvaluacionPlanDeTesis";
                //-- dejar el combo sin libro seleccionado
                CboCodComisionRevisora.SelectedIndex = -1;
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

        private void txtCodTesis_TextChanged(object sender, EventArgs e)
        {
            ConsultarTesis(TxtNombreTesis, TxtCodTesis.Text);
        }

        private void BtnBusquedaTesis_Click(object sender, EventArgs e)
        {
            FrmBuscarTesis A = new FrmBuscarTesis();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesis;
            ConsultarTesis(TxtNombreTesis, TxtCodTesis.Text);
        }
        /*public void ConsultarDocente(TextBox tbox1, TextBox tbox2, string codigodocente)
        {
            CDocente docente = new CDocente();
            if (docente.ExisteClavePrimaria(codigodocente))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = docente.ValorAtributo("Nombres");
                tbox2.Text = docente.ValorAtributo("Apellidos");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear();
            }
        }*/

        /*private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, txtCodDocente.Text);
        }*/

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, CboCodDocente.Text);
        }
        public bool ComprobarDuplicidadDeTesistas(TextBox txb1, TextBox txb2)
        {
            if ((txb1.Text == txb2.Text))
            {
                MessageBox.Show("El codigo ya ha sido insertado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ConsultarEstudiante(TextBox tbox1, TextBox tbox2, string codigotesista)
        {
            CTesista tesista = new CTesista();
            if (tesista.ExisteClavePrimaria(codigotesista))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = tesista.ValorAtributo("Nombre");
                tbox2.Text = tesista.ValorAtributo("Apellido");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear();
            }
        }

        private void BtnBuscarTesista1_Click(object sender, EventArgs e)
        {
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista1;


            ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtCodTesista1.Text);
        }

        private void BtnBuscarTesista2_Click(object sender, EventArgs e)
        {
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista2;
            ConsultarEstudiante(TxtNombreTesista2, TxtApeTesista2, TxtCodTesista2.Text);
            ComprobarDuplicidadDeTesistas(TxtCodTesista1, TxtCodTesista2);
        }

        private void BtnBuscarTesista3_Click(object sender, EventArgs e)
        {
            FrmBuscarTesista A = new FrmBuscarTesista();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = TxtCodTesista3;
            ConsultarEstudiante(TxtNombreTesista3, TxtApeTesista3, TxtCodTesista3.Text);
            ComprobarDuplicidadDeTesistas(TxtCodTesista2, TxtCodTesista3);
        }

        private void TxtCodTesista1_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista1, TxtApeTesista1, TxtCodTesista1.Text);
        }

        private void TxtCodTesista2_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista2, TxtApeTesista2, TxtCodTesista2.Text);
        }

        private void TxtCodTesista3_TextChanged(object sender, EventArgs e)
        {
            ConsultarEstudiante(TxtNombreTesista3, TxtApeTesista3, TxtCodTesista3.Text);
        }
        public double Promedio()
        {
            double promedio = (double.Parse(NudIdentificacionProblema.Value.ToString()) + double.Parse(NudHipotesis.Value.ToString()) + double.Parse(NudAlcanceResultado.Value.ToString()) + double.Parse(NudMetodologia.Value.ToString()) + double.Parse(NudRevisionBibliografica.Value.ToString()) + double.Parse(NudRecursoPresupuesto.Value.ToString()) + double.Parse(NudImpacto.Value.ToString()) + double.Parse(NudOrganizacionDocumentoDelPlan.Value.ToString()) + double.Parse(NudPresentacionGeneralDelPlan.Value.ToString()) + double.Parse(NudPresentacionSustentacionPlan.Value.ToString())) / 10;
            return promedio;
        }

        private void txtPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void NudIdentificacionProblema_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudHipotesis_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudAlcanceResultado_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudMetodologia_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudRevisionBibliografica_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudRecursoPresupuesto_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudImpacto_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudOrganizacionDocumentoDelPlan_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudPresentacionGeneralDelPlan_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void NudPresentacionSustentacionPlan_ValueChanged(object sender, EventArgs e)
        {
            double prom = Promedio();
            txtPromedio.Text = prom.ToString();
        }

        private void CboCodComisionRevisora_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarDatosDocenteRevisor();
            }
            catch
            {

            }
        }
        public void LlenarDatosDocenteRevisor()
        {
            TxtCodTesis.Text = oPlanDeTesis.MostrarCodTesis(CboCodComisionRevisora.Text);
            DataRowView oDataRowView = CboCodComisionRevisora.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["CodEvaluacionPlanDeTesis"] as string;
            }
            CboCodDocente.DataSource = oPlanDeTesis.ListarDocenteComisionRevisora(sValue);
            CboCodDocente.DisplayMember = "CodDocente";
            CboCodDocente.ValueMember = "CodDocente";
            //-- dejar el combo sin libro seleccionado
            CboCodDocente.SelectedIndex = -1;
        }
        /// <summary>
        /// 
        /// </summary>
        public void RefrescarTxt()
        {
            TxtApellidosDocente.Text = "";
            TxtNombresDocente.Text = "";
        }
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, string codigotesista)
        {
            CDocente docente = new CDocente();
            if (codigotesista != "")
            {
                if (docente.ExisteClavePrimaria(codigotesista))
                {
                    //-- Recuperar atributos, el primer atributo es la clave 
                    tbox1.Text = docente.ValorAtributo("Nombres");
                    tbox2.Text = docente.ValorAtributo("Apellidos");
                }
                else
                {
                    tbox1.Clear(); tbox2.Clear();
                }
            }

        }
        private void CboCodDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, CboCodDocente.Text);
                if (oPlanDeTesis.VerificarSiEmitioEvaluacion(CboCodComisionRevisora.Text, CboCodDocente.Text))
                {
                    GbxRubrica.Enabled = false;
                    LblNotificacion.Visible = true;
                    LblNotificacion.Text = "Usted ya reviso este plan de tesis";
                }
                else
                {
                    GbxRubrica.Enabled = true;
                    LblNotificacion.Visible = false;
                }
                if (CboCodDocente.Text == "")
                    RefrescarTxt();
            }
            catch
            {

            }
        }

        
    }
}
