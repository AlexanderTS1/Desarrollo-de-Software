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
        public CTesis() : base("TTesis", false)
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTesis","Especialidad","Titulo","CodDocente","Estado"
            };
        }

        public void AgregarTesis(List<string> cadenaTesis)
        {
            //insert into TTesis values ('tema','coddocente','titulo','','')
            string Consulta = "insert into TTesis values ('" + cadenaTesis[0] + "','" + cadenaTesis[1] + "','" + cadenaTesis[2]+ "','" + cadenaTesis[3] + "','Por revisar')";
            aConexion.EjecutarComando(Consulta);
        }
        public string ObtenerDatos(List<string> cadenaTesis, string pNombreCampo)
        {
            string consulta = "select CodTesis from TTesis" + "where Especialidad='" + cadenaTesis[0] + "'and Titulo='" + cadenaTesis[1] + "'and CodDocente='" + cadenaTesis[2] + "'and Estado='" + cadenaTesis[3] + "')";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        public void AgregarASolitudInscripcion(List<string> CadenaSolicitudDeIncripcion)
        {
            string consulta = "insert into TSolicitudInscripcion values('" + CadenaSolicitudDeIncripcion[0] + "','" + CadenaSolicitudDeIncripcion[1] + "','" + CadenaSolicitudDeIncripcion[2] +"','Recibido','...')";
            aConexion.EjecutarComando(consulta);
        }
        /*
        public void AgregarTramiteDeInscripcionDePlanDeTesis(List<string> cadenaInscripciondePlanDeTesis)
        {
            //insert into TSolicitudInscripcion values ('TR0001','124813','124219','150409','100005','NINGUNA')
            string consulta = "insert into TIniciarTramiteInscripcionPlanDeTesis values ('" + cadenaInscripciondePlanDeTesis[0] + "','" + cadenaInscripciondePlanDeTesis[1] + "','" + cadenaInscripciondePlanDeTesis[2] + "','RECIBIDO','" + cadenaInscripciondePlanDeTesis[3] + "')";
            aConexion.EjecutarComando(consulta);


        }*/
        public string GenerarCodigoTesis()
        {
            try
            {
                string Codigo;
                string Cosulta = "select top 1 CodTesis from TTesis order by CodTesis desc";
                aConexion.EjecutarSelect(Cosulta);
                Codigo = aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
                int ValorCodigo = int.Parse(Codigo) + 1;
                return ValorCodigo.ToString();
            }
            catch
            {
                return "50000";
            }
        }
        /*public string GenerarCodigoTesis()
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
                return "50000";
            }
        }*/
        public string GenerarCodigoDeInscripcionDeTemaDeTesis()
        {
            try
            {
                string Codigo;
                string Consulta = "select top 1 CodSolitudInscripcionTesis from TSolicitudInscripcion order by CodSolitudInscripcionTesis desc";
                aConexion.EjecutarSelect(Consulta);
                Codigo = aConexion.Datos.Tables[0].Rows[0]["CodSolitudInscripcionTesis"].ToString();
                int ValorCodigo = int.Parse(Codigo) + 1;
                return ValorCodigo.ToString();
            }
            catch
            {
                return "100000";
            }
        }
        /*public string GenerarCodigoTrInscripcionDeTemaDeTesis()
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
                return "100000";
            }
        }*/
        public void GuardarCambiosTesisPorTesista(string pCodTesis, List<string> ListaDeTesistas)
        {
            string Consulta = "delete from TTesisPorTesista where CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(Consulta);
            for (int i=0;i<ListaDeTesistas.Count;i++)
            {
                Consulta = "insert into TTesisPorTesista values('" + pCodTesis + "','" + ListaDeTesistas[i] + "')";
                aConexion.EjecutarComando(Consulta);
            }

        }
        /*public void GuardarCambiosTesisXTesista(string pCodTesis, List<string> listaTesistas)
        {
            string Consulta = "delete from TTesisPorTesista where CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(Consulta);
            for (int i = 0; i < listaTesistas.Count; i++)
            {
                Consulta = " insert into TTesisPorTesista values('" + pCodTesis + "', '" + listaTesistas[i] + "') ";
                aConexion.EjecutarComando(Consulta);

            }
            //aConexion.EjecutarSelect(Consulta);
        }*/
        public DataTable ListarTesisPorTesista()
        {
            string Consulta = "selec * from TTesisPorTesista";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        /*public DataTable ListarTesisXTesista()
        {
            string Consulta = "select * from TTesisPorTesista";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }*/

    }
}
