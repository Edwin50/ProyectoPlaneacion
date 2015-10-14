using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Datos;
using System.Data;
using Planeacion.Entidades;

namespace Planeacion.LogicaNegocio
{
    public class HtBoletaLN
    {
        private HtBoletaAD boleta = new HtBoletaAD();

        #region "Procesos internos Boletas"
        public Int32 RUDBoletasLN(HtBoleta lBoleta, int accion)
        {
          
            return this.boleta.RUDBoletasAD(lBoleta, accion);

        }


        public List<HtBoleta> ObtenerBoletasLN()
        {

            return this.boleta.ObtenerBoletasAD();
        }

        public DataSet ObtenerDataSetBoletasLN()
        {

            return this.boleta.ObtenerDataSetBoletasAD();
        }

        #endregion

    }
}
