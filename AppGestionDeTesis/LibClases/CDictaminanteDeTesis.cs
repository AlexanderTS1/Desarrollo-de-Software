using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibClases
{

    public class CDictaminanteDeTesis
    {
        public CConexion aConexion;
        public CDictaminanteDeTesis()
        {
            aConexion = new CConexion();
        }

        //select a.NroExpediente, a.CodEvaluacionPlanDeTesis, a.CodTesis, b.Titulo, b.Tema, b.Estado, b.Observaciones from TExpediente a inner join TTesis b on a.CodTesis= b.CodTesis where CodEvaluacionPlanDeTesis!='' and CodDictamenDeTesis = ''
        public DataTable TesisPendientesDeDictamen()
        {
            string consulta = "select a.NroExpediente, a.CodEvaluacionPlanDeTesis, a.CodTesis, b.Titulo, b.Especialidad, b.Estado from TDocumentacion a inner join TTesis b on a.CodTesis= b.CodTesis where CodDictamenDeTesis = ''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            /*
            string consulta = " select * from TExpediente where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            */
        }

        public DataTable ListarInteresados(string pCodTesis)
        {
            string consulta = "select CodTesista,Apellidos,Nombres,DNI from TTesista WHERE CodTesista IN" +
"(select CodTesista from TTesisPorTesista where CodTesis = '" + pCodTesis + "')";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string GenerarCodigoNombrarComisionRevisora()
        {
            try
            {


                string codigo;
                string consulta = "select top 1 CodDictamenDeTesis from TDocumentacion order by CodDictamenDeTesis desc";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodDictamenDeTesis"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "100";
            }
        }
        public void UpdateExpediente(string pCodExpediente, string pCodDictamen)
        {
            string consulta;
            consulta = "UPDATE TDocumentacion set CodDictamenDeTesis='" + pCodDictamen + "' WHERE NroExpediente='" + pCodExpediente + "'";
            aConexion.EjecutarComando(consulta);
        }
        public void AgregarDocentesDictaminantes(List<string> NombrarCR, string pCodEvaluacionDictamen)
        {
            string consulta;

            for (int i = 0; i < NombrarCR.Count; i++)
            {
                consulta = " insert into TDictaminantesDeTesis values ('" + pCodEvaluacionDictamen + "','" + NombrarCR[i] + "')";
                aConexion.EjecutarComando(consulta);
            }
        }
        public DataTable ListarDatosTesis(string pCodTesis)
        {
            string consulta = "select* from TTesis where CodTesis = '" + pCodTesis + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public bool VerificarSiEmitioEvaluacion(string pCodDictamenTesis, string pCodDocente)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TEvaluacionDeDictamenDeTesis WHERE CodDictamenDeTesis='" + pCodDictamenTesis + "' AND CodDocente='" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public DataTable ListarCodGrupoDictaminantes()
        {
            string consulta = "select * from TDocumentacion where CodDictamenDeTesis!=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string MostrarCodTesis(string pCodDictamen)
        {
            string consulta = "select  * from TDocumentacion a , TDictaminantesDeTesis b where a.CodDictamenDeTesis = b.CodDictamenDeTesis and b.CodDictamenDeTesis = '" + pCodDictamen + "'";
            aConexion.EjecutarSelect(consulta);

            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }
        public DataTable ListarDocentesDictaminantes(string pCodDictaminantes)
        {
            string consulta = "select * from TDictaminantesDeTesis where CodDictamenDeTesis = '" + pCodDictaminantes + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}

