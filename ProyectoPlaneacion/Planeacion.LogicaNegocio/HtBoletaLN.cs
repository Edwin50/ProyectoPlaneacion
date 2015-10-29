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

        public DataTable BoletasPersonalizadaLN() {
            DataTable dt = new DataTable();
         
            try{

                dt.Columns.Add("HtNumActividad",typeof(int));
                dt.Columns.Add("HtConsecutivo",typeof(int));
                dt.Columns.Add("HtIdMes",typeof(int));
                dt.Columns.Add("HtAngo",typeof(int));
                dt.Columns.Add("HtNomNegocio",typeof(String));
                dt.Columns.Add("HtTel1Negocio",typeof(int));
     
           List<HtBoleta> lista= ObtenerBoletasLN();
                foreach( HtBoleta boleta in lista) {
                    DataRow dr = dt.NewRow();
                    dr[0] = boleta.HtNumActividad;
                    dr[1] = boleta.HtConsecutivo;
                    dr[2] = boleta.HtIdMes;
                    dr[3] = boleta.HtAngo;
                    dr[4] = boleta.HtNomNegocio;
                    dr[5] = boleta.HtTel1Negocio;
                    dt.Rows.Add(dr);
                }



                return dt;


            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            throw;
            }
        }

      public HtBoleta  ObtenerBoletaIndividuaLN (int numActividad,int consecutivo, int mes, int ango){

          try {
              return this.boleta.ObtenerBoletaIndividualAD(numActividad, consecutivo,  mes,  ango);
          }
          catch (Exception ex) {

              throw ex;
          }
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
