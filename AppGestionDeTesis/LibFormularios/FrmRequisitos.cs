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
    public partial class FrmRequisitos : FrmPadre    {
        public FrmRequisitos()
        {
            InitializeComponent();
            IniciarEntidad(new CRequisito());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodRequsito.Text, TxtNombre.Text};
        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            TxtNombre.Text = aEntidad.ValorAtributo("Nombre");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        /* override void InicializarAtributoClave()
        {
            TxtCodTesis.Text = "";
        }*/
        public override void InicializarAtributosNoClave()
        {
            TxtNombre.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            DgvRequisito.DataSource = aEntidad.ListaGeneral();

        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodRequsito.Text.Trim() != "" && TxtNombre.Text.Trim() != "")
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
                TxtCodRequsito.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

        public override void InicializarAtributoClave()
        {
            TxtCodRequsito.Enabled = true;
            TxtCodRequsito.Text = "";
        }
        // ================= EVENTOS ==============================
        private void TxtCodRequsito_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmRequsitos_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        
    }
}
