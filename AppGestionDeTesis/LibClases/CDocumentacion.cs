using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    class CDocumentacion:CEntidad
    {
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CDocumentacion() : base("TDocumentacion", true)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "NroExpediente", "Estado", "FechaInicio", "TipoTramite", "CodTesis" };
		}
		//------ Métodos especificos de Registro ----------------
		/*public DataTable ListaEjemplaresDeLibro(string pCodLibro)
		{ //-- lista los ejemplares que le corresponden a un libro determinado
			string Consulta = "select * from TEjemplar where CodLibro= '"
		   + pCodLibro + "'";
			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}*/
	}
}
