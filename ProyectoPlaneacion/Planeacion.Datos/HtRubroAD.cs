using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
namespace Planeacion.Datos
{
  public  class HtRubroAD: IntHtDatos<HtRubro>
    {

        private HtBase2Entities contexto;
        public HtRubroAD(HtBase2Entities contexto)
        {
            this.contexto = contexto;
        }
        public void agregarAD(HtRubro value)
        {
            throw new NotImplementedException();
        }

        public void eliminarAD(HtRubro value)
        {
            throw new NotImplementedException();
        }

        public void modificarAD(HtRubro value)
        {
            throw new NotImplementedException();
        }

        public List<HtRubro> ObtenerDatosAD()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerDatos2AD()
        {

            try {
                var lista = this.contexto.HtRubro.Select(ru => new { ru.HtIdRubro, ru.HtDescripRubro });
            return lista;
            }
            catch (Exception)
            {
                return null; throw new NotImplementedException();
            }
           
        }

        public HtRubro ObtenerValorAD(HtRubro value)
        {
            throw new NotImplementedException();
        }
    }
}
