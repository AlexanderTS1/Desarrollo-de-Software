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
    public partial class FrmTesis : FrmPadre
    {
        public FrmTesis()
        {
            InitializeComponent();
            IniciarEntidad(new CTesis());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodTesis.Text, TxtTituloT.Text, TxtEspecialidad.Text, TxtEstado.Text};
        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            TxtTituloT.Text = aEntidad.ValorAtributo("Titulo");
            TxtEspecialidad.Text = aEntidad.ValorAtributo("especialidad");
            TxtEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        /* override void InicializarAtributoClave()
        {
            TxtCodTesis.Text = "";
        }*/
        public override void InicializarAtributosNoClave()
        {
            TxtTituloT.Text = "";
            TxtEspecialidad.Text = "";
            TxtEstado.Text = "";
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

        public override void ProcesarClave()
        {
            //-- Recuperar atributos, el primer atributo es la clave 
            string[] Atributos = AsignarValoresAtributos();
            // ----- Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //-- Registro existente, Recuperar Atributos y mostrarlos 
                MostrarDatos();
                aEntidad.Nuevo = false;
                TxtCodTesis.Enabled = false;
            }
            else
            {   //-- Registro nuevo, inicializar atributos no clave 
                InicializarAtributosNoClave();
            }
        }

        public override void InicializarAtributoClave()
        {
            TxtCodTesis.Enabled = true;
            TxtCodTesis.Text = "";
        }
        // ================= EVENTOS ==============================
        private void TxtCodTesis_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmTesis_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        
    }
}
