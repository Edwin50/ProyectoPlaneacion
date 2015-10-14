using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Planeacion.LogicaNegocio
{
  public  class TipoCambioLN
    {

        private wsIndicadoresEconomicos.wsIndicadoresEconomicos ws ;


        public String fnTipoCambioDolar()
        {

            DataSet dsdolar = new DataSet();

            String i = String.Empty;
           
            ws = new wsIndicadoresEconomicos.wsIndicadoresEconomicos();
            try
            {

                dsdolar = ws.ObtenerIndicadoresEconomicos("317", String.Format("{0:dd/MM/yyyy}", DateTime.Now), String.Format("{0:dd/MM/yyyy}", DateTime.Now), "A", "N");
                i = dsdolar.Tables[0].Rows[0]["NUM_VALOR"].ToString();
          //      i = i.Replace(",", ".");
              
            }
            catch (Exception ex)
            {
                i = "0";
                throw ex;
            }
            float  x = float.Parse(i);
            return x.ToString();
        }
    }
}
