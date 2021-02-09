using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class FrmDocumentación : FrmPadre
    {
        public FrmDocumentación()
        {
            InitializeComponent();
            //IniciarEntidad(new CDocumentacion());
        }
        /*//============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesista.Text, TxtDNI.Text, TxtApellidos.Text, TxtNombres.Text, TxtCorreo.Text, TxtTelefono.Text, CbxGradoAcademico.Text };
        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellido");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombre");
            TxtCorreo.Text = aEntidad.ValorAtributo("CorreoElectronico");
            TxtTelefono.Text = aEntidad.ValorAtributo("telefono");
            CbxGradoAcademico.Text = aEntidad.ValorAtributo("GradoAcademico");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        
        public override void InicializarAtributosNoClave()
        {
            TxtDNI.Text = "";
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            TxtTelefono.Text = "";
            CbxGradoAcademico.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            DgvTesista.DataSource = aEntidad.ListaGeneral();

        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodTesista.Text.Trim() != "" && TxtApellidos.Text.Trim() != "")
                return true;
            else
                return false;
        }

        public override void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave 
            string[] Atributos = AsignarValoresAtributos();
            // ----- Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //-- Registro existente, Recuperar Atributos y mostrarlos 
                MostrarDatos();
                aEntidad.Nuevo = false;
                TxtCodTesista.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

        public override void InicializarAtributoClave()
        {
            TxtCodTesista.Enabled = true;
            TxtCodTesista.Text = "";
        }
        // ================= EVENTOS ==============================
        private void TxtCodTesista_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmTesista_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }*/
    }
}
