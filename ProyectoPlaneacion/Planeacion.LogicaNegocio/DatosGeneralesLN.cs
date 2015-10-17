using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Planeacion.Datos;
namespace Planeacion.LogicaNegocio
{
    public class DatosGeneralesLN
    {
        private DatosAD datas = new DatosAD();
        private HtBoletaAD boletaAD = new HtBoletaAD();
        public DataSet fnObteneDistritosLN()
        {

            try
            {
                return datas.fnObteneDistritosAD();
            }


            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }


        }

        public DataSet fnObtenerRazonSocialLN()
        {

            try
            {

                return datas.fnObtenerRazonSocialAD();


            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }

        }
        public DataSet fnObtenerCIIU4LN()
        {
            try
            {

                return datas.fnObtenerCIIU4AD();


            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }
        public DataSet fnObtenerResultadoEntrevistaLN()
        {
            try
            {

                return datas.fnObtenerResultadoEntrevistaAD();


            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }
        public DataSet fnObtenerMonedaLN()
        {
            try
            {

                return datas.fnObtenerMonedaAD();


            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }

        }

        public DataSet fnObtenerMesLN()
        {
        
            
                try
                {
               return datas.fnObtenerMesAD();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                       return null;
                }
            }
        public DataSet fnObteneAngoLN()
        {
       
                try
                {
               return datas.fnObteneAngoAD();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                       return null;
                }
        }

        public DataSet fnObteneEmpleadoLN()
        {

            try
            {
                return datas.fnObteneEmpleadoAD();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }
        public int fnObteneConsecutivoLN()
        {

            try
            {
                return boletaAD.ObtenerBoletasAD().Count + 1;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return 0;
            }
        }

    }
}
