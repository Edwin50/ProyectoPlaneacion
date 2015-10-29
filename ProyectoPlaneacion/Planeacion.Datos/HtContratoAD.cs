using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
namespace Planeacion.Datos
{
   public class HtContratoAD: IntHtDatos<HtTipoContrato>
    {

         private HtBase2Entities contexto;
        public HtContratoAD(HtBase2Entities contexto)
        {
            this.contexto = contexto;
        }

        public void agregarAD(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public void eliminarAD(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public void modificarAD(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }

        public List<HtTipoContrato> ObtenerDatosAD()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerDatos2AD()
        {
            try
            {
                var lista= this.contexto.HtTipoContrato.Select(con => new {con.HtIdContrato,con.HtDescripTipoContrato});
                return lista;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public HtTipoContrato ObtenerValorAD(HtTipoContrato value)
        {
            throw new NotImplementedException();
        }
    }
}
