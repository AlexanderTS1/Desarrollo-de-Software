using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibClases
{
    public class CPlanDeTesis
    {
        public CConexion aConexion;
        public CPlanDeTesis()
        {
            aConexion = new CConexion();
        }

        public string GenerarCodigoTesis()
        {   //-- retorna una tabla con la lista completa de libros 

            try
            {
                string codigo;
                string consulta = "select top 1 NroExpediente from TDocumentacion order by NroExpediente desc";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["NroExpediente"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "200000";
            }
        }
        public void GenerarExpediente(List<string> listaEspediente)
        {
            string Consulta = "insert into TDocumentacion values('" + listaEspediente[0] + "','" + listaEspediente[1] + "','','','','')";
            aConexion.EjecutarComando(Consulta);
            /*string Consulta = "insert into TDocumentacion values('" + listaTesistas[0] + "','" + listaTesistas[1] + "','','','','')";
            aConexion.EjecutarComando(Consulta);*/

        }
        public void ActualizarEstadoDelTramite(string pCodTramITTesis, string pCodTesis)
        {
            string update = "update TSolicitudInscripcion set Estado='Pre inscripcion aceptada' where CodSolitudInscripcionTesis='" + pCodTramITTesis + "' and CodTesis='" + pCodTesis + "'";
            aConexion.EjecutarComando(update);
        }
        public DataTable ListarTesistasPorTesis()
        {
            string consulta = "select CodTesis,a.CodTesista,Apellidos,Nombres,DNI from TTesisPorTesista a inner join TTesista b on a.CodTesista=b.CodTesista where CodTesis='500014'";
            aConexion.EjecutarComando(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable TesisPendientesDeDCR()
        {
            string consulta = "select a.NroExpediente,a.CodEvaluacionPlanDeTesis,a.CodTesis,b.Titulo,b.Especialidad,b.Estado  from TDocumentacion a inner join TTesis b on a.CodTesis=b.CodTesis where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            /*
            string consulta = " select * from TExpediente where CodEvaluacionPlanDeTesis=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
            */
        }
        public string GenerarCodigoNombrarComisionRevisora()
        {
            try
            {


                string codigo;
                string consulta = " select top 1 CodEvaluacionPlanDeTesis from TDocumentacion order by CodEvaluacionPlanDeTesis desc";
                aConexion.EjecutarSelect(consulta);
                codigo = aConexion.Datos.Tables[0].Rows[0]["CodEvaluacionPlanDeTesis"].ToString();
                int valorcodigo = int.Parse(codigo) + 1;
                return valorcodigo.ToString();
            }
            catch
            {
                return "300000";
            }
        }
        public void AgregarDocentesCR(List<string> NombrarCR, string pCodEvaluacionPlanDeTesis)
        {
            string consulta;

            for (int i = 0; i < NombrarCR.Count; i++)
            {
                consulta = " insert into TComisionRevisora values ('" + NombrarCR[i] + "','" + pCodEvaluacionPlanDeTesis + "')";
                aConexion.EjecutarComando(consulta);
            }
        }
        public void UpdateExpediente(string pCodExpediente, string pCodCR)
        {
            string consulta;
            consulta = "UPDATE TDocumentacion set CodEvaluacionPlanDeTesis='" + pCodCR + "' WHERE NroExpediente='" + pCodExpediente + "'";
            aConexion.EjecutarComando(consulta);
        }
        public DataTable ListarCodComisionRevisora()
        {
            string consulta = "select * from TDocumentacion where CodEvaluacionPlanDeTesis!=''";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarDocenteComisionRevisora(string pCodComisionRevisora)
        {
            string consulta = "select * from TComisionRevisora where CodEvaluacionPlanDeTesis='" + pCodComisionRevisora + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public void AgregarEvaluacionPlanDeTesis(List<string> Cadena)
        {
            string consulta = "insert into TEvaluacionDePlanDeTesis values('" + Cadena[0] + "','" + Cadena[1] + "','" + Cadena[2] + "','" + Cadena[3] + "','" + Cadena[4] + "','" + Cadena[5] + "','" + Cadena[6] + "','" + Cadena[7] + "','" + Cadena[8] + "','" + Cadena[9] + "','" + Cadena[10] + "')";
            aConexion.EjecutarComando(consulta);
        }
        public bool VerificarSiEmitioEvaluacion(string pCodPlanTesis, string pCodDocente)
        {
            //bool encontrado = false;
            string Consulta = "SELECT * FROM TEvaluacionDePlanDeTesis WHERE CodEvaluacionPlanDeTesis='" + pCodPlanTesis + "' AND CodDocente='" + pCodDocente + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0].Rows.Count > 0;
        }
        public List<string> ObtenerResultadoCR(string pCodPlanDeTesis)
        {
            string Consulta = "select * from TEvaluacionDePlanDeTesis where CodEvaluacionPlanDeTesis='" + pCodPlanDeTesis + "'";
            aConexion.EjecutarSelect(Consulta);
            DataTable tablaresultado = aConexion.Datos.Tables[0];
            double RNotaIdentificacionDelProblema = 0;
            double RNotaHipotesis = 0;
            double RNotaAlcanceyResultados = 0;
            double RNotaMetodologia = 0;
            double RNotaRevisionBibliografica = 0;
            double RNotaRecursosYPresupuesto = 0;
            double RNotaImpacto = 0;
            double RNotaOrganizacionDocTesis = 0;
            for (int k = 0; k < tablaresultado.Rows.Count; k++)
            {
                DataRow drv = tablaresultado.Rows[k];
                RNotaIdentificacionDelProblema += double.Parse(drv["NotaIdentificacionDelProblema"].ToString());
                RNotaHipotesis += double.Parse(drv["NotaHipotesis"].ToString());
                RNotaAlcanceyResultados += double.Parse(drv["NotaAlcanceyResultados"].ToString());
                RNotaMetodologia += double.Parse(drv["NotaMetodologia"].ToString());
                RNotaRevisionBibliografica += double.Parse(drv["NotaRevisionBibliografica"].ToString());
                RNotaRecursosYPresupuesto += double.Parse(drv["NotaRecursosyPresupuestos"].ToString());
                RNotaImpacto += double.Parse(drv["NotaImpacto"].ToString());
                RNotaOrganizacionDocTesis += double.Parse(drv["NotaDeOrganizacionDeDocumentoDePlan"].ToString());
            }
            double NotaIdentificacionDelProblema = Math.Round(RNotaIdentificacionDelProblema / 3, 2);
            double NotaHipotesis = Math.Round(RNotaHipotesis / 3, 2);
            double NotaAlcanceResultados = Math.Round(RNotaAlcanceyResultados / 3, 2);
            double NotaMetodologia = Math.Round(RNotaMetodologia / 3, 2);
            double NotaRevisionBibliografica = Math.Round(RNotaRevisionBibliografica / 3, 2);
            double NotaRecursosPresupuesto = Math.Round(RNotaRecursosYPresupuesto / 3, 2);
            double NotaImpacto = Math.Round(RNotaImpacto / 3, 2);
            double NotaOrganizacionDocTesis = Math.Round(RNotaOrganizacionDocTesis / 3, 2);
            List<string> Promedios = new List<string>();
            Promedios.Add(NotaIdentificacionDelProblema.ToString());
            Promedios.Add(NotaHipotesis.ToString());
            Promedios.Add(NotaAlcanceResultados.ToString());
            Promedios.Add(NotaMetodologia.ToString());
            Promedios.Add(NotaRevisionBibliografica.ToString());
            Promedios.Add(NotaRecursosPresupuesto.ToString());
            Promedios.Add(NotaImpacto.ToString());
            Promedios.Add(NotaOrganizacionDocTesis.ToString());
            double NotaFinal = Math.Round((NotaIdentificacionDelProblema + NotaHipotesis + NotaAlcanceResultados + NotaMetodologia + NotaRevisionBibliografica +
                NotaRecursosPresupuesto + NotaImpacto + NotaOrganizacionDocTesis) / 8, 2);
            Promedios.Add(NotaFinal.ToString());
            return Promedios;
        }

        public DataTable ListarInteresados(string pCodTesis)
        {
            string consulta = "select CodTesista,Apellidos,Nombres,DNI from TTesista WHERE CodTesista IN" +
"(select CodTesista from TTesisPorTesista where CodTesis = '" + pCodTesis + "')";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListaTramitesDeInscripcionDeTesis()
        {
            string consulta = "select a.CodSolitudInscripcionTesis,a.CodTesis,b.Titulo,b.Especialidad,a.Estado from TSolicitudInscripcion a inner join TTesis b on a.CodTesis=b.CodTesis where a.Estado='RECIBIDO'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable ListarDatosTesis(string pCodTesis)
        {
            string consulta = "select* from TTesis where CodTesis = '" + pCodTesis + "'";
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }
        public string MostrarCodTesis(string pCodEvaluacion)
        {
            string consulta = "select  * from TDocumentacion a , TComisionRevisora b where a.CodEvaluacionPlanDeTesis = b.CodEvaluacionPlanTesis and b.CodEvaluacionPlanDeTesis = '" + pCodEvaluacion + "'";
            aConexion.EjecutarSelect(consulta);

            return aConexion.Datos.Tables[0].Rows[0]["CodTesis"].ToString();
        }
    }
}

