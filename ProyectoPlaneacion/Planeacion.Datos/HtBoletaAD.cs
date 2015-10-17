using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Planeacion.Datos
{
    public class HtBoletaAD
    {

        #region "Acceso Datos Boletas"
        //Metodo quue se encarga de realizar el proceso de inseccion , eliminacion y actualizacion de la tabla de Boletas
        public Int32 RUDBoletasAD(HtBoleta boleta, int accion)
        {

            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "RUD_Boleta";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();
                // @Supervisor
                com.Parameters.Add(new SqlParameter("@HtIdDistrito ", boleta.HtIdDistrito));
                com.Parameters.Add(new SqlParameter("@HtConsecutivo", boleta.HtConsecutivo));
                com.Parameters.Add(new SqlParameter("@HtNumActividad ", boleta.HtNumActividad));
                com.Parameters.Add(new SqlParameter("@HtIdMes ", boleta.HtIdMes));
                com.Parameters.Add(new SqlParameter("@HtAngo", boleta.HtAngo));
                com.Parameters.Add(new SqlParameter("@HtNumIdentificacionNegocio", boleta.HtNumIdentificacionNegocio));
                com.Parameters.Add(new SqlParameter("@HtNomNegocio", boleta.HtNomNegocio));
                com.Parameters.Add(new SqlParameter("@HtNomLegal", boleta.HtNomLegal));
                com.Parameters.Add(new SqlParameter("@HtNumRazonSocial", boleta.HtIdEmpleado));
                com.Parameters.Add(new SqlParameter("@HtDirNegocio", boleta.HtDirNegocio));
                com.Parameters.Add(new SqlParameter("@HtTel1Negocio", boleta.HtTel1Negocio));
                com.Parameters.Add(new SqlParameter("@HtExt1Negocio", boleta.HtExt1Negocio));
                com.Parameters.Add(new SqlParameter("@HtEmail", boleta.HtEmail));
                com.Parameters.Add(new SqlParameter("@HtCantidadTrabajadores", boleta.HtCantidadTrabajadores));
                com.Parameters.Add(new SqlParameter("@HtCantidadTrabajadoresHombres", boleta.HtCantidadTrabajadoresHombres));
                com.Parameters.Add(new SqlParameter("@HtCantidadTrabajadoresNujeres", boleta.HtCantidadTrabajadoresNujeres));
                com.Parameters.Add(new SqlParameter("@HtDescCIIUProductoPrincipal", boleta.HtDescCIIUProductoPrincipal));
                com.Parameters.Add(new SqlParameter("@HtNumCiiu4", boleta.HtNumCiiu4));
                com.Parameters.Add(new SqlParameter("@HtNombreInformante", boleta.HtNombreInformante));
                com.Parameters.Add(new SqlParameter("@HtCargoDelInformante", boleta.HtCargoDelInformante));
                com.Parameters.Add(new SqlParameter("@HtTelefonoInformante", boleta.HtTelefonoInformante));
                com.Parameters.Add(new SqlParameter("@HtEmailInformante", boleta.HtEmailInformante));
                com.Parameters.Add(new SqlParameter("@HtIdResultadoEntrevista", boleta.HtIdResultadoEntrevista));
                com.Parameters.Add(new SqlParameter("@HtObservaciones", boleta.HtObservaciones));
                com.Parameters.Add(new SqlParameter("@HtIdEmpleado", boleta.HtIdEmpleado));
                com.Parameters.Add(new SqlParameter("@HtHoraInicio", boleta.HtHoraInicio));
                com.Parameters.Add(new SqlParameter("@HtHoraFinal", boleta.HtHoraFinal));
                com.Parameters.Add(new SqlParameter("@HtDuracionEntrevista", boleta.HtDuracionEntrevista));
                com.Parameters.Add(new SqlParameter("@HtFechaEntrevista", boleta.HtFechaEntrevista));
                com.Parameters.Add(new SqlParameter("@HtFechaUltimaModificacion", boleta.HtFechaUltimaModificacion));
                com.Parameters.Add(new SqlParameter("@HtIntentosEntrevista", boleta.HtIntentosEntrevista));
                com.Parameters.Add(new SqlParameter("@HtTipoDeCambio", boleta.HtTipoDeCambio));
                com.Parameters.Add(new SqlParameter("@HtIdTipoMoneda", boleta.HtIdTipoMoneda));
                com.Parameters.Add(new SqlParameter("@HtTotalDirectivosMujer", boleta.HtTotalDirectivosMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalDirectivosHombre", boleta.HtTotalDirectivosHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalDirectivos", boleta.HtTotalDirectivos));
                com.Parameters.Add(new SqlParameter("@HtTotalProfesionalesMujer", boleta.HtTotalProfesionalesMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalProfesionalesHombre", boleta.HtTotalProfesionalesHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalProfesionales", boleta.HtTotalProfesionales));
                com.Parameters.Add(new SqlParameter("@HtTotalTecnicosMujer", boleta.HtTotalTecnicosMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalTecnicosHombre", boleta.HtTotalTecnicosHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalTecnicos", boleta.HtTotalTecnicos));
                com.Parameters.Add(new SqlParameter("@HtTotalApoyoAdminMujer", boleta.HtTotalApoyoAdminMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalApoyoAdminHombre", boleta.HtTotalApoyoAdminHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalApoyoAdmin", boleta.HtTotalApoyoAdmin));
                com.Parameters.Add(new SqlParameter("@HtTotalServiciosMujer", boleta.HtTotalServiciosMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalServiciosHombre", boleta.HtTotalServiciosHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalServicios", boleta.HtTotalServicios));
                com.Parameters.Add(new SqlParameter("@HtTotalAgricultoresMujer", boleta.HtTotalAgricultoresMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalAgricultoresHombre", boleta.HtTotalAgricultoresHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalAgricultores", boleta.HtTotalAgricultores));
                com.Parameters.Add(new SqlParameter("@HtTotalOperariosMujer", boleta.HtTotalOperariosMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalOperariosHombre", boleta.HtTotalOperariosHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalOperarios", boleta.HtTotalOperarios));
                com.Parameters.Add(new SqlParameter("@HtTotalOperadoresMujer", boleta.HtTotalOperadoresMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalOperadoresHombre", boleta.HtTotalOperadoresHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalOperadores", boleta.HtTotalOperadores));
                com.Parameters.Add(new SqlParameter("@HtTotalOcupElementalesMujer", boleta.HtTotalOcupElementalesMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalOcupElementalesHombre", boleta.HtTotalOcupElementalesHombre));
                com.Parameters.Add(new SqlParameter("@HtTotalOcupElementales", boleta.HtTotalOcupElementales));
                com.Parameters.Add(new SqlParameter("@HtSalarioBaseTotal", boleta.HtSalarioBaseTotal));
                com.Parameters.Add(new SqlParameter("@HtSalEspecieTotal", boleta.HtSalEspecieTotal));
                com.Parameters.Add(new SqlParameter("@HtPagoHrsExtraTotal", boleta.HtPagoHrsExtraTotal));
                com.Parameters.Add(new SqlParameter("@HtAguinaldoTotal", boleta.HtAguinaldoTotal));
                com.Parameters.Add(new SqlParameter("@HtSalEscolarTotal", boleta.HtSalEscolarTotal));
                com.Parameters.Add(new SqlParameter("@HtRemuneracionesTotal", boleta.HtRemuneracionesTotal));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoDirectivos", boleta.HtTotalCostoDirectivos));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoProfecionales", boleta.HtTotalCostoProfecionales));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoTecnicos", boleta.HtTotalCostoTecnicos));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoApoyoAdmin", boleta.HtTotalCostoApoyoAdmin));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoServicios", boleta.HtTotalCostoServicios));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoAgricultores", boleta.HtTotalCostoAgricultores));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoOperarios", boleta.HtTotalCostoOperarios));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoOperadores", boleta.HtTotalCostoOperadores));
                com.Parameters.Add(new SqlParameter("@HtTotalCostoOcupElementales", boleta.HtTotalCostoOcupElementales));
                com.Parameters.Add(new SqlParameter("@HtTotalCosto", boleta.HtTotalCosto));
                com.Parameters.Add(new SqlParameter("@HtDeducccionTotal", boleta.HtDeducccionTotal));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasDerectivos", boleta.HtTotalHorasDerectivos));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasProfecionales", boleta.HtTotalHorasProfecionales));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasTecnicos", boleta.HtTotalHorasTecnicos));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasApoyoAdmin", boleta.HtTotalHorasApoyoAdmin));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasServicios", boleta.HtTotalHorasServicios));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasAgricultores", boleta.HtTotalHorasAgricultores));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasOperarios", boleta.HtTotalHorasOperarios));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasOperadores", boleta.HtTotalHorasOperadores));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasOcupElementales", boleta.HtTotalHorasOcupElementales));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasOrdinarias", boleta.HtTotalHorasOrdinarias));
                com.Parameters.Add(new SqlParameter("@HtTotalHorasExtra", boleta.HtTotalHorasExtra));
                com.Parameters.Add(new SqlParameter("@HtTotalHoras", boleta.HtTotalHoras));
                com.Parameters.Add(new SqlParameter("@HtTotalOutsourcing", boleta.HtTotalOutsourcing));
                com.Parameters.Add(new SqlParameter("@HtTotalOutsourcingMujer", boleta.HtTotalOutsourcingMujer));
                com.Parameters.Add(new SqlParameter("@HtTotalOutsourcingHombre", boleta.HtTotalOutsourcingHombre));
                com.Parameters.Add(new SqlParameter("@HtIdEntrevistador", boleta.HtIdEntrevistador));


                com.Parameters.Add(new SqlParameter("@accion", accion));
                com.Connection.Open();
                // devuelve el numero de filas afectadas en el SQL
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                accion = 0;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return accion;
        }



        // metodo que devuelve una lista de Boletas, solo para administradores
        public List<HtBoleta> ObtenerBoletasAD()
        {
            List<HtBoleta> listaBoletas = new List<HtBoleta>();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "seleccionarBoletas";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HtBoleta lBoleta = new HtBoleta();

                        lBoleta.HtIdDistrito = int.Parse( dr["HtIdDistrito"].ToString());
                        lBoleta.HtConsecutivo = int.Parse(dr["HtConsecutivo"].ToString());
                        lBoleta.HtNumActividad = int.Parse(dr["HtNumActividad"].ToString());
                        lBoleta.HtIdMes = int.Parse(dr["HtIdMes"].ToString());
                        lBoleta.HtAngo = int.Parse(dr["HtAngo"].ToString());
                        lBoleta.HtNumIdentificacionNegocio = dr["HtNumIdentificacionNegocio"].ToString();
                        lBoleta.HtNomNegocio = dr["HtNomNegocio"].ToString();
                        lBoleta.HtNomLegal = dr["HtNomLegal"].ToString();
                        lBoleta.HtNumRazonSocial = int.Parse(dr["HtNumRazonSocial"].ToString());
                        lBoleta.HtDirNegocio = dr["HtDirNegocio"].ToString();
                        lBoleta.HtTel1Negocio = int.Parse(dr["HtTel1Negocio"].ToString());
                        lBoleta.HtExt1Negocio = int.Parse(dr["HtExt1Negocio"].ToString());
                        lBoleta.HtEmail = dr["HtEmail"].ToString();
                        lBoleta.HtCantidadTrabajadores = short.Parse(dr["HtCantidadTrabajadores"].ToString());
                        lBoleta.HtCantidadTrabajadoresHombres = short.Parse(dr["HtCantidadTrabajadoresHombres"].ToString());
                        lBoleta.HtCantidadTrabajadoresNujeres = short.Parse(dr["HtCantidadTrabajadoresNujeres"].ToString());
                        lBoleta.HtDescCIIUProductoPrincipal = dr["HtDescCIIUProductoPrincipal"].ToString();
                        lBoleta.HtNumCiiu4 = dr["HtNumCiiu4"].ToString();
                        lBoleta.HtNombreInformante = dr["HtNombreInformante"].ToString();
                        lBoleta.HtCargoDelInformante = dr["HtCargoDelInformante"].ToString();
                        lBoleta.HtTelefonoInformante = int.Parse(dr["HtTelefonoInformante"].ToString());
                        lBoleta.HtEmailInformante = dr["HtEmailInformante"].ToString();
                        lBoleta.HtIdResultadoEntrevista = int.Parse(dr["HtIdResultadoEntrevista"].ToString());
                        lBoleta.HtObservaciones = dr["HtObservaciones"].ToString();
                        lBoleta.HtIdEmpleado = int.Parse(dr["HtIdEmpleado"].ToString());
                        lBoleta.HtHoraInicio = DateTime.Parse(dr["HtHoraInicio"].ToString());
                        lBoleta.HtHoraFinal = DateTime.Parse(dr["HtHoraFinal"].ToString());
                        lBoleta.HtDuracionEntrevista = dr["HtDuracionEntrevista"].ToString();
                        lBoleta.HtFechaEntrevista = DateTime.Parse(dr["HtFechaEntrevista"].ToString());
                        lBoleta.HtFechaUltimaModificacion = DateTime.Parse(dr["HtFechaUltimaModificacion"].ToString());
                        lBoleta.HtIntentosEntrevista = short.Parse(dr["HtIntentosEntrevista"].ToString());
                        lBoleta.HtTipoDeCambio = short.Parse(dr["HtTipoDeCambio"].ToString());
                        lBoleta.HtIdTipoMoneda = int.Parse(dr["HtIdTipoMoneda"].ToString());
                        lBoleta.HtTotalDirectivosMujer = int.Parse(dr["HtTotalDirectivosMujer"].ToString());
                        lBoleta.HtTotalDirectivosHombre = int.Parse(dr["HtTotalDirectivosHombre"].ToString());
                        lBoleta.HtTotalDirectivos = int.Parse(dr["HtTotalDirectivos"].ToString());
                        lBoleta.HtTotalProfesionalesMujer = int.Parse(dr["HtTotalProfesionalesMujer"].ToString());
                        lBoleta.HtTotalProfesionalesHombre = int.Parse(dr["HtTotalProfesionalesHombre"].ToString());
                        lBoleta.HtTotalProfesionales = int.Parse(dr["HtTotalProfesionales"].ToString());
                        lBoleta.HtTotalTecnicosMujer = int.Parse(dr["HtTotalTecnicosMujer"].ToString());
                        lBoleta.HtTotalTecnicosHombre = int.Parse(dr["HtTotalTecnicosHombre"].ToString());
                        lBoleta.HtTotalTecnicos = int.Parse(dr["HtTotalTecnicos"].ToString());
                        lBoleta.HtTotalApoyoAdminMujer = int.Parse(dr["HtTotalApoyoAdminMujer"].ToString());
                        lBoleta.HtTotalApoyoAdminHombre = int.Parse(dr["HtTotalApoyoAdminHombre"].ToString());
                        lBoleta.HtTotalApoyoAdmin = int.Parse(dr["HtTotalApoyoAdmin"].ToString());
                        lBoleta.HtTotalServiciosMujer = int.Parse(dr["HtTotalServiciosMujer"].ToString());
                        lBoleta.HtTotalServiciosHombre = int.Parse(dr["HtTotalServiciosHombre"].ToString());
                        lBoleta.HtTotalServicios = int.Parse(dr["HtTotalServicios"].ToString());
                        lBoleta.HtTotalAgricultoresMujer = int.Parse(dr["HtTotalAgricultoresMujer"].ToString());
                        lBoleta.HtTotalAgricultoresHombre = int.Parse(dr["HtTotalAgricultoresHombre"].ToString());
                        lBoleta.HtTotalAgricultores = int.Parse(dr["HtTotalAgricultores"].ToString());
                        lBoleta.HtTotalOperariosMujer = int.Parse(dr["HtTotalOperariosMujer"].ToString());
                        lBoleta.HtTotalOperariosHombre = int.Parse(dr["HtTotalOperariosHombre"].ToString());
                        lBoleta.HtTotalOperarios = int.Parse(dr["HtTotalOperarios"].ToString());
                        lBoleta.HtTotalOperadoresMujer = int.Parse(dr["HtTotalOperadoresMujer"].ToString());
                        lBoleta.HtTotalOperadoresHombre = int.Parse(dr["HtTotalOperadoresHombre"].ToString());
                        lBoleta.HtTotalOperadores = int.Parse(dr["HtTotalOperadores"].ToString());
                        lBoleta.HtTotalOcupElementalesMujer = int.Parse(dr["HtTotalOcupElementalesMujer"].ToString());
                        lBoleta.HtTotalOcupElementalesHombre = int.Parse(dr["HtTotalOcupElementalesHombre"].ToString());
                        lBoleta.HtTotalOcupElementales = int.Parse(dr["HtTotalOcupElementales"].ToString());
                        lBoleta.HtSalarioBaseTotal = int.Parse(dr["HtSalarioBaseTotal"].ToString());
                        lBoleta.HtSalEspecieTotal = int.Parse(dr["HtSalEspecieTotal"].ToString());
                        lBoleta.HtPagoHrsExtraTotal = int.Parse(dr["HtPagoHrsExtraTotal"].ToString());
                        lBoleta.HtAguinaldoTotal = int.Parse(dr["HtAguinaldoTotal"].ToString());
                        lBoleta.HtSalEscolarTotal = int.Parse(dr["HtSalEscolarTotal"].ToString());
                        lBoleta.HtRemuneracionesTotal = int.Parse(dr["HtRemuneracionesTotal"].ToString());
                        lBoleta.HtTotalCostoDirectivos = int.Parse(dr["HtTotalCostoDirectivos"].ToString());
                        lBoleta.HtTotalCostoProfecionales = int.Parse(dr["HtTotalCostoProfecionales"].ToString());
                        lBoleta.HtTotalCostoTecnicos = int.Parse(dr["HtTotalCostoTecnicos"].ToString());
                        lBoleta.HtTotalCostoApoyoAdmin = int.Parse(dr["HtTotalCostoApoyoAdmin"].ToString());
                        lBoleta.HtTotalCostoServicios = int.Parse(dr["HtTotalCostoServicios"].ToString());
                        lBoleta.HtTotalCostoAgricultores = int.Parse(dr["HtTotalCostoAgricultores"].ToString());
                        lBoleta.HtTotalCostoOperarios = int.Parse(dr["HtTotalCostoOperarios"].ToString());
                        lBoleta.HtTotalCostoOperadores = int.Parse(dr["HtTotalCostoOperadores"].ToString());
                        lBoleta.HtTotalCostoOcupElementales = int.Parse(dr["HtTotalCostoOcupElementales"].ToString());
                        lBoleta.HtTotalCosto = int.Parse(dr["HtTotalCosto"].ToString());
                        lBoleta.HtDeducccionTotal = int.Parse(dr["HtDeducccionTotal"].ToString());
                        lBoleta.HtTotalHorasDerectivos = int.Parse(dr["HtTotalHorasDerectivos"].ToString());
                        lBoleta.HtTotalHorasProfecionales = int.Parse(dr["HtTotalHorasProfecionales"].ToString());
                        lBoleta.HtTotalHorasTecnicos = int.Parse(dr["HtTotalHorasTecnicos"].ToString());
                        lBoleta.HtTotalHorasApoyoAdmin = int.Parse(dr["HtTotalHorasApoyoAdmin"].ToString());
                        lBoleta.HtTotalHorasServicios = int.Parse(dr["HtTotalHorasServicios"].ToString());
                        lBoleta.HtTotalHorasAgricultores = int.Parse(dr["HtTotalHorasAgricultores"].ToString());
                        lBoleta.HtTotalHorasOperarios = int.Parse(dr["HtTotalHorasOperarios"].ToString());
                        lBoleta.HtTotalHorasOperadores = int.Parse(dr["HtTotalHorasOperadores"].ToString());
                        lBoleta.HtTotalHorasOcupElementales = int.Parse(dr["HtTotalHorasOcupElementales"].ToString());
                        lBoleta.HtTotalHorasOrdinarias = int.Parse(dr["HtTotalHorasOrdinarias"].ToString());
                        lBoleta.HtTotalHorasExtra = int.Parse(dr["HtTotalHorasExtra"].ToString());
                        lBoleta.HtTotalHoras = int.Parse(dr["HtTotalHoras"].ToString());
                        lBoleta.HtTotalOutsourcing = int.Parse(dr["HtTotalOutsourcing"].ToString());
                        lBoleta.HtTotalOutsourcingMujer = int.Parse(dr["HtTotalOutsourcingMujer"].ToString());
                        lBoleta.HtTotalOutsourcingHombre = int.Parse(dr["HtTotalOutsourcingHombre"].ToString());
                        lBoleta.HtIdEntrevistador = int.Parse(dr["HtIdEntrevistador"].ToString());

                      

                        listaBoletas.Add(lBoleta);
                    }
                }
            }
            catch (Exception ex)
            {
                listaBoletas = null;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return listaBoletas;
        }

        public HtBoleta ObtenerBoletaIndividualAD(int numActividad,int consecutivo, int mes, int ango)
        {
            HtBoleta lBoleta = new HtBoleta();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "sp_seleccionarBoleta";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();

                com.Parameters.Add(new SqlParameter("@HtConsecutivo", consecutivo));
                com.Parameters.Add(new SqlParameter("@HtNumActividad ",numActividad));
                com.Parameters.Add(new SqlParameter("@HtIdMes ", mes));
                com.Parameters.Add(new SqlParameter("@HtAngo", ango));
                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();
               
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       

                        lBoleta.HtIdDistrito = int.Parse(dr["HtIdDistrito"].ToString());
                        lBoleta.HtConsecutivo = int.Parse(dr["HtConsecutivo"].ToString());
                        lBoleta.HtNumActividad = int.Parse(dr["HtNumActividad"].ToString());
                        lBoleta.HtIdMes = int.Parse(dr["HtIdMes"].ToString());
                        lBoleta.HtAngo = int.Parse(dr["HtAngo"].ToString());
                        lBoleta.HtNumIdentificacionNegocio = dr["HtNumIdentificacionNegocio"].ToString();
                        lBoleta.HtNomNegocio = dr["HtNomNegocio"].ToString();
                        lBoleta.HtNomLegal = dr["HtNomLegal"].ToString();
                        lBoleta.HtNumRazonSocial = int.Parse(dr["HtNumRazonSocial"].ToString());
                        lBoleta.HtDirNegocio = dr["HtDirNegocio"].ToString();
                        lBoleta.HtTel1Negocio = int.Parse(dr["HtTel1Negocio"].ToString());
                        lBoleta.HtExt1Negocio = int.Parse(dr["HtExt1Negocio"].ToString());
                        lBoleta.HtEmail = dr["HtEmail"].ToString();
                        lBoleta.HtCantidadTrabajadores = short.Parse(dr["HtCantidadTrabajadores"].ToString());
                        lBoleta.HtCantidadTrabajadoresHombres = short.Parse(dr["HtCantidadTrabajadoresHombres"].ToString());
                        lBoleta.HtCantidadTrabajadoresNujeres = short.Parse(dr["HtCantidadTrabajadoresNujeres"].ToString());
                        lBoleta.HtDescCIIUProductoPrincipal = dr["HtDescCIIUProductoPrincipal"].ToString();
                        lBoleta.HtNumCiiu4 = dr["HtNumCiiu4"].ToString();
                        lBoleta.HtNombreInformante = dr["HtNombreInformante"].ToString();
                        lBoleta.HtCargoDelInformante = dr["HtCargoDelInformante"].ToString();
                        lBoleta.HtTelefonoInformante = int.Parse(dr["HtTelefonoInformante"].ToString());
                        lBoleta.HtEmailInformante = dr["HtEmailInformante"].ToString();
                        lBoleta.HtIdResultadoEntrevista = int.Parse(dr["HtIdResultadoEntrevista"].ToString());
                        lBoleta.HtObservaciones = dr["HtObservaciones"].ToString();
                        lBoleta.HtIdEmpleado = int.Parse(dr["HtIdEmpleado"].ToString());
                        lBoleta.HtHoraInicio = DateTime.Parse(dr["HtHoraInicio"].ToString());
                        lBoleta.HtHoraFinal = DateTime.Parse(dr["HtHoraFinal"].ToString());
                        lBoleta.HtDuracionEntrevista = dr["HtDuracionEntrevista"].ToString();
                        lBoleta.HtFechaEntrevista = DateTime.Parse(dr["HtFechaEntrevista"].ToString());
                        lBoleta.HtFechaUltimaModificacion = DateTime.Parse(dr["HtFechaUltimaModificacion"].ToString());
                        lBoleta.HtIntentosEntrevista = short.Parse(dr["HtIntentosEntrevista"].ToString());
                        lBoleta.HtTipoDeCambio = short.Parse(dr["HtTipoDeCambio"].ToString());
                        lBoleta.HtIdTipoMoneda = int.Parse(dr["HtIdTipoMoneda"].ToString());
                        lBoleta.HtTotalDirectivosMujer = int.Parse(dr["HtTotalDirectivosMujer"].ToString());
                        lBoleta.HtTotalDirectivosHombre = int.Parse(dr["HtTotalDirectivosHombre"].ToString());
                        lBoleta.HtTotalDirectivos = int.Parse(dr["HtTotalDirectivos"].ToString());
                        lBoleta.HtTotalProfesionalesMujer = int.Parse(dr["HtTotalProfesionalesMujer"].ToString());
                        lBoleta.HtTotalProfesionalesHombre = int.Parse(dr["HtTotalProfesionalesHombre"].ToString());
                        lBoleta.HtTotalProfesionales = int.Parse(dr["HtTotalProfesionales"].ToString());
                        lBoleta.HtTotalTecnicosMujer = int.Parse(dr["HtTotalTecnicosMujer"].ToString());
                        lBoleta.HtTotalTecnicosHombre = int.Parse(dr["HtTotalTecnicosHombre"].ToString());
                        lBoleta.HtTotalTecnicos = int.Parse(dr["HtTotalTecnicos"].ToString());
                        lBoleta.HtTotalApoyoAdminMujer = int.Parse(dr["HtTotalApoyoAdminMujer"].ToString());
                        lBoleta.HtTotalApoyoAdminHombre = int.Parse(dr["HtTotalApoyoAdminHombre"].ToString());
                        lBoleta.HtTotalApoyoAdmin = int.Parse(dr["HtTotalApoyoAdmin"].ToString());
                        lBoleta.HtTotalServiciosMujer = int.Parse(dr["HtTotalServiciosMujer"].ToString());
                        lBoleta.HtTotalServiciosHombre = int.Parse(dr["HtTotalServiciosHombre"].ToString());
                        lBoleta.HtTotalServicios = int.Parse(dr["HtTotalServicios"].ToString());
                        lBoleta.HtTotalAgricultoresMujer = int.Parse(dr["HtTotalAgricultoresMujer"].ToString());
                        lBoleta.HtTotalAgricultoresHombre = int.Parse(dr["HtTotalAgricultoresHombre"].ToString());
                        lBoleta.HtTotalAgricultores = int.Parse(dr["HtTotalAgricultores"].ToString());
                        lBoleta.HtTotalOperariosMujer = int.Parse(dr["HtTotalOperariosMujer"].ToString());
                        lBoleta.HtTotalOperariosHombre = int.Parse(dr["HtTotalOperariosHombre"].ToString());
                        lBoleta.HtTotalOperarios = int.Parse(dr["HtTotalOperarios"].ToString());
                        lBoleta.HtTotalOperadoresMujer = int.Parse(dr["HtTotalOperadoresMujer"].ToString());
                        lBoleta.HtTotalOperadoresHombre = int.Parse(dr["HtTotalOperadoresHombre"].ToString());
                        lBoleta.HtTotalOperadores = int.Parse(dr["HtTotalOperadores"].ToString());
                        lBoleta.HtTotalOcupElementalesMujer = int.Parse(dr["HtTotalOcupElementalesMujer"].ToString());
                        lBoleta.HtTotalOcupElementalesHombre = int.Parse(dr["HtTotalOcupElementalesHombre"].ToString());
                        lBoleta.HtTotalOcupElementales = int.Parse(dr["HtTotalOcupElementales"].ToString());
                        lBoleta.HtSalarioBaseTotal = int.Parse(dr["HtSalarioBaseTotal"].ToString());
                        lBoleta.HtSalEspecieTotal = int.Parse(dr["HtSalEspecieTotal"].ToString());
                        lBoleta.HtPagoHrsExtraTotal = int.Parse(dr["HtPagoHrsExtraTotal"].ToString());
                        lBoleta.HtAguinaldoTotal = int.Parse(dr["HtAguinaldoTotal"].ToString());
                        lBoleta.HtSalEscolarTotal = int.Parse(dr["HtSalEscolarTotal"].ToString());
                        lBoleta.HtRemuneracionesTotal = int.Parse(dr["HtRemuneracionesTotal"].ToString());
                        lBoleta.HtTotalCostoDirectivos = int.Parse(dr["HtTotalCostoDirectivos"].ToString());
                        lBoleta.HtTotalCostoProfecionales = int.Parse(dr["HtTotalCostoProfecionales"].ToString());
                        lBoleta.HtTotalCostoTecnicos = int.Parse(dr["HtTotalCostoTecnicos"].ToString());
                        lBoleta.HtTotalCostoApoyoAdmin = int.Parse(dr["HtTotalCostoApoyoAdmin"].ToString());
                        lBoleta.HtTotalCostoServicios = int.Parse(dr["HtTotalCostoServicios"].ToString());
                        lBoleta.HtTotalCostoAgricultores = int.Parse(dr["HtTotalCostoAgricultores"].ToString());
                        lBoleta.HtTotalCostoOperarios = int.Parse(dr["HtTotalCostoOperarios"].ToString());
                        lBoleta.HtTotalCostoOperadores = int.Parse(dr["HtTotalCostoOperadores"].ToString());
                        lBoleta.HtTotalCostoOcupElementales = int.Parse(dr["HtTotalCostoOcupElementales"].ToString());
                        lBoleta.HtTotalCosto = int.Parse(dr["HtTotalCosto"].ToString());
                        lBoleta.HtDeducccionTotal = int.Parse(dr["HtDeducccionTotal"].ToString());
                        lBoleta.HtTotalHorasDerectivos = int.Parse(dr["HtTotalHorasDerectivos"].ToString());
                        lBoleta.HtTotalHorasProfecionales = int.Parse(dr["HtTotalHorasProfecionales"].ToString());
                        lBoleta.HtTotalHorasTecnicos = int.Parse(dr["HtTotalHorasTecnicos"].ToString());
                        lBoleta.HtTotalHorasApoyoAdmin = int.Parse(dr["HtTotalHorasApoyoAdmin"].ToString());
                        lBoleta.HtTotalHorasServicios = int.Parse(dr["HtTotalHorasServicios"].ToString());
                        lBoleta.HtTotalHorasAgricultores = int.Parse(dr["HtTotalHorasAgricultores"].ToString());
                        lBoleta.HtTotalHorasOperarios = int.Parse(dr["HtTotalHorasOperarios"].ToString());
                        lBoleta.HtTotalHorasOperadores = int.Parse(dr["HtTotalHorasOperadores"].ToString());
                        lBoleta.HtTotalHorasOcupElementales = int.Parse(dr["HtTotalHorasOcupElementales"].ToString());
                        lBoleta.HtTotalHorasOrdinarias = int.Parse(dr["HtTotalHorasOrdinarias"].ToString());
                        lBoleta.HtTotalHorasExtra = int.Parse(dr["HtTotalHorasExtra"].ToString());
                        lBoleta.HtTotalHoras = int.Parse(dr["HtTotalHoras"].ToString());
                        lBoleta.HtTotalOutsourcing = int.Parse(dr["HtTotalOutsourcing"].ToString());
                        lBoleta.HtTotalOutsourcingMujer = int.Parse(dr["HtTotalOutsourcingMujer"].ToString());
                        lBoleta.HtTotalOutsourcingHombre = int.Parse(dr["HtTotalOutsourcingHombre"].ToString());
                        lBoleta.HtIdEntrevistador = int.Parse(dr["HtIdEntrevistador"].ToString());



                       
                    }
                }
            }
            catch (Exception ex)
            {
                lBoleta = null;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return lBoleta;
        }

        public DataSet ObtenerDataSetBoletasAD()
        {
            List<HtBoleta> listaBoletas = new List<HtBoleta>();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            DataSet ds = new DataSet();
            try
            {

                com.CommandText = "seleccionarBoletas";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = com;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);      
                }
            }
            catch (Exception ex)
            {
                ds = null;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return ds;
        }

        #endregion




    }
}
