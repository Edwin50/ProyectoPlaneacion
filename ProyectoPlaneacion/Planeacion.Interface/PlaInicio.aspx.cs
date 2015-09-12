using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Planeacion.Entidades;
using Planeacion.LogicaNegocio;

namespace Planeacion.Interface
{
    public partial class PlaInicio : System.Web.UI.Page
    {

        #region "Variables Globales"
      private  HtEmpleadoLN gEmpleado;
        #endregion


        #region "Eventos Page"

        protected void Page_Load(object sender, EventArgs e)
        {
            gEmpleado = new HtEmpleadoLN();
        }

        protected void bt_Login_Click(object sender, EventArgs e)
        {
            if (this.fnComprobarCamposLogin())
            {
                lpAccionLogin();
            }
           
        }

        
        #endregion

        #region "Procesos Locales"

        private void registrarEmpleado() {
            HtEmpleado empleado = new HtEmpleado();
            empleado.HtIdSupervisor = 1;
            empleado.HtEstado = true;
            int accion = 1;
            empleado.HtNombreEmpleado= Txt_Nombre.Text;
            empleado.HtClave = Txt_Contrasena.Text;
            if(gEmpleado.comprobarContraseñaLN(empleado))
            {
           if(gEmpleado.RUDEmpleadosLN(empleado,accion)==1){
               lpMensajeScript("Se logro insertar su usuario");
           }
            }else{
                lpMensajeScript("Contraseña no valida");
            }

        }
        private void lpAccionLogin() {
            HtEmpleado empleado = new HtEmpleado();

            try
            {
                empleado.HtNombreEmpleado = Txt_Nombre.Text;
                empleado.HtClave = Txt_Contrasena.Text;
                HtEmpleado lEmple = this.gEmpleado.comprobarEmpleadoLN(empleado);
                if (lEmple != null)
                {
                    Session["Empleado"] = lEmple;
                    Response.Redirect("WebForm1.aspx");
                }
                else {
                    lpMensajeScript("El nombre de empleado o contraseña son incorrectos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void lpMensajeScript(String Mensaje)
        {
            try
            {
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('" + Mensaje + "');", true);

            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #region "Validaciones"
        private Boolean fnComprobarCamposLogin() {
            Boolean result = true;
            try { 
                    if(this.Txt_Contraseña.Text == String.Empty){
                        lpMensajeScript("La contraseña es un campo requerido");
                        return false;
                    }
                    if (this.Txt_Nombre.Text == String.Empty) {
                        lpMensajeScript("El nombre es un campo requerido");
                        return false;
                    }
            
            }
            catch (Exception ex) {
                throw ex;
            }

            return result;
        }
        private Boolean fnComprobarCamposRegistro()
        {
            Boolean result = true;
            try
            {
                if (this.Txt_NombreRegistro.Text == String.Empty)
                {
                    lpMensajeScript("La nombre es un campo requerido");
                    return false;
                }
                if (this.Txt_Contrasena.Text == String.Empty)
                {
                    lpMensajeScript("La contraseña es un campo requerido");
                    return false;
                }
                if (this.Txt_ContrasenaConfirm.Text == String.Empty)
                {
                    lpMensajeScript("La confirmacion de contraseña es un campo requerido");
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        #endregion
    }
}