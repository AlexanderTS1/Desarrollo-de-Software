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
            InicializarGboDesctivado();
            oTramite = new CTramite();
            oRequsitosXTramite = new CRequisitoXTramite();
            oDocente = new CDocente();
            oTesis = new CTesis();
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
            GboDocenteAsesor.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboNroTesista.Text == "1")
            {
                GboTesista1.Visible = true;
                GboTesista2.Visible = false;
                GboTesista3.Visible = false;

            }
            if (CboNroTesista.Text=="2")
            {
                GboTesista1.Visible = true; 
                GboTesista2.Visible = true;
                GboTesista3.Visible = false;
            }
            if (CboNroTesista.Text == "3")
            {
                GboTesista1.Visible = true;
                GboTesista2.Visible = true;
                GboTesista3.Visible = true;
            }
        }
        public void InicializarGboDesctivado()
        {
            GboTesista1.Enabled = false;
            GboTesista2.Enabled = false;
            GboTesista3.Enabled = false;
            GboDocenteAsesor.Enabled = false;
            CboNroTesista.Enabled = false;
        }
        private void RdbCompleto_CheckedChanged(object sender, EventArgs e)
        {
            GboTesista1.Enabled = true;
            GboTesista2.Enabled = true;
            GboTesista3.Enabled = true;
            GboDocenteAsesor.Enabled = true;
            CboNroTesista.Enabled = true;
        }
        private void RdbImcompleto_CheckedChanged(object sender, EventArgs e)
        {
            GboTesista1.Enabled = false;
            GboTesista2.Enabled = false;
            GboTesista3.Enabled = false;
            GboDocenteAsesor.Enabled = false;
            CboNroTesista.Enabled = false;
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
        private void CboCodTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenarRequisitosXTramite();
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool VerificarRequisitos()
        {
            bool cumpletodoslosrequisitos = true;
            for (int j = 0; j < ChlRequisitosXTramite.Items.Count; j++)
            {
                DataRowView drv = ChlRequisitosXTramite.Items[j] as DataRowView;
                if (!ChlRequisitosXTramite.GetItemChecked(j))
                {
                    cumpletodoslosrequisitos = false;
                }

            }
            return cumpletodoslosrequisitos;
        }
        private void BtnIniciarTramite_Click(object sender, EventArgs e)
        {
            try
            {

                if (VerificarRequisitos())
                {
                    //Agregar a la tbla tesis
                    //insert into TTesis values ('tema','coddocente','titulo','','')
                    List<string> CadenaTesis = new List<string>();
                    CadenaTesis.Add(LblCodTesis.Text);
                    CadenaTesis.Add(TxtEspecialidad.Text);
                    CadenaTesis.Add(TxtTitulo.Text);
                    CadenaTesis.Add(txtCodDocente.Text);
                    CadenaTesis.Add("Por revisar");
                    oTesis.AgregarTesis(CadenaTesis);

                    MessageBox.Show("Número de Tesis " + LblCodTesis.Text + " Estado: Por revisar");

                    //Agregar a la tabla TesisXTesista
                    List<string> CadenaTesisXTesista = new List<string>();
                    if (CboNroTesista.Text == "1")
                    {
                        CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                    }
                    if (CboNroTesista.Text == "2")
                    {
                        CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                        CadenaTesisXTesista.Add(TxtCodTesista2.Text);
                    }
                    if (CboNroTesista.Text == "3")
                    {
                        CadenaTesisXTesista.Add(TxtCodTesista1.Text);
                        CadenaTesisXTesista.Add(TxtCodTesista2.Text);
                        CadenaTesisXTesista.Add(TxtCodTesista3.Text);
                    }
                    oTesis.GuardarCambiosTesisPorTesista(LblCodTesis.Text, CadenaTesisXTesista);


                    List<string> IniciarTramiteInscripcionPlanDeTesis = new List<string>();
                    DataRowView oDataRowView = CboTipoTramite.SelectedItem as DataRowView;
                    string codTramite = string.Empty;

                    if (oDataRowView != null)
                    {
                        codTramite = oDataRowView.Row["CodTramite"] as string;
                    }
                    string CodTrInscripcionDeTemaDeTesis;

                    CodTrInscripcionDeTemaDeTesis = oTesis.GenerarCodigoDeInscripcionDeTemaDeTesis();
                    MessageBox.Show("Número de Solicitud de Inscripcion: " + CodTrInscripcionDeTemaDeTesis);
                    IniciarTramiteInscripcionPlanDeTesis.Add(CodTrInscripcionDeTemaDeTesis);
                    IniciarTramiteInscripcionPlanDeTesis.Add(codTramite);
                    IniciarTramiteInscripcionPlanDeTesis.Add(LblCodTesis.Text);
                    oTesis.AgregarASolitudInscripcion(IniciarTramiteInscripcionPlanDeTesis);
                    MessageBox.Show("Trámite " + codTramite + " Fue Agregado");
                }
                else
                {
                    MessageBox.Show("Es obligatorio tener requisitos completos");
                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "ERROR, no se puede iniciar solitud de Inscripción");
            }
        }

        private void BtnBuscarDocente_Click(object sender, EventArgs e)
        {
            FrmBuscarDocente A = new FrmBuscarDocente();
            AddOwnedForm(A);
            A.Show();
            A.CajadeTexto = txtCodDocente;

        }

        private void FrmInscripcion1_Load(object sender, EventArgs e)
        {
            //Inicializar variable global para transferir dato del form hijo
            //codigoBusquedaDocente = txtCodDocente;
            //codigoBusquedaTesista1 = TxtCodTesista1;
            //codigoBusquedaTesista2 = TxtCodTesista2;
            //codigoBusquedaTesista3 = TxtCodTesista3;
        }

        private void txtCodDocente_TextChanged(object sender, EventArgs e)
        {
            ConsultarDocente(TxtNombresDocente, TxtApellidosDocente, txtCodDocente.Text);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string codigo = oTesis.GenerarCodigoTesis();


            LblCodTesis.Text = codigo;
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

        private void ChlRequisitosXTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(VerificarRequisitos())
            {
                GbxTramiteDeInscripcion.Visible = true;
            }
            else
            {
                GbxTramiteDeInscripcion.Visible = false;
            }
            */
        }

        
    }
}