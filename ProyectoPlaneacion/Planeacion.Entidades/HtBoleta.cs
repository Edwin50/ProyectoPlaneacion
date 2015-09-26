using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.Entidades
{
  public  class HtBoleta
    {

        public Nullable<int> HtIdDistrito { get; set; }
        public int HtConsecutivo { get; set; }
        public int HtNumActividad { get; set; }
        public int HtIdMes { get; set; }
        public int HtAngo { get; set; }
        public string HtNumIdentificacionNegocio { get; set; }
        public string HtNomNegocio { get; set; }
        public string HtNomLegal { get; set; }
        public Nullable<int> HtNumRazonSocial { get; set; }
        public string HtDirNegocio { get; set; }
        public Nullable<int> HtTel1Negocio { get; set; }
        public Nullable<int> HtExt1Negocio { get; set; }
        public string HtEmail { get; set; }
        public Nullable<short> HtCantidadTrabajadores { get; set; }
        public Nullable<short> HtCantidadTrabajadoresHombres { get; set; }
        public Nullable<short> HtCantidadTrabajadoresNujeres { get; set; }
        public string HtDescCIIUProductoPrincipal { get; set; }
        public string HtNumCiiu4 { get; set; }
        public string HtNombreInformante { get; set; }
        public string HtCargoDelInformante { get; set; }
        public Nullable<int> HtTelefonoInformante { get; set; }
        public string HtEmailInformante { get; set; }
        public Nullable<int> HtIdResultadoEntrevista { get; set; }
        public string HtObservaciones { get; set; }
        public Nullable<int> HtIdEmpleado { get; set; }
        public Nullable<System.DateTime> HtHoraInicio { get; set; }
        public Nullable<System.DateTime> HtHoraFinal { get; set; }
        public string HtDuracionEntrevista { get; set; }
        public Nullable<System.DateTime> HtFechaEntrevista { get; set; }
        public Nullable<System.DateTime> HtFechaUltimaModificacion { get; set; }
        public Nullable<short> HtIntentosEntrevista { get; set; }
        public Nullable<short> HtTipoDeCambio { get; set; }
        public Nullable<int> HtIdTipoMoneda { get; set; }
        public Nullable<int> HtTotalDirectivosMujer { get; set; }
        public Nullable<int> HtTotalDirectivosHombre { get; set; }
        public Nullable<int> HtTotalDirectivos { get; set; }
        public Nullable<int> HtTotalProfesionalesMujer { get; set; }
        public Nullable<int> HtTotalProfesionalesHombre { get; set; }
        public Nullable<int> HtTotalProfesionales { get; set; }
        public Nullable<int> HtTotalTecnicosMujer { get; set; }
        public Nullable<int> HtTotalTecnicosHombre { get; set; }
        public Nullable<int> HtTotalTecnicos { get; set; }
        public Nullable<int> HtTotalApoyoAdminMujer { get; set; }
        public Nullable<int> HtTotalApoyoAdminHombre { get; set; }
        public Nullable<int> HtTotalApoyoAdmin { get; set; }
        public Nullable<int> HtTotalServiciosMujer { get; set; }
        public Nullable<int> HtTotalServiciosHombre { get; set; }
        public Nullable<int> HtTotalServicios { get; set; }
        public Nullable<int> HtTotalAgricultoresMujer { get; set; }
        public Nullable<int> HtTotalAgricultoresHombre { get; set; }
        public Nullable<int> HtTotalAgricultores { get; set; }
        public Nullable<int> HtTotalOperariosMujer { get; set; }
        public Nullable<int> HtTotalOperariosHombre { get; set; }
        public Nullable<int> HtTotalOperarios { get; set; }
        public Nullable<int> HtTotalOperadoresMujer { get; set; }
        public Nullable<int> HtTotalOperadoresHombre { get; set; }
        public Nullable<int> HtTotalOperadores { get; set; }
        public Nullable<int> HtTotalOcupElementalesMujer { get; set; }
        public Nullable<int> HtTotalOcupElementalesHombre { get; set; }
        public Nullable<int> HtTotalOcupElementales { get; set; }
        public Nullable<int> HtSalarioBaseTotal { get; set; }
        public Nullable<int> HtSalEspecieTotal { get; set; }
        public Nullable<int> HtPagoHrsExtraTotal { get; set; }
        public Nullable<int> HtAguinaldoTotal { get; set; }
        public Nullable<int> HtSalEscolarTotal { get; set; }
        public Nullable<int> HtRemuneracionesTotal { get; set; }
        public Nullable<int> HtTotalCostoDirectivos { get; set; }
        public Nullable<int> HtTotalCostoProfecionales { get; set; }
        public Nullable<int> HtTotalCostoTecnicos { get; set; }
        public Nullable<int> HtTotalCostoApoyoAdmin { get; set; }
        public Nullable<int> HtTotalCostoServicios { get; set; }
        public Nullable<int> HtTotalCostoAgricultores { get; set; }
        public Nullable<int> HtTotalCostoOperarios { get; set; }
        public Nullable<int> HtTotalCostoOperadores { get; set; }
        public Nullable<int> HtTotalCostoOcupElementales { get; set; }
        public Nullable<int> HtTotalCosto { get; set; }
        public Nullable<int> HtDeducccionTotal { get; set; }
        public Nullable<int> HtTotalHorasDerectivos { get; set; }
        public Nullable<int> HtTotalHorasProfecionales { get; set; }
        public Nullable<int> HtTotalHorasTecnicos { get; set; }
        public Nullable<int> HtTotalHorasApoyoAdmin { get; set; }
        public Nullable<int> HtTotalHorasServicios { get; set; }
        public Nullable<int> HtTotalHorasAgricultores { get; set; }
        public Nullable<int> HtTotalHorasOperarios { get; set; }
        public Nullable<int> HtTotalHorasOperadores { get; set; }
        public Nullable<int> HtTotalHorasOcupElementales { get; set; }
        public Nullable<int> HtTotalHorasOrdinarias { get; set; }
        public Nullable<int> HtTotalHorasExtra { get; set; }
        public Nullable<int> HtTotalHoras { get; set; }
        public Nullable<int> HtTotalOutsourcing { get; set; }
        public Nullable<int> HtTotalOutsourcingMujer { get; set; }
        public Nullable<int> HtTotalOutsourcingHombre { get; set; }
        public Nullable<int> HtIdEntrevistador { get; set; }

    }
}
