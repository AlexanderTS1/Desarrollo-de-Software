using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibClases;
namespace LibClases
{
	public class CRequisito : CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CRequisito() : base("TRequisitos", false)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodRequito", "TipoRequisito", "Descripcion" };
		}
		public DataTable ListarTodosLosRequisitos()
		{   //-- retorna una tabla con la lista completa de libros 
			string Consulta = "select distinct * from TRequisitos";
			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
	}
}
