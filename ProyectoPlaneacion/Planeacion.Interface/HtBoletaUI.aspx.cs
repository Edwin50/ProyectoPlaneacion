using Planeacion.Entidades;
using Planeacion.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Planeacion.Interface
{
    public partial class HtBoletaUI : System.Web.UI.Page
    {


        private HtBoletaLN gHtBoletaLN = new HtBoletaLN();
        #region "Eventos Page"
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cargar el dataset de las boletas
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
           // AgregarBoleta();
            this.Master.lpMensaje(this, "Esta Mica funciona");
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {

        }
        protected void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.ButtonAgregar.Visible = false;
            this.ButtonModificar.Visible = false;
            this.ButtonEliminar.Visible = false;
            ModalPopupExtender1.Hide();
            this.Master.lpMensaje(this, "No sirve el cancel");
        }
        protected void bt_Nuevo_Click(object sender, EventArgs e)
        {
            // no hace nada
            this.ButtonAgregar.Visible = true;
            this.ModalPopupExtender1.Show();
        }
        #endregion
        #region "Metodos Locales"
        private void AgregarBoleta() {
            HtBoleta lBoleta = new HtBoleta();
            lBoleta.HtIdDistrito = int.Parse(this.TextBox1.Text);
            lBoleta.HtConsecutivo = int.Parse(this.TextBox2.Text);
            lBoleta.HtNumActividad = int.Parse(this.TextBox3.Text);
            lBoleta.HtIdMes = int.Parse(this.TextBox4.Text);
            lBoleta.HtAngo = int.Parse(this.TextBox5.Text);
            lBoleta.HtNumIdentificacionNegocio = this.TextBox6.Text;
            lBoleta.HtNomNegocio = this.TextBox7.Text;
            lBoleta.HtNomLegal = this.TextBox8.Text;
            lBoleta.HtNumRazonSocial = int.Parse(this.TextBox9.Text);
            lBoleta.HtDirNegocio = this.TextBox10.Text;
            lBoleta.HtTel1Negocio = int.Parse(this.TextBox11.Text);
            lBoleta.HtExt1Negocio = int.Parse(this.TextBox12.Text);
            lBoleta.HtEmail = this.TextBox13.Text;
            lBoleta.HtCantidadTrabajadores = short.Parse(this.TextBox14.Text);
            lBoleta.HtCantidadTrabajadoresHombres = short.Parse(this.TextBox15.Text);
            lBoleta.HtCantidadTrabajadoresNujeres = short.Parse(this.TextBox16.Text);
            lBoleta.HtDescCIIUProductoPrincipal = this.TextBox17.Text;
            lBoleta.HtNumCiiu4 = this.TextBox18.Text;
            lBoleta.HtNombreInformante = this.TextBox19.Text;
            lBoleta.HtCargoDelInformante = this.TextBox20.Text;
            lBoleta.HtTelefonoInformante = int.Parse(this.TextBox21.Text);
            lBoleta.HtEmailInformante = this.TextBox22.Text;
            lBoleta.HtIdResultadoEntrevista = int.Parse(this.TextBox23.Text);
            lBoleta.HtObservaciones = this.TextBox24.Text;
            lBoleta.HtIdEmpleado = int.Parse(this.TextBox25.Text);
            lBoleta.HtHoraInicio = DateTime.Parse(this.TextBox26.Text);
            lBoleta.HtHoraFinal = DateTime.Parse(this.TextBox27.Text);
            lBoleta.HtDuracionEntrevista =this.TextBox28.Text;
            lBoleta.HtFechaEntrevista = DateTime.Parse(this.TextBox29.Text);
            lBoleta.HtFechaUltimaModificacion = DateTime.Parse(this.TextBox30.Text);
            lBoleta.HtIntentosEntrevista = short.Parse(this.TextBox31.Text);
            lBoleta.HtTipoDeCambio = short.Parse(this.TextBox32.Text);
            lBoleta.HtIdTipoMoneda = int.Parse(this.TextBox33.Text);
            lBoleta.HtTotalDirectivosMujer = int.Parse(this.TextBox34.Text);
            lBoleta.HtTotalDirectivosHombre = int.Parse(this.TextBox35.Text);
            lBoleta.HtTotalDirectivos = int.Parse(this.TextBox36.Text);
            lBoleta.HtTotalProfesionalesMujer = int.Parse(this.TextBox37.Text);
            lBoleta.HtTotalProfesionalesHombre = int.Parse(this.TextBox38.Text);
            lBoleta.HtTotalProfesionales = int.Parse(this.TextBox39.Text);
            lBoleta.HtTotalTecnicosMujer = int.Parse(this.TextBox40.Text);
            lBoleta.HtTotalTecnicosHombre = int.Parse(this.TextBox41.Text);
            lBoleta.HtTotalTecnicos = int.Parse(this.TextBox42.Text);
            lBoleta.HtTotalApoyoAdminMujer = int.Parse(this.TextBox43.Text);
            lBoleta.HtTotalApoyoAdminHombre = int.Parse(this.TextBox44.Text);
            lBoleta.HtTotalApoyoAdmin = int.Parse(this.TextBox45.Text);
            lBoleta.HtTotalServiciosMujer = int.Parse(this.TextBox46.Text);
            lBoleta.HtTotalServiciosHombre = int.Parse(this.TextBox47.Text);
            lBoleta.HtTotalServicios = int.Parse(this.TextBox48.Text);
            lBoleta.HtTotalAgricultoresMujer = int.Parse(this.TextBox49.Text);
            lBoleta.HtTotalAgricultoresHombre = int.Parse(this.TextBox50.Text);
            lBoleta.HtTotalAgricultores = int.Parse(this.TextBox51.Text);
            lBoleta.HtTotalOperariosMujer = int.Parse(this.TextBox52.Text);
            lBoleta.HtTotalOperariosHombre = int.Parse(this.TextBox53.Text);
            lBoleta.HtTotalOperarios = int.Parse(this.TextBox54.Text);
            lBoleta.HtTotalOperadoresMujer = int.Parse(this.TextBox55.Text);
            lBoleta.HtTotalOperadoresHombre = int.Parse(this.TextBox56.Text);
            lBoleta.HtTotalOperadores = int.Parse(this.TextBox57.Text);
            lBoleta.HtTotalOcupElementalesMujer = int.Parse(this.TextBox58.Text);
            lBoleta.HtTotalOcupElementalesHombre = int.Parse(this.TextBox59.Text);
            lBoleta.HtTotalOcupElementales = int.Parse(this.TextBox60.Text);
            lBoleta.HtSalarioBaseTotal = int.Parse(this.TextBox61.Text);
            lBoleta.HtSalEspecieTotal = int.Parse(this.TextBox62.Text);
            lBoleta.HtPagoHrsExtraTotal = int.Parse(this.TextBox63.Text);
            lBoleta.HtAguinaldoTotal = int.Parse(this.TextBox64.Text);
            lBoleta.HtSalEscolarTotal = int.Parse(this.TextBox65.Text);
            lBoleta.HtRemuneracionesTotal = int.Parse(this.TextBox66.Text);
            lBoleta.HtTotalCostoDirectivos = int.Parse(this.TextBox67.Text);
            lBoleta.HtTotalCostoProfecionales = int.Parse(this.TextBox68.Text);
            lBoleta.HtTotalCostoTecnicos = int.Parse(this.TextBox69.Text);
            lBoleta.HtTotalCostoApoyoAdmin = int.Parse(this.TextBox70.Text);
            lBoleta.HtTotalCostoServicios = int.Parse(this.TextBox71.Text);
            lBoleta.HtTotalCostoAgricultores = int.Parse(this.TextBox72.Text);
            lBoleta.HtTotalCostoOperarios = int.Parse(this.TextBox73.Text);
            lBoleta.HtTotalCostoOperadores = int.Parse(this.TextBox74.Text);
            lBoleta.HtTotalCostoOcupElementales = int.Parse(this.TextBox75.Text);
            lBoleta.HtTotalCosto = int.Parse(this.TextBox76.Text);
            lBoleta.HtDeducccionTotal = int.Parse(this.TextBox77.Text);
            lBoleta.HtTotalHorasDerectivos = int.Parse(this.TextBox78.Text);
            lBoleta.HtTotalHorasProfecionales = int.Parse(this.TextBox79.Text);
            lBoleta.HtTotalHorasTecnicos = int.Parse(this.TextBox80.Text);
            lBoleta.HtTotalHorasApoyoAdmin = int.Parse(this.TextBox81.Text);
            lBoleta.HtTotalHorasServicios = int.Parse(this.TextBox82.Text);
            lBoleta.HtTotalHorasAgricultores = int.Parse(this.TextBox83.Text);
            lBoleta.HtTotalHorasOperarios = int.Parse(this.TextBox84.Text);
            lBoleta.HtTotalHorasOperadores = int.Parse(this.TextBox85.Text);
            lBoleta.HtTotalHorasOcupElementales = int.Parse(this.TextBox86.Text);
            lBoleta.HtTotalHorasOrdinarias = int.Parse(this.TextBox87.Text);
            lBoleta.HtTotalHorasExtra = int.Parse(this.TextBox88.Text);
            lBoleta.HtTotalHoras = int.Parse(this.TextBox89.Text);
            lBoleta.HtTotalOutsourcing = int.Parse(this.TextBox90.Text);
            lBoleta.HtTotalOutsourcingMujer = int.Parse(this.TextBox91.Text);
            lBoleta.HtTotalOutsourcingHombre = int.Parse(this.TextBox92.Text);
            lBoleta.HtIdEntrevistador = int.Parse(this.TextBox93.Text);

            gHtBoletaLN.RUDBoletasLN(lBoleta,1);
        }
        #endregion


    }
}