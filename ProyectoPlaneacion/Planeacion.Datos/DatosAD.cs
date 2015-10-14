using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Planeacion.Datos
{
  public  class DatosAD
    {

      private SqlConnection sqlConn = ConexionAD.GET_CONEXION();
       private  SqlCommand sqlcomm ;
       public DataSet fnObteneDistritosAD()
      {
          DataSet ds = new DataSet();
          sqlcomm = new SqlCommand();
          sqlcomm.Connection = sqlConn;
          using (sqlConn)
          {
              try
              {
                  using (SqlDataAdapter da = new SqlDataAdapter())
                  {


                      sqlcomm.CommandText = "sp_ObtenerDistritos";
                      sqlcomm.CommandType = CommandType.StoredProcedure;
                      da.SelectCommand = sqlcomm;
                      da.SelectCommand.CommandType = CommandType.StoredProcedure;
                      da.Fill(ds);
                      return ds;
                  }
              }
           
              catch (Exception e)
              {
                  Console.WriteLine("Error: " + e.Message);
              }
          }
          return ds;
      }

       public DataSet fnObtenerRazonSocialAD()
      {
          DataSet ds = new DataSet();
          sqlcomm = new SqlCommand();
          sqlcomm.Connection = sqlConn;
          using (sqlConn)
          {
              try
              {
                  using (SqlDataAdapter da = new SqlDataAdapter())
                  {


                      sqlcomm.CommandText = "sp_ObtenerRazonSocial";
                      sqlcomm.CommandType = CommandType.StoredProcedure;
                      da.SelectCommand = sqlcomm;
                      da.SelectCommand.CommandType = CommandType.StoredProcedure;
                      da.Fill(ds);
                      return ds;
                  }
              }

              catch (Exception e)
              {
                  Console.WriteLine("Error: " + e.Message);
              }
          }
          return ds;
      }
      public DataSet fnObtenerCIIU4AD()
      {
          DataSet ds = new DataSet();
          sqlcomm = new SqlCommand();
          sqlcomm.Connection = sqlConn;
          using (sqlConn)
          {
              try
              {
                  using (SqlDataAdapter da = new SqlDataAdapter())
                  {


                      sqlcomm.CommandText = "sp_ObtenerCIIU4";
                      sqlcomm.CommandType = CommandType.StoredProcedure;
                      da.SelectCommand = sqlcomm;
                      da.SelectCommand.CommandType = CommandType.StoredProcedure;
                      da.Fill(ds);
                      return ds;
                  }
              }

              catch (Exception e)
              {
                  Console.WriteLine("Error: " + e.Message);
              }
          }
          return ds;
      }
      public DataSet fnObtenerResultadoEntrevistaAD()
      {
          DataSet ds = new DataSet();
          sqlcomm = new SqlCommand();
          sqlcomm.Connection = sqlConn;
          using (sqlConn)
          {
              try
              {
                  using (SqlDataAdapter da = new SqlDataAdapter())
                  {


                      sqlcomm.CommandText = "sp_ObtenerResultadoEntrevista";
                      sqlcomm.CommandType = CommandType.StoredProcedure;
                      da.SelectCommand = sqlcomm;
                      da.SelectCommand.CommandType = CommandType.StoredProcedure;
                      da.Fill(ds);
                      return ds;
                  }
              }

              catch (Exception e)
              {
                  Console.WriteLine("Error: " + e.Message);
              }
          }
          return ds;
      }
      public DataSet fnObtenerMonedaAD()
      {
          DataSet ds = new DataSet();
          sqlcomm = new SqlCommand();
          sqlcomm.Connection = sqlConn;
          using (sqlConn)
          {
              try
              {
                  using (SqlDataAdapter da = new SqlDataAdapter())
                  {


                      sqlcomm.CommandText = "sp_ObtenerMoneda";
                      sqlcomm.CommandType = CommandType.StoredProcedure;
                      da.SelectCommand = sqlcomm;
                      da.SelectCommand.CommandType = CommandType.StoredProcedure;
                      da.Fill(ds);
                      return ds;
                  }
              }

              catch (Exception e)
              {
                  Console.WriteLine("Error: " + e.Message);
              }
          }
          return ds;
      }
    
    }
}
