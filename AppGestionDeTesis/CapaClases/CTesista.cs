using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LibClases
{
	public class CTesista : CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CTesista() : base("Docente", false)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodDocente", "ApellidoPaterno", "ApellidoMaterno", "Nombres", "Categoria", "Departamento" };
		}

	}
}
