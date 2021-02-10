using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LibClases
{
	public class CTesis : CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CTesis() : base("TTesis",false)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodTesis", "Titulo", "especialidad", "Estado", "CodTesista"};
		}

        public void AgregarTesis(List<string> cadenaTesis)
        {
            //insert into TTesis values ('tema','coddocente','titulo','','')
            string Consulta = "insert into TTesis values ('" + cadenaTesis[0] + "','" + cadenaTesis[1] + "','" + cadenaTesis[2] + "','" + cadenaTesis[3] + "','TESIS PREINSCRITA','NINGUNA') ";
            aConexion.EjecutarComando(Consulta);
        }
        public string ObtenerDatos(List<string> cadenaTesis, string pNombreCampo)
        {
            string consulta = "select CodTesis from TTesis " +
                "where Tema = '" + cadenaTesis[0] + "'and CodDocente = '" + cadenaTesis[1] + "' and " +
                "Titulo = '" + cadenaTesis[2] + "' and Estado = 'TESIS PREINSCRITA' and " +
                "Observaciones = 'NINGUNA'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        public void AgregarTramiteDeInscripcionDePlanDeTesis(List<string> cadenaInscripciondePlanDeTesis)
        {
            //insert into TIniciarTramiteInscripcionPlanDeTesis values ('TR0001','124813','124219','150409','100005','NINGUNA')
            string consulta = "insert into TIniciarTramiteInscripcionPlanDeTesis values ('" + cadenaInscripciondePlanDeTesis[0] + "','" + cadenaInscripciondePlanDeTesis[1] + "','" + cadenaInscripciondePlanDeTesis[2] + "','RECIBIDO','" + cadenaInscripciondePlanDeTesis[3] + "')";
            aConexion.EjecutarComando(consulta);


        }
        public string GenerarCodigoTesis()
        {
            try
            {
                string codigo;
                string consulta = "select TOP 1 CodTesis from TTesis ORDER BY CodTesis DESC";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "700000";
            }
        }
        public string GenerarCodigoTrInscripcionDeTemaDeTesis()
        {
            try
            {
                string codigo;
                string consulta = "select TOP 1 CodTramITTesis from TIniciarTramiteInscripcionPlanDeTesis ORDER BY CodTramITTesis DESC";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodTramITTesis"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "800000";
            }
        }
        public void GuardarCambiosTesisXTesista(string pCodTesis, List<string> listaTesistas)
        {
            string Consulta = "delete from TTesisXTesista where CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(Consulta);
            for (int i = 0; i < listaTesistas.Count; i++)
            {
                Consulta = " insert into TTesisXTesista values('" + pCodTesis + "', '" + listaTesistas[i] + "') ";
                aConexion.EjecutarComando(Consulta);

            }
            //aConexion.EjecutarSelect(Consulta);
        }
        public DataTable ListarTesisXTesista()
        {
            string Consulta = "select * from TTesisXTesista";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
