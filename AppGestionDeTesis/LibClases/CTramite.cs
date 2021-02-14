using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LibClases
{
    public class CTramite:CEntidad
    {
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CTramite() : base("TTramite", true)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodTramite", "Tipo" };
		}
		//------ Métodos especificos de Registro ----------------
		public DataTable ListaTramitesDeInscripcionDeTesis()
		{

			string consulta = "select * from TIniciarTramiteInscripcionPlanDeTesis where Estado='RECIBIDO'";
			aConexion.EjecutarSelect(consulta);
			return aConexion.Datos.Tables[0];
		}
	}
}
