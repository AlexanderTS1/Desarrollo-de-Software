﻿using System;
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
    public partial class FrmNombrarComisionRevisora : FrmPadre
    {
        public TextBox CajadeTexto;
        private CDocente oDocente = new CDocente();
        private CTesis oTesis = new CTesis();
        private CPlanDeTesis oPlanDeTesis = new CPlanDeTesis();
        public string aBusqueda;
        private CRequisitoXTramite oRequsitosXTramite;
        public FrmNombrarComisionRevisora()
        {
            InitializeComponent();
            InicializarCamposCboNroDocente();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            CboNroDocente.SelectedIndex = 0;
            oTesis = new CTesis();
            oPlanDeTesis = new CPlanDeTesis();
            LlenarTesisPendientes();
        }
        public void InicializarCamposCboNroDocente()
        {
            txtCodDocente1.Enabled = true;
            txtCodDocente2.Enabled = true;
            btnBuscarDocente1.Enabled = true;
            btnBuscarDocente2.Enabled = true;

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
        public void ConsultarDocente(TextBox tbox1, TextBox tbox2, TextBox tbox3, TextBox tbox4, string codigodocente)
        {
            CDocente docente = new CDocente();
            if (docente.ExisteClavePrimaria(codigodocente))
            {
                //MessageBox.Show("Codigo encontrado", "Se actualizaron los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //-- Recuperar atributos, el primer atributo es la clave 
                tbox1.Text = docente.ValorAtributo("Nombres");
                tbox2.Text = docente.ValorAtributo("Apellidos");
                tbox3.Text = docente.ValorAtributo("DNI");
                tbox4.Text = docente.ValorAtributo("Categoria");
            }
            else
            {
                //MessageBox.Show("No se pudo encontrar el codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox1.Clear(); tbox2.Clear(); tbox3.Clear(); tbox4.Clear();
            }
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, TxtCategoriaDocente, txtCodDocente.Text);
        }

        private void btnBuscarDocente1_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente1;

            ConsultarDocente(TxtNombresDocente1, TxtApellidosDocente1, TxtDNIDocente1, TxtCategoriaDocente1, txtCodDocente1.Text);
        }

        private void btnBuscarDocente2_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente2;
            ConsultarDocente(TxtNombresDocente2, TxtApellidosDocente2, TxtDNIDocente2, TxtCategoriaDocente2, txtCodDocente2.Text);
        }

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, TxtDNIDocente, TxtCategoriaDocente, txtCodDocente.Text);
        }

        private void txtCodDocente1_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente1, TxtApellidosDocente1, TxtDNIDocente1, TxtCategoriaDocente1, txtCodDocente1.Text);
        }

        private void txtCodDocente2_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente2, TxtApellidosDocente2, TxtDNIDocente2, TxtCategoriaDocente2, txtCodDocente2.Text);
        }


        //-----------------------------------------------------------
        public override void Grabar()
        { //-- al grabar un nuevo ejemplar, el formulario queda listo para

            //-- INSERTAR el siguiente registro

            try
            {
                if (EsRegistroValido())
                { //-- Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //-- Inicializar el formulario

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();

                }
                else
                    MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO",
                    "ALERTA");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }

        private void BtnRealizarAct_Click(object sender, EventArgs e)
        {
            Grabar();
        }
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oPlanDeTesis.GenerarCodigoNombrarComisionRevisora();


            TxtCodEvaluacionPlanDeTesis.Text = codigo;
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

        private void BtnCargar_Click(object sender, EventArgs e)
        {

            try
            {
                //int filat= DgvTramitesDeInscripcion.CurrentRow.Index;
                TxtCodTesis.Text = DgvTesisSinEvaluadores.CurrentRow.Cells["CodTesis"].Value.ToString();
                TxtNroExpediente.Text = DgvTesisSinEvaluadores.CurrentRow.Cells["NroExpediente"].Value.ToString();
                //DgvDocentes.DataSource= oPlanDeTesis.ListarTesistasXTesis();
                //DgvInteresados.DataSource = oPlanDeTesis.ListarInteresados(TxtCodTesis.Text);
            }
            catch
            {
                MessageBox.Show("NO HA SELECCIONADO", "ERROR");
            }

        }
        public void LlenarTesisPendientes()
        {
            DgvTesisSinEvaluadores.DataSource = oPlanDeTesis.TesisPendientesDeDCR();
            DgvTesisSinEvaluadores.Columns["CodTesis"].Visible = false;
            DgvTesisSinEvaluadores.Columns["CodEvaluacionPlanDeTesis"].Visible = false;
            /*
            DgvTesisPendientesDeCR.Columns["CodDictamenDeTesis"].Visible = false;
            DgvTesisPendientesDeCR.Columns["CodSustentacionOral"].Visible = false;
            */
        }
        private void BtnEnviarProveido_Click(object sender, EventArgs e)
        {
            try
            {
                if (!((TxtCodEvaluacionPlanDeTesis.Text == "") || (txtCodDocente.Text == "") || (txtCodDocente1.Text == "") || (txtCodDocente2.Text == "")))
                {
                    //AGREGAR EXPEDIENTE
                    oPlanDeTesis.UpdateExpediente(TxtNroExpediente.Text, TxtCodEvaluacionPlanDeTesis.Text);

                    //Agregamos Docentes a la Comision Revisora
                    List<string> ComisionRevisora = new List<string>();
                    ComisionRevisora.Add(txtCodDocente.Text);
                    ComisionRevisora.Add(txtCodDocente1.Text);
                    ComisionRevisora.Add(txtCodDocente2.Text);
                    oPlanDeTesis.AgregarDocentesCR(ComisionRevisora, TxtCodEvaluacionPlanDeTesis.Text);
                    MessageBox.Show("Operación se completó EXITOSAMENTE", "CONFIRMACION");
                    LlenarTesisPendientes();
                }
                else
                {
                    MessageBox.Show("Generar código para la evaluación de plan de tesis", "RECUERDA");
                }

            }
            catch
            {
                MessageBox.Show("El código de la revisión de plan de tesis SE REPITE", "ERROR");
            }
        }


        /*
private void txtCodTesis_TextChanged(object sender, EventArgs e)
{
ConsultarTesis(txtNombreTesis, txtCodTesis.Text);
}
private void BtnBusquedaTesis_Click(object sender, EventArgs e)
{
FrmBuscarTesis A = new FrmBuscarTesis();
AddOwnedForm(A);
A.Show();
A.CajadeTexto = txtCodTesis;
ConsultarTesis(txtNombreTesis, txtCodTesis.Text);
}
*/

    }





}