using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Datos;
using Planeacion.Entidades;
namespace Planeacion.LogicaNegocio
{
   public class UsuarioLN
    {
       private UsuarioAD usuario = new UsuarioAD();


       #region "Procesos internos Usuarios"
       public Int32 RUDUsuariosLN(HtUsuario user, int accion) {

           return this.usuario.RUDUsuariosAD(user, accion);

       }

       public Boolean comprobarContraseñaLN(HtUsuario user)
       {

           return this.usuario.comprobarContraseñaAD(user);
       }

       public HtUsuario comprobarUsuarioLN(HtUsuario user) {

           return this.usuario.comprobarUsuarioAD(user);
       }

       public List<HtUsuario> ObtenerUsuariosLN() {

           return this.usuario.ObtenerUsuariosAD();
       }


       #endregion


    }
}
