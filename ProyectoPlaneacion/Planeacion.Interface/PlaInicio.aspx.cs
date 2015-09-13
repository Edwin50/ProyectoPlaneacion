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
            if(IsPostBack){
                Session["Clave"] = Txt_Contraseña.Text;
            }
        }

        protected void bt_Login_Click(object sender, EventArgs e)
        {
            if (this.fnComprobarCamposLogin())
            {
                lpAccionLogin();
            }
           
        }
        protected void btnOkay_Click(object sender, EventArgs e)
        {
            try {
                if (fnComprobarCamposRegistro())
                {
                    this.Panel1.Attributes.Add("Style", "display:none");  
                    registrarEmpleado();
                   
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            
        }
        
        #endregion

        #region "Procesos Locales"

        private void registrarEmpleado() {
            HtEmpleado empleado = new HtEmpleado();
            empleado.HtIdSupervisor = 1;
            empleado.HtEstado = true;
            empleado.HtIdTipoEmpleado = 1;
            int accion = 1;
            empleado.HtNombreEmpleado= Txt_NombreRegistro.Text;
            empleado.HtClave = Txt_Contrasena.Text;

            try
            {
                if (gEmpleado.comprobarContraseñaLN(empleado))
                {
                    if (gEmpleado.RUDEmpleadosLN(empleado, accion) == 1)
                    {
                        lpMensajeScript("Se logro insertar su  nuevo usuario");
                        lpLimpiarRegistro();
                        this.ModalPopUp1.Hide();
                    }
                }
                else
                {
                    lpMensajeScript("Contraseña no valida");
                    this.ModalPopUp1.Show();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        private void lpAccionLogin() {
            HtEmpleado empleado = new HtEmpleado();

            try
            {
                empleado.HtNombreEmpleado = Txt_Nombre.Text;
                empleado.HtClave = (String)Session["Clave"];
                HtEmpleado lEmple = this.gEmpleado.comprobarEmpleadoLN(empleado);
                if (lEmple != null)
                {
                    Session["Empleado"] = lEmple;
                    Response.Redirect("WebForm1.aspx",false);
                }
                else {
                    this.Panel1.Attributes.Add("Style", "display:none");
                    this.ModalPopUp1.Hide();
                    lpMensajeScript("El nombre de empleado o contraseña son incorrectos");
                }
            }
            catch (Exception ex)
            {
                lpMensajeScript(ex.Message);
             
                throw ex;
            }
        }


        private void lpLimpiarLogin() {
            this.Txt_Nombre.Text = String.Empty;
        }

        private void lpLimpiarRegistro() {
            this.Txt_NombreRegistro.Text = String.Empty;
        }
        private void lpMensajeScript(String Mensaje)
        {
            try
            {
               ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertBox", "alert('" + Mensaje + "');", true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region "Validaciones"
        private Boolean fnComprobarCamposLogin() {
            Boolean result = true;
            try { 
                    
                    if (this.Txt_Nombre.Text == String.Empty) {
                        lpMensajeScript("El nombre es un campo requerido");
                        return false;
                    }
                    if (this.Txt_Contraseña.Text == String.Empty)
                    {
                        lpMensajeScript("La contraseña es un campo requerido");
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
                   
                    this.Panel1.Attributes.Add("Style", "display:none");
                    lpMensajeScript("La nombre es un campo requerido");
                    ModalPopUp1.Show();
                    return false;
                }
                if (this.Txt_Contrasena.Text == String.Empty)
                {
                    this.Panel1.Attributes.Add("Style", "display:none");
                    lpMensajeScript("La contraseña es un campo requerido");
                    ModalPopUp1.Show();
                    return false;
                }
                if (this.Txt_ContrasenaConfirm.Text == String.Empty)
                {

                    this.Panel1.Attributes.Add("Style", "display:none");
                    lpMensajeScript("La confirmacion de contraseña es un campo requerido");
                    ModalPopUp1.Show();
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