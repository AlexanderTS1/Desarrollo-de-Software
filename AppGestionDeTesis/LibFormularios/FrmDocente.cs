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
    public partial class FrmDocente : FrmPadre
    {
        public FrmDocente()
        {
            InitializeComponent();
            IniciarEntidad(new CDocente());
        }
        //============= REDEFINICION DE LOS METODOS VIRTUALES ====================
        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodDocente.Text, TxtDNI.Text, TxtApellidos.Text, TxtNombres.Text,TxtGradoAcademico.Text,TxtCategoria.Text, TxtCorreo.Text, TxtTelefono.Text, CbxCargo.Text };
        }
        //-----------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        { //-- muestra la informacion contenida en el dataset de CLibro
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            TxtApellidos.Text = aEntidad.ValorAtributo("Apellidos");
            TxtNombres.Text = aEntidad.ValorAtributo("Nombres");
            TxtGradoAcademico.Text = aEntidad.ValorAtributo("GradoAcademico");
            TxtCategoria.Text = aEntidad.ValorAtributo("Categoria");
            TxtCorreo.Text = aEntidad.ValorAtributo("Correo");
            TxtTelefono.Text = aEntidad.ValorAtributo("NumeroCelular");
            CbxCargo.Text = aEntidad.ValorAtributo("Cargo");
        }
        //-----------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodDocente.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtDNI.Text = "";
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            TxtGradoAcademico.Text = "";
            TxtCategoria.Text = "";
            TxtTelefono.Text = "";
            CbxCargo.Text = "";
        }
        //-----------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        { //-- Mostrar todos los libros de la tabla en el grid
            DgvDocente.DataSource = aEntidad.ListaGeneral();

        }
        //-----------------------------------------------------------
        //-- verificar los campos obligatorios(codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodDocente.Text.Trim() != "" && TxtApellidos.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ================= EVENTOS ==============================
        private void TxtCodDocente_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            aEntidad.Eliminar();
=======
        private void TxtCodDocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

>>>>>>> 1ba73fb8059f3ca4e67bfd4acca729dc0f204279
        }
    }
}
