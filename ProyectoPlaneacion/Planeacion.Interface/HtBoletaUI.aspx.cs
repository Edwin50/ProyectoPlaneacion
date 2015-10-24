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
        private DatosGeneralesLN dg = new DatosGeneralesLN();
        private TipoCambioLN cambio = new TipoCambioLN();
        private HtBoletaLN gHtBoletaLN = new HtBoletaLN();
        #region "Eventos Page"
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var dia = DateTime.Now;

                this.TextBox32.Text = cambio.fnTipoCambioDolar();
                this.TextBox32.ReadOnly = true;
                if (!this.IsPostBack)
                { // carga la pagina por primera vez
                    TextBox26.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                    TextBox27.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                    TextBox29.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                    this.TextBox30.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                    lpllenarCombos();
                    lpCargarGridEncabezado();
                }
                else
                {//  ocurre cuando hay un poskback
                    lpCargarGridEncabezado();
                }
                // Cargar el dataset de las boletas
                this.Master.TituloLocal = "Mantenimiento de Boletas";
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }

        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarBoleta();
            lpCargarGridEncabezado();
            lpLimpiarBoleta();
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            ActualizarBoleta();
            lpCargarGridEncabezado();
            lpLimpiarBoleta();
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            EliminarBoleta();
            lpCargarGridEncabezado();
            lpLimpiarBoleta();
        }
        protected void bt_Cancel_Click(object sender, EventArgs e)
        {
            lpCargarGridEncabezado();
            lpLimpiarBoleta();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int[] datosBoleta = new int[4];

                datosBoleta[0] = int.Parse(GridView1.SelectedRow.Cells[1].Text); // numActividad
                datosBoleta[1] = int.Parse(GridView1.SelectedRow.Cells[2].Text); // consecutivo
                datosBoleta[2] = int.Parse(GridView1.SelectedRow.Cells[3].Text); // mes
                datosBoleta[3] = int.Parse(GridView1.SelectedRow.Cells[4].Text); // ango

                var boleta = gHtBoletaLN.ObtenerBoletaIndividuaLN(datosBoleta[0], datosBoleta[1], datosBoleta[2], datosBoleta[3]);
                lpCargarBoleta(boleta);
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                DropDownListMes.Enabled = false;
                DropDownListAngo.Enabled = false;
                this.ButtonAgregar.Visible = false;
                this.ButtonModificar.Visible = true;
                this.ButtonEliminar.Visible = true;
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }
        }
        #endregion

        #region "Metodos Locales"
        private void lpCargarGridEncabezado()
        {

            try
            {


                GridView1.DataSource = gHtBoletaLN.BoletasPersonalizadaLN();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);

            }

        }
        private void lpCargarBoleta(HtBoleta lBoleta)
        {
            try
            {
                DropDownListDistrito.SelectedValue = "" + lBoleta.HtIdDistrito;
                TextBox2.Text = "" + lBoleta.HtConsecutivo;
                TextBox3.Text = "" + lBoleta.HtNumActividad;
                DropDownListMes.SelectedValue = "" + lBoleta.HtIdMes;
                DropDownListAngo.SelectedValue = "" + lBoleta.HtAngo;
                TextBox6.Text = "" + lBoleta.HtNumIdentificacionNegocio;
                TextBox7.Text = "" + lBoleta.HtNomNegocio;
                TextBox8.Text = "" + lBoleta.HtNomLegal;
                DropDownListRazon.SelectedValue = "" + lBoleta.HtNumRazonSocial;
                TextBox10.Text = "" + lBoleta.HtDirNegocio;
                TextBox11.Text = "" + lBoleta.HtTel1Negocio;
                TextBox12.Text = "" + lBoleta.HtExt1Negocio;
                TextBox13.Text = "" + lBoleta.HtEmail;
                TextBox14.Text = "" + lBoleta.HtCantidadTrabajadores;
                TextBox15.Text = "" + lBoleta.HtCantidadTrabajadoresHombres;
                TextBox16.Text = "" + lBoleta.HtCantidadTrabajadoresNujeres;
                TextBox17.Text = "" + lBoleta.HtDescCIIUProductoPrincipal;
                DropDownListCIIU.SelectedValue = "" + lBoleta.HtNumCiiu4;
                TextBox19.Text = "" + lBoleta.HtNombreInformante;
                TextBox20.Text = "" + lBoleta.HtCargoDelInformante;
                TextBox21.Text = "" + lBoleta.HtTelefonoInformante;
                TextBox22.Text = "" + lBoleta.HtEmailInformante;
                DropDownListEntrevista.SelectedValue = "" + lBoleta.HtIdResultadoEntrevista;
                TextBox24.Text = "" + lBoleta.HtObservaciones;
                DropDownListEmpleado.SelectedValue = "" + lBoleta.HtIdEmpleado;
                TextBox26.Text = "" + lBoleta.HtHoraInicio;
                TextBox27.Text = "" + lBoleta.HtHoraFinal;
                TextBox28.Text = "" + lBoleta.HtDuracionEntrevista;
                TextBox29.Text = "" + lBoleta.HtFechaEntrevista;
                TextBox30.Text = "" + lBoleta.HtFechaUltimaModificacion;
                TextBox31.Text = "" + lBoleta.HtIntentosEntrevista;
                TextBox32.Text = "" + lBoleta.HtTipoDeCambio;
                DropDownListMoneda.SelectedValue = "" + lBoleta.HtIdTipoMoneda;
                TextBox34.Text = "" + lBoleta.HtTotalDirectivosMujer;
                TextBox35.Text = "" + lBoleta.HtTotalDirectivosHombre;
                TextBox36.Text = "" + lBoleta.HtTotalDirectivos;
                TextBox37.Text = "" + lBoleta.HtTotalProfesionalesMujer;
                TextBox38.Text = "" + lBoleta.HtTotalProfesionalesHombre;
                TextBox39.Text = "" + lBoleta.HtTotalProfesionales;
                TextBox40.Text = "" + lBoleta.HtTotalTecnicosMujer;
                TextBox41.Text = "" + lBoleta.HtTotalTecnicosHombre;
                TextBox42.Text = "" + lBoleta.HtTotalTecnicos;
                TextBox43.Text = "" + lBoleta.HtTotalApoyoAdminMujer;
                TextBox44.Text = "" + lBoleta.HtTotalApoyoAdminHombre;
                TextBox45.Text = "" + lBoleta.HtTotalApoyoAdmin;
                TextBox46.Text = "" + lBoleta.HtTotalServiciosMujer;
                TextBox47.Text = "" + lBoleta.HtTotalServiciosHombre;
                TextBox48.Text = "" + lBoleta.HtTotalServicios;
                TextBox49.Text = "" + lBoleta.HtTotalAgricultoresMujer;
                TextBox50.Text = "" + lBoleta.HtTotalAgricultoresHombre;
                TextBox51.Text = "" + lBoleta.HtTotalAgricultores;
                TextBox52.Text = "" + lBoleta.HtTotalOperariosMujer;
                TextBox53.Text = "" + lBoleta.HtTotalOperariosHombre;
                TextBox54.Text = "" + lBoleta.HtTotalOperarios;
                TextBox55.Text = "" + lBoleta.HtTotalOperadoresMujer;
                TextBox56.Text = "" + lBoleta.HtTotalOperadoresHombre;
                TextBox57.Text = "" + lBoleta.HtTotalOperadores;
                TextBox58.Text = "" + lBoleta.HtTotalOcupElementalesMujer;
                TextBox59.Text = "" + lBoleta.HtTotalOcupElementalesHombre;
                TextBox60.Text = "" + lBoleta.HtTotalOcupElementales;
                TextBox61.Text = "" + lBoleta.HtSalarioBaseTotal;
                TextBox62.Text = "" + lBoleta.HtSalEspecieTotal;
                TextBox63.Text = "" + lBoleta.HtPagoHrsExtraTotal;
                TextBox64.Text = "" + lBoleta.HtAguinaldoTotal;
                TextBox65.Text = "" + lBoleta.HtSalEscolarTotal;
                TextBox66.Text = "" + lBoleta.HtRemuneracionesTotal;
                TextBox67.Text = "" + lBoleta.HtTotalCostoDirectivos;
                TextBox68.Text = "" + lBoleta.HtTotalCostoProfecionales;
                TextBox69.Text = "" + lBoleta.HtTotalCostoTecnicos;
                TextBox70.Text = "" + lBoleta.HtTotalCostoApoyoAdmin;
                TextBox71.Text = "" + lBoleta.HtTotalCostoServicios;
                TextBox72.Text = "" + lBoleta.HtTotalCostoAgricultores;
                TextBox73.Text = "" + lBoleta.HtTotalCostoOperarios;
                TextBox74.Text = "" + lBoleta.HtTotalCostoOperadores;
                TextBox75.Text = "" + lBoleta.HtTotalCostoOcupElementales;
                TextBox76.Text = "" + lBoleta.HtTotalCosto;
                TextBox77.Text = "" + lBoleta.HtDeducccionTotal;
                TextBox78.Text = "" + lBoleta.HtTotalHorasDerectivos;
                TextBox79.Text = "" + lBoleta.HtTotalHorasProfecionales;
                TextBox80.Text = "" + lBoleta.HtTotalHorasTecnicos;
                TextBox81.Text = "" + lBoleta.HtTotalHorasApoyoAdmin;
                TextBox82.Text = "" + lBoleta.HtTotalHorasServicios;
                TextBox83.Text = "" + lBoleta.HtTotalHorasAgricultores;
                TextBox84.Text = "" + lBoleta.HtTotalHorasOperarios;
                TextBox85.Text = "" + lBoleta.HtTotalHorasOperadores;
                TextBox86.Text = "" + lBoleta.HtTotalHorasOcupElementales;
                TextBox87.Text = "" + lBoleta.HtTotalHorasOrdinarias;
                TextBox88.Text = "" + lBoleta.HtTotalHorasExtra;
                TextBox89.Text = "" + lBoleta.HtTotalHoras;
                TextBox90.Text = "" + lBoleta.HtTotalOutsourcing;
                TextBox91.Text = "" + lBoleta.HtTotalOutsourcingMujer;
                TextBox92.Text = "" + lBoleta.HtTotalOutsourcingHombre;
                TextBox93.Text = "" + lBoleta.HtIdEntrevistador;
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }

        }
        private void lpLimpiarBoleta()
        {

            try
            {
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                DropDownListMes.Enabled = true;
                DropDownListAngo.Enabled = true;
                this.ButtonAgregar.Visible = true;
                this.ButtonModificar.Visible = false;
                this.ButtonEliminar.Visible = false;

                DropDownListDistrito.SelectedIndex = 0;
                TextBox2.Text = "" + dg.fnObteneConsecutivoLN();
                TextBox3.Text = "";
                DropDownListMes.SelectedIndex = 0;
                DropDownListAngo.SelectedIndex = 0;
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                DropDownListRazon.SelectedIndex = 0;
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox13.Text = "";
                TextBox14.Text = "";
                TextBox15.Text = "";
                TextBox16.Text = "";
                TextBox17.Text = "";
                DropDownListCIIU.SelectedIndex = 0;
                TextBox19.Text = "";
                TextBox20.Text = "";
                TextBox21.Text = "";
                TextBox22.Text = "";
                DropDownListEntrevista.SelectedIndex = 0;
                TextBox24.Text = "";
                DropDownListEmpleado.SelectedIndex = 0;
                TextBox26.Text = "";
                TextBox27.Text = "";
                TextBox28.Text = "";
                TextBox29.Text = "";
                TextBox30.Text = "";
                TextBox31.Text = "";
                this.TextBox32.Text = cambio.fnTipoCambioDolar();
                DropDownListMoneda.SelectedIndex = 0;
                TextBox34.Text = "";
                TextBox35.Text = "";
                TextBox36.Text = "";
                TextBox37.Text = "";
                TextBox38.Text = "";
                TextBox39.Text = "";
                TextBox40.Text = "";
                TextBox41.Text = "";
                TextBox42.Text = "";
                TextBox43.Text = "";
                TextBox44.Text = "";
                TextBox45.Text = "";
                TextBox46.Text = "";
                TextBox47.Text = "";
                TextBox48.Text = "";
                TextBox49.Text = "";
                TextBox50.Text = "";
                TextBox51.Text = "";
                TextBox52.Text = "";
                TextBox53.Text = "";
                TextBox54.Text = "";
                TextBox55.Text = "";
                TextBox56.Text = "";
                TextBox57.Text = "";
                TextBox58.Text = "";
                TextBox59.Text = "";
                TextBox60.Text = "";
                TextBox61.Text = "";
                TextBox62.Text = "";
                TextBox63.Text = "";
                TextBox64.Text = "";
                TextBox65.Text = "";
                TextBox66.Text = "";
                TextBox67.Text = "";
                TextBox68.Text = "";
                TextBox69.Text = "";
                TextBox70.Text = "";
                TextBox71.Text = "";
                TextBox72.Text = "";
                TextBox73.Text = "";
                TextBox74.Text = "";
                TextBox75.Text = "";
                TextBox76.Text = "";
                TextBox77.Text = "";
                TextBox78.Text = "";
                TextBox79.Text = "";
                TextBox80.Text = "";
                TextBox81.Text = "";
                TextBox82.Text = "";
                TextBox83.Text = "";
                TextBox84.Text = "";
                TextBox85.Text = "";
                TextBox86.Text = "";
                TextBox87.Text = "";
                TextBox88.Text = "";
                TextBox89.Text = "";
                TextBox90.Text = "";
                TextBox91.Text = "";
                TextBox92.Text = "";
                TextBox93.Text = "";
                var dia = DateTime.Now;

                TextBox26.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                TextBox27.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                TextBox29.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
                this.TextBox30.Text = dia.ToString("dd/MM/yyyy hh:mm:ss");
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }
        }

        private void EliminarBoleta()
        {
            try
            {

                HtBoleta lBoleta = new HtBoleta();
                lBoleta = lpllenarBoleta(lBoleta);
                gHtBoletaLN.RUDBoletasLN(lBoleta, 3);
                this.Master.lpMensaje(this, "Boleta Eliminada");
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }



        }
        private void ActualizarBoleta()
        {
            try
            {

                HtBoleta lBoleta = new HtBoleta();
                lBoleta = lpllenarBoleta(lBoleta);
                gHtBoletaLN.RUDBoletasLN(lBoleta, 2);
                this.Master.lpMensaje(this, "Boleta Modificada");
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }



        }
        private void AgregarBoleta()
        {
            try
            {

                HtBoleta lBoleta = new HtBoleta();
                lBoleta = lpllenarBoleta(lBoleta);
                gHtBoletaLN.RUDBoletasLN(lBoleta, 1);
                this.Master.lpMensaje(this, "Boleta Agregada");
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }



        }

        private HtBoleta lpllenarBoleta(HtBoleta lBoleta) {
            lBoleta.HtIdDistrito = int.Parse(this.DropDownListDistrito.SelectedValue);
                lBoleta.HtConsecutivo = int.Parse(this.TextBox2.Text);
                lBoleta.HtNumActividad = int.Parse(this.TextBox3.Text);
                lBoleta.HtIdMes = int.Parse(this.DropDownListMes.SelectedValue);
                lBoleta.HtAngo = int.Parse(this.DropDownListAngo.SelectedValue);
                lBoleta.HtNumIdentificacionNegocio = this.TextBox6.Text;
                lBoleta.HtNomNegocio = this.TextBox7.Text;
                lBoleta.HtNomLegal = this.TextBox8.Text;
                lBoleta.HtNumRazonSocial = int.Parse(this.DropDownListRazon.SelectedValue);
                lBoleta.HtDirNegocio = this.TextBox10.Text;
                lBoleta.HtTel1Negocio = int.Parse(this.TextBox11.Text);
                lBoleta.HtExt1Negocio = int.Parse(this.TextBox12.Text);
                lBoleta.HtEmail = this.TextBox13.Text;
                lBoleta.HtCantidadTrabajadoresHombres = short.Parse(this.TextBox15.Text);
                lBoleta.HtCantidadTrabajadoresNujeres = short.Parse(this.TextBox16.Text);
                lBoleta.HtCantidadTrabajadores = (short)(lBoleta.HtCantidadTrabajadoresHombres + lBoleta.HtCantidadTrabajadoresNujeres);
                lBoleta.HtDescCIIUProductoPrincipal = this.TextBox17.Text;
                lBoleta.HtNumCiiu4 = this.DropDownListCIIU.SelectedValue;
                lBoleta.HtNombreInformante = this.TextBox19.Text;
                lBoleta.HtCargoDelInformante = this.TextBox20.Text;
                lBoleta.HtTelefonoInformante = int.Parse(this.TextBox21.Text);
                lBoleta.HtEmailInformante = this.TextBox22.Text;
                lBoleta.HtIdResultadoEntrevista = int.Parse(this.DropDownListEntrevista.SelectedValue);
                lBoleta.HtObservaciones = this.TextBox24.Text;
                lBoleta.HtIdEmpleado = int.Parse(this.DropDownListEmpleado.SelectedValue);
                lBoleta.HtHoraInicio = DateTime.Parse(this.TextBox26.Text);
                lBoleta.HtHoraFinal = DateTime.Parse(this.TextBox27.Text);
                lBoleta.HtDuracionEntrevista = this.TextBox28.Text;
                lBoleta.HtFechaEntrevista = DateTime.Parse(this.TextBox29.Text);
                lBoleta.HtFechaUltimaModificacion = DateTime.Parse(this.TextBox30.Text);
                lBoleta.HtIntentosEntrevista = short.Parse(this.TextBox31.Text);

                String[] dolar = cambio.fnTipoCambioDolar().Split(','); 
                lBoleta.HtTipoDeCambio = short.Parse(dolar[0]);
                lBoleta.HtIdTipoMoneda = int.Parse(this.DropDownListMoneda.SelectedValue);
                lBoleta.HtTotalDirectivosMujer = int.Parse(this.TextBox34.Text);
                lBoleta.HtTotalDirectivosHombre = int.Parse(this.TextBox35.Text);
                lBoleta.HtTotalDirectivos =  lBoleta.HtTotalDirectivosMujer + lBoleta.HtTotalDirectivosHombre; 
                lBoleta.HtTotalProfesionalesMujer = int.Parse(this.TextBox37.Text);
                lBoleta.HtTotalProfesionalesHombre = int.Parse(this.TextBox38.Text);
                lBoleta.HtTotalProfesionales =  lBoleta.HtTotalProfesionalesMujer +  lBoleta.HtTotalProfesionalesHombre;
                lBoleta.HtTotalTecnicosMujer = int.Parse(this.TextBox40.Text);
                lBoleta.HtTotalTecnicosHombre = int.Parse(this.TextBox41.Text);
                lBoleta.HtTotalTecnicos =  lBoleta.HtTotalTecnicosMujer  +  lBoleta.HtTotalTecnicosHombre;
                lBoleta.HtTotalApoyoAdminMujer = int.Parse(this.TextBox43.Text);
                lBoleta.HtTotalApoyoAdminHombre = int.Parse(this.TextBox44.Text);
                lBoleta.HtTotalApoyoAdmin =  lBoleta.HtTotalApoyoAdminMujer+  lBoleta.HtTotalApoyoAdminHombre;
                lBoleta.HtTotalServiciosMujer = int.Parse(this.TextBox46.Text);
                lBoleta.HtTotalServiciosHombre = int.Parse(this.TextBox47.Text);
                lBoleta.HtTotalServicios =  lBoleta.HtTotalServiciosMujer+  lBoleta.HtTotalServiciosHombre;
                lBoleta.HtTotalAgricultoresMujer = int.Parse(this.TextBox49.Text);
                lBoleta.HtTotalAgricultoresHombre = int.Parse(this.TextBox50.Text);
                lBoleta.HtTotalAgricultores = lBoleta.HtTotalAgricultoresMujer+ lBoleta.HtTotalAgricultoresHombre;
                lBoleta.HtTotalOperariosMujer = int.Parse(this.TextBox52.Text);
                lBoleta.HtTotalOperariosHombre = int.Parse(this.TextBox53.Text);
                lBoleta.HtTotalOperarios =  lBoleta.HtTotalOperariosMujer+  lBoleta.HtTotalOperariosHombre;
                lBoleta.HtTotalOperadoresMujer = int.Parse(this.TextBox55.Text);
                lBoleta.HtTotalOperadoresHombre = int.Parse(this.TextBox56.Text);
                lBoleta.HtTotalOperadores = lBoleta.HtTotalOperadoresMujer+ lBoleta.HtTotalOperadoresHombre;
                lBoleta.HtTotalOcupElementalesMujer = int.Parse(this.TextBox58.Text);
                lBoleta.HtTotalOcupElementalesHombre = int.Parse(this.TextBox59.Text);
                lBoleta.HtTotalOcupElementales =  lBoleta.HtTotalOcupElementalesMujer+  lBoleta.HtTotalOcupElementalesHombre;
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
                lBoleta.HtTotalCosto = (  lBoleta.HtTotalCostoDirectivos +
                lBoleta.HtTotalCostoProfecionales +
                lBoleta.HtTotalCostoTecnicos +
                lBoleta.HtTotalCostoApoyoAdmin +
                lBoleta.HtTotalCostoServicios +
                lBoleta.HtTotalCostoAgricultores +
                lBoleta.HtTotalCostoOperarios +
                lBoleta.HtTotalCostoOperadores +
                lBoleta.HtTotalCostoOcupElementales );
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
                lBoleta.HtTotalHoras = (lBoleta.HtTotalHorasDerectivos +
                lBoleta.HtTotalHorasProfecionales +
                lBoleta.HtTotalHorasTecnicos +
                lBoleta.HtTotalHorasApoyoAdmin +
                lBoleta.HtTotalHorasServicios +
                lBoleta.HtTotalHorasAgricultores +
                lBoleta.HtTotalHorasOperarios +
                lBoleta.HtTotalHorasOperadores +
                lBoleta.HtTotalHorasOcupElementales +
                lBoleta.HtTotalHorasOrdinarias +
                lBoleta.HtTotalHorasExtra );
                lBoleta.HtTotalOutsourcingMujer = int.Parse(this.TextBox91.Text);
                lBoleta.HtTotalOutsourcingHombre = int.Parse(this.TextBox92.Text);
            lBoleta.HtTotalOutsourcing =  lBoleta.HtTotalOutsourcingMujer +
                lBoleta.HtTotalOutsourcingHombre ;
                lBoleta.HtIdEntrevistador = int.Parse(this.TextBox93.Text);
            return lBoleta;
        }
        #endregion

        #region "Combos"

        private void lpllenarCombos()
        {
            try
            {
                lpLlenarComboCIIU();
                lpLlenarComboDistrito();
                lpLlenarComboEntrevista();
                lpLlenarComboMoneda();
                lpLlenarComboRazon();
                lpLlenarComboMes();
                lpLlenarComboEmpleado();
                lpLlenarComboAngo();

                this.TextBox2.Text = "" + dg.fnObteneConsecutivoLN();
                this.TextBox3.Text = "" + dg.fnObteneConsecutivoLN();
            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }

        }
        private void lpLlenarComboDistrito()
        {

            try
            {
                var ds = dg.fnObteneDistritosLN();
                DropDownListDistrito.DataValueField = "DisIDDistrito";
                DropDownListDistrito.DataTextField = "DisNomDistrito";
                DropDownListDistrito.DataSource = ds.Tables[0];
                DropDownListDistrito.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void lpLlenarComboRazon()
        {

            try
            {
                var ds = dg.fnObtenerRazonSocialLN();
                DropDownListRazon.DataValueField = "HtNumRazonSocial";
                DropDownListRazon.DataTextField = "HtDescRazonSocial";
                DropDownListRazon.DataSource = ds.Tables[0];
                DropDownListRazon.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void lpLlenarComboCIIU()
        {

            try
            {
                var ds = dg.fnObtenerCIIU4LN();
                DropDownListCIIU.DataValueField = "HtNumCiiu4";
                DropDownListCIIU.DataTextField = "HtDescCiiu4";
                DropDownListCIIU.DataSource = ds.Tables[0];
                DropDownListCIIU.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void lpLlenarComboEntrevista()
        {

            try
            {
                var ds = dg.fnObtenerResultadoEntrevistaLN();
                DropDownListEntrevista.DataValueField = "HtIdResultadoEntrevista";
                DropDownListEntrevista.DataTextField = "HtDescriResultado";
                DropDownListEntrevista.DataSource = ds.Tables[0];
                DropDownListEntrevista.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }
        private void lpLlenarComboMoneda()
        {

            try
            {
                var ds = dg.fnObtenerMonedaLN();
                DropDownListMoneda.DataValueField = "HtIdTipoMoneda";
                DropDownListMoneda.DataTextField = "HtDescripMoneda";
                DropDownListMoneda.DataSource = ds.Tables[0];
                DropDownListMoneda.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }
        private void lpLlenarComboMes()
        {

            try
            {
                var ds = dg.fnObtenerMesLN();
                DropDownListMes.DataValueField = "HtIdMes";
                DropDownListMes.DataTextField = "HtDescMes";
                DropDownListMes.DataSource = ds.Tables[0];
                DropDownListMes.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void lpLlenarComboAngo()
        {

            try
            {
                var ds = dg.fnObteneAngoLN();
                DropDownListAngo.DataValueField = "HtAngo";
                DropDownListAngo.DataTextField = "HtFecha";
                DropDownListAngo.DataSource = ds.Tables[0];
                DropDownListAngo.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void lpLlenarComboEmpleado()
        {

            try
            {
                var ds = dg.fnObteneEmpleadoLN();
                DropDownListEmpleado.DataValueField = "HtIdEmpleado";
                DropDownListEmpleado.DataTextField = "HtNombreEmpleado";
                DropDownListEmpleado.DataSource = ds.Tables[0];
                DropDownListEmpleado.DataBind();
            }
            catch (Exception ex)
            {

                this.Master.lpMensaje(this, ex.Message);
            }

        }

        #endregion




    }
}