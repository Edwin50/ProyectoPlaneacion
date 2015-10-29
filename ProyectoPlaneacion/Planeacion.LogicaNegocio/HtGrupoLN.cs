using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using Planeacion.Datos;
namespace Planeacion.LogicaNegocio
{
   public class HtGrupoLN
    {
       private HtBase2Entities contexto;
       private HtGrupoAD grupo;

       public HtGrupoLN() {
           contexto = new HtBase2Entities();
           grupo = new HtGrupoAD(contexto);
       
       }
        public IEnumerable<Object> ObtenerDatos2AD()
       {
           return grupo.ObtenerDatos2AD();
       }
    }
}
