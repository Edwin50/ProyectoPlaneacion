using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Datos;
using Planeacion.Entidades;
namespace Planeacion.LogicaNegocio
{
    public class HtGeneroLN : IntLogica<HtGenero>
    {

        private HtGeneroAD generoAD;
        private HtBase2Entities contexto;

        public HtGeneroLN()
        {
            contexto = new HtBase2Entities();
            generoAD = new HtGeneroAD(contexto);
        }
        public void agregarLN(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public void eliminarLN(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public void modificarLN(HtGenero value)
        {
            throw new NotImplementedException();
        }

        public List<HtGenero> ObtenerDatosLN()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Object> ObtenerDatos2LN()
        {
            return generoAD.ObtenerDatos2AD();
        }
        public HtGenero ObtenerValorLN(HtGenero value)
        {
            throw new NotImplementedException();
        }
    }
}
