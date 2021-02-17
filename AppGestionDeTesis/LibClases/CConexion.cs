using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class  CConexion
    {
        //============== ATRIBUTOS =============================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        //============== METODOS ===============================
        //------------ Constructor -----------------------------
        public CConexion()
        { //-- iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            // realizar la conexion
            string CadenaConexion = "Data Source=localhost;Initial Catalog = DBGestionTesis; Integrated Security = SSPI; ";
            //string CadenaConexion = "Data Source=LAPTOP-T0A9SMMC;Initial Catalog = DBGestionTesis; Integrated Security = SSPI; ";
            //string CadenaConexion = "Data Source=sql5102.site4now.net;Initial Catalog=DB_A6F90B_jhonTACUSI;User Id=DB_A6F90B_jhonTACUSI_admin;Password=cocodrilo10";
            aConexion = new SqlConnection(CadenaConexion);
        }
        //----------- Propiedades ----------------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        //----------------------------------------------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        //----------------------------------------------------
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //------------- Servicios ------------------------------
        // --- Metodos para ejecutar comandos sql server
        // --- Devuelve el resultado en la tabla cero del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        { // metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // -------------------------------------------------------------------
        // --- Metodo para ejecutar instrucciones DML. No retorna resultado.
        // -------------------------------------------------------------------
        public virtual void EjecutarComando(string pComando)
        { // metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }

    }
}
