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
        public FrmInscripcion()
        {
            InitializeComponent();
            IniciarEntidad(new CTesis());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesis.Text, TxtTituloT.Text, TxtEspecialidad.Text, TxtEstado.Text, TxtCodTesista1.Text };
        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            TxtTituloT.Text = aEntidad.ValorAtributo("Titulo");
            TxtEspecialidad.Text = aEntidad.ValorAtributo("especialidad");
            TxtEstado.Text = aEntidad.ValorAtributo("Estado");
            TxtCodTesista1.Text = aEntidad.ValorAtributo("CodTesista");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodTesis.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtTituloT.Text = "";
            TxtEspecialidad.Text = "";
            TxtEstado.Text = "";
            TxtCodTesista1.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            DgvTesis.DataSource = aEntidad.ListaGeneral();

        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodTesis.Text.Trim() != "" && TxtTituloT.Text.Trim() != "")
                return true;
            else
                return false;
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

        
    }
}
