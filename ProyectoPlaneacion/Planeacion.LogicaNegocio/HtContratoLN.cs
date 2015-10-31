using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using Planeacion.Datos;
namespace Planeacion.LogicaNegocio
{
  public  class HtContratoLN: IntLogica<HtTipoContrato>
    {

      private HtBase2Entities contexto;

      private HtContratoAD contratoAD;
      public HtContratoLN() {
          contexto = new HtBase2Entities();
          contratoAD = new HtContratoAD(contexto);
      }
        public void agregarLN(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public void eliminarLN(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public void modificarLN(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public List<HtTipoContrato> ObtenerDatosLN()
        {
            throw new NotImplementedException();
        }

        public HtTipoContrato ObtenerValorLN(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<object> Obtener2DatosLN()
        {
            return this.contratoAD.ObtenerDatos2AD();
            throw new NotImplementedException();
        }
    }
}
