using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.Entidades
{
    public class HtUsuario
    {
        # region "Atributos"

        public Int32 Id { set; get; }
        public String Nombre { set; get; }
        public String Apellido{ set; get; }
       
        public String Contraseña { set; get; }
        public Int32 tipoUsuario { set; get; }
        #endregion
    }
}
