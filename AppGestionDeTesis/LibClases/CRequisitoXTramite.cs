using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LibClases;
namespace LibClases
{
    public class CRequisitoXTramite : CEntidad
    {
        //=============== ATRIBUTOS =======================
        //--	Todos heredados de CEntidad	----

        //================ METODOS ========================
        //	Constructores	 
        public CRequisitoXTramite() : base("TRequisitoXTramite",true)
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTramite", "CodRequisito" };
        }

        public DataTable ListaPorTramite(string pCodTramite)
        {   //-- retorna una tabla con la lista completa de libros 
            /*
             select c.CodTramite,c.Tipo,a.CodRequisito,TipoRequisito 
from TRequisitoXTramite a,TRequisito b,TTramite c 
where a.CodRequisito=b.CodRequisito and c.CodTramite=a.CodTramite and c.CodTramite='TR0002' 
 
             
             */

            string Consulta = "select c.CodTramite,c.Tipo,b.CodRequisito,TipoRequisito from TRequisitoXTramite a,TRequisito b,TTramite c where a.CodRequisito = b.CodRequisito and c.CodTramite = a.CodTramite and c.CodTramite = '" + pCodTramite + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }


        public DataTable ListarRequisitoXTramite(string pCodTramite)
        {   //-- retorna una tabla con la lista completa de libros 
            string Consulta = "select distinct * from " + aNombreTabla + " where CodTramite= '" + pCodTramite + "' ";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public void GuardarCambiosRequisitosXTramite(string pCodTramite, List<string> listaderequisitos)
        {
            string Consulta = "delete from " + aNombreTabla + " where CodTramite= '" + pCodTramite + "' ";
            aConexion.EjecutarComando(Consulta);
            for (int i = 0; i < listaderequisitos.Count; i++)
            {
                Consulta = " insert into TRequisitoXTramite values('" + pCodTramite + "', '" + listaderequisitos[i] + "') ";
                aConexion.EjecutarComando(Consulta);

            }
            //aConexion.EjecutarSelect(Consulta);
        }
        public DataTable ListarRequisitoXTramiteNombres(string pCodTramite)
        {
            string Consulta = "select c.CodTramite,c.Tipo,a.CodRequisito,TipoRequisito from " +
                aNombreTabla + "  a,TRequisito b,TTramite c " +
"where a.CodRequisito = b.CodRequisito and c.CodTramite = a.CodTramite and c.CodTramite ='" + pCodTramite + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
    
}
