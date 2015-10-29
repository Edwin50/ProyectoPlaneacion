using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
namespace Planeacion.Datos
{
    public class HtGrupoAD : IntHtDatos<HtGrupoOcupacional>
    {

        private HtBase2Entities contexto;
        public HtGrupoAD(HtBase2Entities contexto)
        {
            this.contexto = contexto;
        }
        public void agregarAD(HtGrupoOcupacional value)
        {

        }

        public void eliminarAD(HtGrupoOcupacional value)
        {

        }

        public void modificarAD(HtGrupoOcupacional value)
        {
            throw new NotImplementedException();
        }

        public List<HtGrupoOcupacional> ObtenerDatosAD()
        {
            return this.contexto.HtGrupoOcupacional.ToList();
        }

        public HtGrupoOcupacional ObtenerValorAD(HtGrupoOcupacional value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Object> ObtenerDatos2AD()
        {
            try
            {
                var lista = this.contexto.HtGrupoOcupacional.Select(gru => new { gru.HtIdGrupoOcupacional, gru.HtDescripGrupoOcupacional });
                return lista;
            }catch(Exception){
                return null;
            }
        }
    }
}
