using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planeacion.Datos;
using Planeacion.Entidades;
namespace Planeacion.LogicaNegocio
{
    public class HtEmpleadoLN
    {
        private HtEmpleadoAD empleado = new HtEmpleadoAD();

        #region "Procesos internos Empleados"
        public Int32 RUDEmpleadosLN(HtEmpleado user, int accion)
        {
            
            return this.empleado.RUDEmpleadosAD(user, accion);

        }

        public Boolean comprobarContraseñaLN(HtEmpleado user)
        {

            return this.empleado.comprobarContraseñaAD(user);
        }

        public HtEmpleado comprobarEmpleadoLN(HtEmpleado user)
        {

            return this.empleado.comprobarEmpleadoAD(user);
        }

        public List<HtEmpleado> ObtenerEmpleadosLN()
        {

            return this.empleado.ObtenerEmpleadosAD();
        }


        #endregion

    }
}
