using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using Planeacion.Datos;
namespace Planeacion.LogicaNegocio
{
   public class HtRubroLN: IntLogica<HtRubro>
    {
       private HtBase2Entities contexto;
       private HtRubroAD rubroAD;

       public HtRubroLN(){
           contexto=new HtBase2Entities ();
           rubroAD = new HtRubroAD(contexto);
       }

       public void agregarLN(HtRubro value)
       {
           throw new NotImplementedException();
       }

       public void eliminarLN(HtRubro value)
       {
           throw new NotImplementedException();
       }

       public void modificarLN(HtRubro value)
       {
           throw new NotImplementedException();
       }

       public List<HtRubro> ObtenerDatosLN()
       {
           throw new NotImplementedException();
       }

       public HtRubro ObtenerValorLN(HtRubro value)
       {
           throw new NotImplementedException();
       }
       public IEnumerable<object> Obtener2DatosLN()
       {
           return rubroAD.ObtenerDatos2AD();
           
       }
    }
}
