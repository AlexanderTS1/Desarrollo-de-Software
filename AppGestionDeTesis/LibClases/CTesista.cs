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
		public CTesista() : base("TTesista")
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodTesista", "Nombre", "Apellido", "DNI", "telefono", "CorreoElectronico", "GradoAcademico" };
		}

	}
}
