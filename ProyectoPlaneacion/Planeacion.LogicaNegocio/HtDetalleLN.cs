using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using Planeacion.Datos;
namespace Planeacion.LogicaNegocio
{

    public class HtDetalleLN : IntLogica<HtDetalleTotales>

    {
        private HtBase2Entities contexto1;
        private HtDetalleAD detalleAD;

        public HtDetalleLN() {
            this.contexto1 = new HtBase2Entities();
            this.detalleAD = new HtDetalleAD(contexto1);
        
        }

        public void agregarLN(HtDetalleTotales value)
        {
            detalleAD.agregarAD(value);
            this.contexto1.SaveChanges();


            
        }

        public void eliminarLN(HtDetalleTotales value)
        {

            detalleAD.eliminarAD(value);
            this.contexto1.SaveChanges();
        }

        public void modificarLN(HtDetalleTotales value)
        {
            detalleAD.modificarAD(value);
            this.contexto1.SaveChanges();
        }

        public List<HtDetalleTotales> ObtenerDatosLN()
        {
            return this.detalleAD.ObtenerDatos2AD();
        }

        public HtDetalleTotales ObtenerValorLN(HtDetalleTotales value)
        {
            return this.detalleAD.ObtenerValorAD(value);
        }
    }
}