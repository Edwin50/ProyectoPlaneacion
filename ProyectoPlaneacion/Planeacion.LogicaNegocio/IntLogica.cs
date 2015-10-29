using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.LogicaNegocio
{
  interface IntLogica<T> where T : class
    {

        void agregarLN(T value);
        void eliminarLN(T value);
        void modificarLN(T value);
        List<T> ObtenerDatosLN();
        T ObtenerValorLN(T value);
    }
}
