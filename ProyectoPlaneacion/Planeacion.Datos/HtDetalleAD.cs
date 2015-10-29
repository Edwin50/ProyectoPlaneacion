using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Planeacion.Entidades;
namespace Planeacion.Datos
{
    public class HtDetalleAD : IntHtDatos<HtDetalleTotales>

    {
        private HtBase2Entities contexto;
        public HtDetalleAD(HtBase2Entities contexto) {
            this.contexto = contexto;
           
        }


        public void agregarAD(HtDetalleTotales value)
        {
            try
            {
                this.contexto.HtDetalleTotales.Add(value);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void eliminarAD(HtDetalleTotales value)
        {
            try
            {
             var consulta   =  this.contexto.HtDetalleTotales.Where(det=> 
                    det.HtAngo == value.HtAngo 
                    && det.HtNumActividad == value.HtNumActividad 
                    && det.HtIdMes == value.HtIdMes 
                    && det.HtConsecutivo == value.HtConsecutivo 
                    && det.HtNumLinea == value.HtNumLinea ).FirstOrDefault();
              
                if (consulta != null){
                    this.contexto.HtDetalleTotales.Remove(consulta);
                
                }
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void modificarAD(HtDetalleTotales value)
        {
            try
            {
                var consulta = this.contexto.HtDetalleTotales.Where(det =>
                    det.HtAngo == value.HtAngo
                    && det.HtNumActividad == value.HtNumActividad
                    && det.HtIdMes == value.HtIdMes
                    && det.HtConsecutivo == value.HtConsecutivo
                    && det.HtNumLinea == value.HtNumLinea
                    && det.HtIdCamino == value.HtIdCamino ).FirstOrDefault();

                if (consulta != null)
                {
                    consulta.HtIdGrupoOcupacional = value.HtIdGrupoOcupacional;
                    consulta.HtNombre = value.HtNombre;
                    consulta.HtApellido = value.HtApellido;
                    consulta.HtCantidad = value.HtCantidad;
                    consulta.HtIdGenero = value.HtIdGenero;
                    consulta.HtIdTipoContrato = value.HtIdTipoContrato;
                    consulta.HtCedula = value.HtCedula;
                    consulta.HtIdRubro = value.HtIdRubro;
                    consulta.HtObservaciones = value.HtObservaciones;

                    this.contexto.Entry(consulta).State = EntityState.Modified;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<HtDetalleTotales> ObtenerDatos2AD()
        {
            try
            {
                return this.contexto.HtDetalleTotales.OrderBy(det => det.HtNombre).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public HtDetalleTotales ObtenerValorAD( HtDetalleTotales value)
        {
            try
            {
 var consulta = this.contexto.HtDetalleTotales.Where(det =>
                    det.HtAngo == value.HtAngo
                    && det.HtNumActividad == value.HtNumActividad
                    && det.HtIdMes == value.HtIdMes
                    && det.HtConsecutivo == value.HtConsecutivo
                    && det.HtNumLinea == value.HtNumLinea
                    && det.HtIdCamino == value.HtIdCamino).FirstOrDefault();

                if (consulta != null)
                {

                    return consulta;
                   

                }
                return null;
                   
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            
        }
    }
}
