using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibClases;
namespace LibClases
{
	public class CDocente : CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CDocente() : base("TDocente")
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodDocente", "DNI", "Apellidos", "Nombres", "Correo", "NumeroCelular", "Cargo" };
		}

	}
}
