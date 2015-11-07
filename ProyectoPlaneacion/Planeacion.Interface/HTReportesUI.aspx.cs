using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
namespace Planeacion.Interface
{
    public partial class HTReportesUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Master.TituloBarra = "Reportes";
            this.Master.TituloLocal = "Reportes";
            if (!this.IsPostBack)
            {

                DropDownListReport.Items.Add(new ListItem("Fechas", "ReportePorFechas"));
                DropDownListReport.Items.Add(new ListItem("Entrevistas", "ReporteEntrevistados"));
                DropDownListReport.Items.Add(new ListItem("Resultados", "ReporteResultados"));
                DropDownListReport.Items.Add(new ListItem("Cantidad Empleados", "ReporteCantidad"));
                DropDownListReport.Items.Add(new ListItem("Empresas Apoyadas por Outsourcing", "ReportOutSour"));
                DropDownListReport.Items.Add(new ListItem("Rango de Duracion de entrevistas", "ReportRangoHoras"));
                DropDownListReport.SelectedIndex = 0;
                lpCargarReportes(DropDownListReport.SelectedValue);
            }
        }

        protected void DropDownListReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lpCargarReportes(DropDownListReport.SelectedValue);
        }

        private void lpCargarReportes(string value) {
            Session["sinPara"] = value ;
            try
            {
                DataSourceCredentials dsCredentials = new DataSourceCredentials();

                dsCredentials.Name = "ALONSO-PC";

                ReportViewer1.ShowCredentialPrompts = false;

                dsCredentials.UserId = "Alonso";
                dsCredentials.Password = "edrich434";

                ReportViewer1.ServerReport.ReportServerCredentials = new ReportCredentials("Alonso", "edrich434", "ALONSO-PC");

                ReportViewer1.ServerReport.ReportServerUrl = new System.Uri("http://alonso-pc/ReportServer");

                ReportViewer1.ServerReport.ReportPath = "/ReportIng/" + (String)Session["sinPara"];

                ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;


                ReportViewer1.ServerReport.Refresh();
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this,ex.Message);

            }
        }

      

    }
}