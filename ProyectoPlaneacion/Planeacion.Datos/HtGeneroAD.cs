using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;

namespace Planeacion.Datos
{
   public class HtGeneroAD: IntHtDatos<HtGenero>

    {
         private HtBase2Entities contexto;
        public HtGeneroAD(HtBase2Entities contexto)
        {
            this.contexto = contexto;
        }

        public void agregarAD(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public void eliminarAD(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public void modificarAD(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public List<HtGenero> ObtenerDatosAD()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> ObtenerDatos2AD()
        {

            throw new NotImplementedException();
        }

        public HtGenero ObtenerValorAD(HtGenero value)
        {
            throw new NotImplementedException();
        }
    }
}
