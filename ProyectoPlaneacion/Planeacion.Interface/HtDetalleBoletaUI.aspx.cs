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
    public partial class HtDetalleBoletaUI : System.Web.UI.Page
    {
        private HtBoletaLN gHtBoletaLN = new HtBoletaLN();
        private HtDetalleLN det = new HtDetalleLN();
        private HtGrupoLN gru = new HtGrupoLN();
        private HtGeneroLN genero = new HtGeneroLN();
        private HtContratoLN contra = new HtContratoLN();
        private HtRubroLN rubro = new HtRubroLN();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lpCargarGridEncabezado();
                llenarCombosDetalles();
                Limpiar();
                this.Master.TituloLocal = "Mantenimiento de Detalles de Boleta";
                this.Master.TituloBarra = "Mantenimiento de Detalles de Boleta";
            }
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GridViewBoletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int[] datosBoleta = new int[4];

                datosBoleta[0] = int.Parse(GridViewBoletas.SelectedRow.Cells[1].Text); // numActividad
                datosBoleta[1] = int.Parse(GridViewBoletas.SelectedRow.Cells[2].Text); // consecutivo
                datosBoleta[2] = int.Parse(GridViewBoletas.SelectedRow.Cells[3].Text); // mes
                datosBoleta[3] = int.Parse(GridViewBoletas.SelectedRow.Cells[4].Text); // ango

                LabelActividad.Text = "" + datosBoleta[0];
                LabelMes.Text = "" + datosBoleta[2];
                LabelAngo.Text = "" + datosBoleta[3];
                LabelConsecutivo.Text = "" + datosBoleta[1];
                // llenar detalles por la boleta
                llenarGridDetalle(datosBoleta);
            }
            catch (Exception) { }
        }
        private void llenarGridDetalle(int[] datosBoleta)
        {


            ConvertLN con = new ConvertLN();

            GridViewDetalles.DataSource = con.ToDataTable(det.ObtenerDetalles(datosBoleta[1], datosBoleta[0], datosBoleta[2], datosBoleta[3]));
            GridViewDetalles.DataBind();

        }
        #region "Validaciones"
        private Boolean ValidarDetalle()
        {
            if (TextBoxCedula.Text == "") { this.Master.lpMensaje(this, "El campo cedula es requerido"); return false; };   
            if (TextBoxNombre.Text == "") { this.Master.lpMensaje(this, "El campo nombre es requerido"); return false; };
            if (TextBoxApellido.Text == "") { this.Master.lpMensaje(this, "El campo apellido es requerido"); return false; };
            if (TextBoxCantidad.Text == "") { this.Master.lpMensaje(this, "El campo cantidad es requerido"); return false; };
            if (TextBoxObsevaciones.Text == "") { this.Master.lpMensaje(this, "El campo observacion es requerido"); return false; };
            return true;
        }
        private Boolean validarSeleccionBoleta()
        {
            if (LabelActividad.Text == "") { this.Master.lpMensaje(this, "Seleccione primero una boleta"); return false; }
            if (LabelMes.Text == "") { this.Master.lpMensaje(this, "Seleccione primero una boleta"); return false; }
            if (LabelAngo.Text == "") { this.Master.lpMensaje(this, "Seleccione primero una boleta"); return false; }
            if (LabelConsecutivo.Text == "") { this.Master.lpMensaje(this, "Seleccione primero una boleta"); return false; }
            return true;
        }
        #endregion

        #region "Metodos locales"

        private HtDetalleTotales llenarValoresDetalle()
        {
            HtDetalleTotales det = new HtDetalleTotales();

            det.HtApellido = TextBoxApellido.Text;
            det.HtCantidad = int.Parse(TextBoxCantidad.Text);
            det.HtNombre = TextBoxNombre.Text;
            det.HtCedula = TextBoxCedula.Text;
            det.HtObservaciones = TextBoxObsevaciones.Text;
            det.HtNumActividad = int.Parse(LabelActividad.Text);
            det.HtIdMes = int.Parse(LabelMes.Text);
            det.HtAngo = int.Parse(LabelAngo.Text);
            det.HtConsecutivo = int.Parse(LabelConsecutivo.Text);
            det.HtIdCamino = int.Parse(LabelCamino.Text);
            det.HtNumLinea = int.Parse(LabelLinea.Text);

            det.HtIdTipoContrato = int.Parse(DropDownListContrato.SelectedValue);

            det.HtIdGenero = int.Parse(DropDownListGenero.SelectedValue);

            det.HtIdRubro = int.Parse(DropDownListRubro.SelectedValue);

            det.HtIdGrupoOcupacional = int.Parse(DropDownListGrupo0.SelectedValue);

            return det;
        }

        private void lpCargarGridEncabezado()
        {

            try
            {


                GridViewBoletas.DataSource = gHtBoletaLN.BoletasPersonalizadaLN();
                GridViewBoletas.DataBind();

            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);

            }

        }
        public void llenarCombosDetalles()
        {
            try
            {
                ConvertLN con = new ConvertLN();
                DropDownListContrato.DataTextField = "HtDescripTipoContrato";
                DropDownListContrato.DataValueField = "HtIdContrato";
                DropDownListContrato.DataSource = con.ToDataTable(contra.Obtener2DatosLN());
                DropDownListContrato.DataBind();

                DropDownListGenero.DataTextField = "HtDescripGenero";
                DropDownListGenero.DataValueField = "HtIdGenero";
                DropDownListGenero.DataSource = con.ToDataTable(genero.ObtenerDatos2LN());
                DropDownListGenero.DataBind();

                DropDownListRubro.DataTextField = "HtDescripRubro";
                DropDownListRubro.DataValueField = "HtIdRubro";
                DropDownListRubro.DataSource = con.ToDataTable(rubro.Obtener2DatosLN());
                DropDownListRubro.DataBind();

                DropDownListGrupo0.DataTextField = "HtDescripGrupoOcupacional";
                DropDownListGrupo0.DataValueField = "HtIdGrupoOcupacional";
                DropDownListGrupo0.DataSource = con.ToDataTable(gru.ObtenerDatos2LN());
                DropDownListGrupo0.DataBind();

            }
            catch (Exception ex)
            {
                this.Master.lpMensaje(this, ex.Message);
            }

        }

        private void Limpiar()
        {
            activarBotones(0);
            TextBoxApellido.Text = "";
            TextBoxCantidad.Text = "" + 0;
            TextBoxNombre.Text = "";
            TextBoxCedula.Text = "";
            TextBoxObsevaciones.Text = "";
            LabelActividad.Text = "";
            LabelMes.Text = "";
            LabelAngo.Text = "";
            LabelConsecutivo.Text = "";
            llenarConsecutivo();

            DropDownListContrato.SelectedIndex = 0;

            DropDownListGenero.SelectedIndex = 0;

            DropDownListRubro.SelectedIndex = 0;

            DropDownListGrupo0.SelectedIndex = 0;

            GridViewDetalles.DataSource = null;
            GridViewDetalles.DataBind();


        }


        private void llenarConsecutivo()
        {

            Int32 consecutivo = fnConsecutivo();
            LabelCamino.Text = "" + consecutivo;
            LabelLinea.Text = "" + consecutivo;

        }

        private Int32 fnConsecutivo()
        {
            Int32 contador = 1;
            try
            {

                contador = det.ObtenerDatosLN().Count + 1;
                return contador;
            }
            catch (Exception)
            {
                return contador;
            }
        }

        private void activarBotones(int value)
        {
            if (value == 0)
            {
                ButtonGuardar.Visible = true;
                ButtonEliminar.Visible = false;
                ButtonModificar.Visible = false;

            }
            else
            {
                ButtonGuardar.Visible = false;
                ButtonEliminar.Visible = true;
                ButtonModificar.Visible = true;
            }

        }
        private void LimpiezaBasica()
        {
            activarBotones(0);
            TextBoxApellido.Text = "";
            TextBoxCantidad.Text = "" + 0;
            TextBoxNombre.Text = "";
            TextBoxCedula.Text = "";
            TextBoxObsevaciones.Text = "";
            llenarConsecutivo();
            DropDownListContrato.SelectedIndex = 0;

            DropDownListGenero.SelectedIndex = 0;

            DropDownListRubro.SelectedIndex = 0;

            DropDownListGrupo0.SelectedIndex = 0;
        }
        #endregion

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionBoleta() && ValidarDetalle())
            {

                var de = this.llenarValoresDetalle();
                det.agregarLN(de);
                LimpiezaBasica();
                int[] datosBoleta = new int[4];
                datosBoleta[0] = int.Parse(LabelActividad.Text);
                datosBoleta[2] = int.Parse(LabelMes.Text);
                datosBoleta[3] = int.Parse(LabelAngo.Text);
                datosBoleta[1] = int.Parse(LabelConsecutivo.Text);
                llenarGridDetalle(datosBoleta);
                this.Master.lpMensaje(this, "Se Inserto correctamente");
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionBoleta() && ValidarDetalle())
            {
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue == "Si")
                {
                    var de = this.llenarValoresDetalle();
                    det.eliminarLN(de);
                    LimpiezaBasica();
                    int[] datosBoleta = new int[4];
                    datosBoleta[0] = int.Parse(LabelActividad.Text);
                    datosBoleta[2] = int.Parse(LabelMes.Text);
                    datosBoleta[3] = int.Parse(LabelAngo.Text);
                    datosBoleta[1] = int.Parse(LabelConsecutivo.Text);
                    llenarGridDetalle(datosBoleta);
                    this.Master.lpMensaje(this, "Se elimino correctamente");
                }


            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionBoleta() && ValidarDetalle())
            {
                var de = this.llenarValoresDetalle();
                det.modificarLN(de);
                LimpiezaBasica();
                int[] datosBoleta = new int[4];
                datosBoleta[0] = int.Parse(LabelActividad.Text);
                datosBoleta[2] = int.Parse(LabelMes.Text);
                datosBoleta[3] = int.Parse(LabelAngo.Text);
                datosBoleta[1] = int.Parse(LabelConsecutivo.Text);
                llenarGridDetalle(datosBoleta);
                this.Master.lpMensaje(this, "Se modifico correctamente");

            }




        }

        protected void GridViewDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {

            activarBotones(1);
            TextBoxApellido.Text = GridViewDetalles.SelectedRow.Cells[9].Text;
            TextBoxCantidad.Text = GridViewDetalles.SelectedRow.Cells[10].Text;
            TextBoxNombre.Text = GridViewDetalles.SelectedRow.Cells[8].Text ;
            TextBoxCedula.Text = GridViewDetalles.SelectedRow.Cells[7].Text  ;
            TextBoxObsevaciones.Text = GridViewDetalles.SelectedRow.Cells[11].Text;

            LabelCamino.Text = GridViewDetalles.SelectedRow.Cells[1].Text ;
            LabelLinea.Text = GridViewDetalles.SelectedRow.Cells[2].Text ;

            DropDownListContrato.SelectedValue = GridViewDetalles.SelectedRow.Cells[6].Text;

            DropDownListGenero.SelectedValue = GridViewDetalles.SelectedRow.Cells[5].Text;

            DropDownListRubro.SelectedValue = GridViewDetalles.SelectedRow.Cells[4].Text;

            DropDownListGrupo0.SelectedValue = GridViewDetalles.SelectedRow.Cells[3].Text;
           
        }
    }
}