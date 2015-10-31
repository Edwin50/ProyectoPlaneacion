using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.Datos
{
    interface IntHtDatos<T> where T : class

    {
        
        void agregarAD(T value);
        void eliminarAD(T value);
        void modificarAD(T value);
        List<T> ObtenerDatosAD();
        IEnumerable<object> ObtenerDatos2AD();
        T ObtenerValorAD(T value);

    }
}
