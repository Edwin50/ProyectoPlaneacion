using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Planeacion.Interface
{
    public partial class UI : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        #region "Propiedades"


        public String TituloBarra {
            get { return this.Page.Title; }
            set { this.Page.Title = value; }
        
        }

        public String TituloLocal
        {
            get
            {
                return this.Label1.Text;
            }
            set
            {
                this.Label1.Text = value;
            }
        }

      
        #endregion

        public void lpMensaje(Page pagina, String Mensaje)
        {
            ScriptManager.RegisterStartupScript(pagina, pagina.GetType(), "Alert", "alert('" + Mensaje + "');", true);
        }

    }
}