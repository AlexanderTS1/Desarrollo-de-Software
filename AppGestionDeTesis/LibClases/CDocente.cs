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
	public class CDocente : CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CDocente() : base("TDocente",false)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodDocente", "DNI", "Apellidos", "Nombres","GradoAcademico","categoria", "Correo", "NumeroCelular", "Cargo" };
		}
		public DataTable Busqueda(string Consulta)
		{   //-- retorna una tabla con la lista completa de libros 
			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}

	}
}
