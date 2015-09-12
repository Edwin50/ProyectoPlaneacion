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
    public class UsuarioAD
    {

        #region "Acceso Datos Usuarios"
        //Metodo quue se encarga de realizar el proceso de inseccion , eliminacion y actualizacion de la tabla de usuarios
        public Int32 RUDUsuariosAD( HtUsuario user,int accion) {
            
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try {

                com.CommandText = "RUD_Usuarios";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();
                com.Parameters.Add(new SqlParameter("@Id",user.Id ));
                com.Parameters.Add(new SqlParameter("@Nombre", user.Nombre));
                com.Parameters.Add(new SqlParameter("@Apellido", user.Apellido));
               
                com.Parameters.Add(new SqlParameter("@Contraseña", user.Contraseña));
                com.Parameters.Add(new SqlParameter("@tipoUsuario", user.tipoUsuario));
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
            finally {
                if (com.Connection.State == System.Data.ConnectionState.Open) {
                    com.Connection.Close();
                }
                com.Dispose();
            
            }

            return accion;
        }

        // retorna true si no existen coincidencias
        public Boolean comprobarContraseñaAD(HtUsuario user)
        {
            Boolean resultado = true;
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "verificarContraseña";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();
                
                com.Parameters.Add(new SqlParameter("@Contraseña", user.Contraseña));
               
                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();
                
                if (dr.HasRows){
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

        // retorna Un usuario que concuerde con su nombre y contraseña de lo contrario devuelve nulo
        public HtUsuario comprobarUsuarioAD(HtUsuario user)
        {
            HtUsuario resultado = new HtUsuario();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "verificarUsuario";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Clear();
                
                com.Parameters.Add(new SqlParameter("@Contraseña", user.Contraseña));
                com.Parameters.Add(new SqlParameter("@Nombre", user.Nombre));
                com.Connection.Open();
               
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read()) {

                        resultado.Id =  int.Parse(dr["Id"].ToString());
                        resultado.Nombre = dr["Nombre"].ToString();
                        resultado.Apellido = dr["Apellido"].ToString();
                    
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


        // metodo que devuelve una lista de usuarios, solo para administradores
        public List<HtUsuario> ObtenerUsuariosAD()
        {
            List<HtUsuario> listaUsuarios = new List<HtUsuario>();
            SqlCommand com = ConexionAD.GET_CONEXION().CreateCommand();
            try
            {

                com.CommandText = "seleccionarUsuarios";
                com.CommandType = CommandType.StoredProcedure;

                com.Connection.Open();
                // 
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        HtUsuario lUsuario = new HtUsuario();
                        lUsuario.Id = int.Parse(dr["Id"].ToString());
                        lUsuario.Nombre = dr["Nombre"].ToString();
                        lUsuario.Apellido = dr["Apellido"].ToString();
                        lUsuario.Contraseña = dr["Contraseña"].ToString();
                        lUsuario.tipoUsuario = int.Parse(dr["tipoUsuario"].ToString());
                        listaUsuarios.Add(lUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                listaUsuarios = null;
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

            return listaUsuarios;
        }



        #endregion


    }
}
