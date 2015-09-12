using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Entidades;
using System.Data.SqlClient;
using System.Data;
namespace Planeacion.Datos
{
    public class HtEmpleadoAD
    {

        #region "Acceso Datos Empleados"
        //Metodo quue se encarga de realizar el proceso de inseccion , eliminacion y actualizacion de la tabla de Empleados
        public Int32 RUDEmpleadosAD(HtEmpleado empleado, int accion)
        {

            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "RUD_Empleado";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();
                // @Supervisor
                com.Parameters.Add(new SqlParameter("@Id", empleado.HtIdEmpleado));
                com.Parameters.Add(new SqlParameter("@Nombre", empleado.HtNombreEmpleado));
                com.Parameters.Add(new SqlParameter("@Estado", empleado.HtEstado));
                com.Parameters.Add(new SqlParameter("@Supervisor", empleado.HtIdSupervisor));
                com.Parameters.Add(new SqlParameter("@Clave", empleado.HtClave));
                com.Parameters.Add(new SqlParameter("@tipoEmpleado", empleado.HtIdTipoEmpleado));
                com.Parameters.Add(new SqlParameter("@accion", accion));
                com.Connection.Open();
                // devuelve el numero de filas afectadas en el SQL
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                accion = 0;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return accion;
        }

        // retorna true si no existen coincidencias
        public Boolean comprobarContraseñaAD(HtEmpleado empleado)
        {
            Boolean resultado = true;
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "verificarContraseña";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();

                com.Parameters.Add(new SqlParameter("@Contraseña", empleado.HtClave));

                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {

                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return resultado;
        }

        // retorna Un Empleado que concuerde con su nombre y contraseña de lo contrario devuelve nulo
        public HtEmpleado comprobarEmpleadoAD(HtEmpleado empleado)
        {
            HtEmpleado resultado = new HtEmpleado();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "verificarEmpleado";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();

                com.Parameters.Add(new SqlParameter("@Contraseña", empleado.HtClave));
                com.Parameters.Add(new SqlParameter("@Nombre", empleado.HtNombreEmpleado));
                com.Connection.Open();

                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        resultado.HtIdEmpleado = int.Parse(dr["HtIdEmpleado"].ToString());
                        resultado.HtNombreEmpleado = dr["u.HtNombreEmpleado"].ToString();
                      

                    }
                }
            }
            catch (Exception ex)
            {
                resultado = null;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return resultado;
        }


        // metodo que devuelve una lista de Empleados, solo para administradores
        public List<HtEmpleado> ObtenerEmpleadosAD()
        {
            List<HtEmpleado> listaEmpleados = new List<HtEmpleado>();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "seleccionarEmpleados";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HtEmpleado lEmpleado = new HtEmpleado();
                        lEmpleado.HtIdEmpleado = int.Parse(dr["HtIdEmpleado"].ToString());
                        lEmpleado.HtNombreEmpleado = dr["HtNombreEmpleado"].ToString();
                        lEmpleado.HtIdSupervisor = int.Parse(dr["HtIdSupervisor"].ToString());
                        lEmpleado.HtClave = dr["HtClave"].ToString();
                        lEmpleado.HtIdTipoEmpleado = int.Parse(dr["HtIdTipoEmpleado"].ToString());
                        lEmpleado.HtEstado = Boolean.Parse(dr["HtEstado"].ToString());
                     
                        listaEmpleados.Add(lEmpleado);
                    }
                }
            }
            catch (Exception ex)
            {
                listaEmpleados = null;
                // esta excepcion solo es para pruebas
                throw ex;

            }
            finally
            {
                if (com.Connection.State == System.Data.ConnectionState.Open)
                {
                    com.Connection.Close();
                }
                com.Dispose();

            }

            return listaEmpleados;
        }



        #endregion
    }
}
