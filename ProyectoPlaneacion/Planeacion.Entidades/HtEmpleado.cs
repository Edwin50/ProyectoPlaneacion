using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.Entidades
{
    public class HtEmpleado
    {
        # region "Atributos"

        public Int32 HtIdEmpleado { set; get; }
        public Int32 HtIdSupervisor { set; get; }
        public String HtNombreEmpleado { set; get; }
        public String HtClave { set; get; }
        public Int32 HtIdTipoEmpleado { set; get; }
        public Boolean HtEstado { set; get; }
        #endregion

        
    }
}
