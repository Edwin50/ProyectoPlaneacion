using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeacion.Datos
{
   public  class ConexionAD
    {

       #region Get_Conexion()

       public static SqlConnection GET_CONEXION()  
       {

           return new SqlConnection(String.Format(@"Server=ALONSO-PC;Database=HtBase2;User Id=Alonso;Password=1234;"));
       }
       #endregion
    }
}
