<%@ Page Title="" Language="C#" MasterPageFile="~/UI.Master" AutoEventWireup="true" CodeBehind="HtBoletaUI.aspx.cs" Inherits="Planeacion.Interface.HtBoletaUI" %>
<%@ MasterType VirtualPath="~/UI.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <div style=" overflow: auto;">
            <div class="datagrid">
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
                </div>
            <div style="padding-left: 70%;">
                <br />
                <br />
                <asp:Button ID="bt_Nuevo" runat="server" Text="Nueva Boleta" CssClass="boton" OnClick="bt_Nuevo_Click" />
                                <asp:Button ID="Button1" runat="server" Text="Nueva Boleta" Style ="display:none;"/>
            </div>
            <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup"  >
                <asp:Label ID="Label94" runat="server" Text="Boleta" style="font-size: xx-large; font-weight: 700; color: #3366FF"></asp:Label>
                <div class="scroll">
                    <div class="datagrid">
                        <table>

                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="HtIdDistrito"></asp:Label><br />

                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="HtConsecutivo"></asp:Label><br />

                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="HtNumActividad"></asp:Label><br />

                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="HtIdMes"></asp:Label><br />
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="HtAngo"></asp:Label><br />
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="HtNumIdentificacionNegocio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="HtNomNegocio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="HtNomLegal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="HtNumRazonSocial"></asp:Label><br />
                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label10" runat="server" Text="HtDirNegocio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label11" runat="server" Text="HtTel1Negocio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="HtExt1Negocio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label13" runat="server" Text="HtEmail"></asp:Label><br />
                                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text="HtCantidadTrabajadores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text="HtCantidadTrabajadoresHombres"></asp:Label><br />
                                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label16" runat="server" Text="HtCantidadTrabajadoresNujeres"></asp:Label><br />
                                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Text="HtDescCIIUProductoPrincipal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label18" runat="server" Text="HtNumCiiu4"></asp:Label><br />
                                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label19" runat="server" Text="HtNombreInformante"></asp:Label><br />
                                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label20" runat="server" Text="HtCargoDelInformante"></asp:Label><br />
                                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label21" runat="server" Text="HtTelefonoInformante"></asp:Label><br />
                                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label22" runat="server" Text="HtEmailInformante"></asp:Label><br />
                                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label23" runat="server" Text="HtIdResultadoEntrevista"></asp:Label><br />
                                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label24" runat="server" Text="HtObservaciones"></asp:Label><br />
                                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label25" runat="server" Text="HtIdEmpleado"></asp:Label><br />
                                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label26" runat="server" Text="HtHoraInicio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label27" runat="server" Text="HtHoraFinal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label28" runat="server" Text="HtDuracionEntrevista"></asp:Label><br />
                                    <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label29" runat="server" Text="HtFechaEntrevista"></asp:Label><br />
                                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label30" runat="server" Text="HtFechaUltimaModificacion"></asp:Label><br />
                                    <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label31" runat="server" Text="HtIntentosEntrevista"></asp:Label><br />
                                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label32" runat="server" Text="HtTipoDeCambio"></asp:Label><br />
                                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label33" runat="server" Text="HtIdTipoMoneda"></asp:Label><br />
                                    <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label34" runat="server" Text="HtTotalDirectivosMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label35" runat="server" Text="HtTotalDirectivosHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label36" runat="server" Text="HtTotalDirectivos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label37" runat="server" Text="HtTotalProfesionalesMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label38" runat="server" Text="HtTotalProfesionalesHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label39" runat="server" Text="HtTotalProfesionales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label40" runat="server" Text="HtTotalTecnicosMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label41" runat="server" Text="HtTotalTecnicosHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label42" runat="server" Text="HtTotalTecnicos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label43" runat="server" Text="HtTotalApoyoAdminMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label44" runat="server" Text="HtTotalApoyoAdminHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label45" runat="server" Text="HtTotalApoyoAdmin"></asp:Label><br />
                                    <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label46" runat="server" Text="HtTotalServiciosMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label47" runat="server" Text="HtTotalServiciosHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox47" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label48" runat="server" Text="HtTotalServicios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox48" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label49" runat="server" Text="HtTotalAgricultoresMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox49" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label50" runat="server" Text="HtTotalAgricultoresHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox50" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label51" runat="server" Text="HtTotalAgricultores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox51" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label52" runat="server" Text="HtTotalOperariosMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox52" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label53" runat="server" Text="HtTotalOperariosHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox53" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label54" runat="server" Text="HtTotalOperarios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox54" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label55" runat="server" Text="HtTotalOperadoresMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox55" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label56" runat="server" Text="HtTotalOperadoresHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox56" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label57" runat="server" Text="HtTotalOperadores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox57" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label58" runat="server" Text="HtTotalOcupElementalesMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox58" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label59" runat="server" Text="HtTotalOcupElementalesHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox59" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label60" runat="server" Text="HtTotalOcupElementales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox60" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label61" runat="server" Text="HtSalarioBaseTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox61" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label62" runat="server" Text="HtSalEspecieTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox62" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label63" runat="server" Text="HtPagoHrsExtraTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox63" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label64" runat="server" Text="HtAguinaldoTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label65" runat="server" Text="HtSalEscolarTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox65" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label66" runat="server" Text="HtRemuneracionesTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox66" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label67" runat="server" Text="HtTotalCostoDirectivos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox67" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label68" runat="server" Text="HtTotalCostoProfecionales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox68" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label69" runat="server" Text="HtTotalCostoTecnicos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox69" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label70" runat="server" Text="HtTotalCostoApoyoAdmin"></asp:Label><br />
                                    <asp:TextBox ID="TextBox70" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label71" runat="server" Text="HtTotalCostoServicios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox71" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label72" runat="server" Text="HtTotalCostoAgricultores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox72" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label73" runat="server" Text="HtTotalCostoOperarios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox73" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label74" runat="server" Text="HtTotalCostoOperadores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox74" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label75" runat="server" Text="HtTotalCostoOcupElementales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox75" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label76" runat="server" Text="HtTotalCosto"></asp:Label><br />
                                    <asp:TextBox ID="TextBox76" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label77" runat="server" Text="HtDeducccionTotal"></asp:Label><br />
                                    <asp:TextBox ID="TextBox77" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label78" runat="server" Text="HtTotalHorasDerectivos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox78" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label79" runat="server" Text="HtTotalHorasProfecionales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox79" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label80" runat="server" Text="HtTotalHorasTecnicos"></asp:Label><br />
                                    <asp:TextBox ID="TextBox80" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label81" runat="server" Text="HtTotalHorasApoyoAdmin"></asp:Label><br />
                                    <asp:TextBox ID="TextBox81" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label82" runat="server" Text="HtTotalHorasServicios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox82" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label83" runat="server" Text="HtTotalHorasAgricultores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox83" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label84" runat="server" Text="HtTotalHorasOperarios"></asp:Label><br />
                                    <asp:TextBox ID="TextBox84" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label85" runat="server" Text="HtTotalHorasOperadores"></asp:Label><br />
                                    <asp:TextBox ID="TextBox85" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label86" runat="server" Text="HtTotalHorasOcupElementales"></asp:Label><br />
                                    <asp:TextBox ID="TextBox86" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label87" runat="server" Text="HtTotalHorasOrdinarias"></asp:Label><br />
                                    <asp:TextBox ID="TextBox87" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label88" runat="server" Text="HtTotalHorasExtra"></asp:Label><br />
                                    <asp:TextBox ID="TextBox88" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label89" runat="server" Text="HtTotalHoras"></asp:Label><br />
                                    <asp:TextBox ID="TextBox89" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label90" runat="server" Text="HtTotalOutsourcing"></asp:Label><br />
                                    <asp:TextBox ID="TextBox90" runat="server"></asp:TextBox><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label91" runat="server" Text="HtTotalOutsourcingMujer"></asp:Label><br />
                                    <asp:TextBox ID="TextBox91" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label92" runat="server" Text="HtTotalOutsourcingHombre"></asp:Label><br />
                                    <asp:TextBox ID="TextBox92" runat="server"></asp:TextBox><br />
                                </td>
                                <td>
                                    <asp:Label ID="Label93" runat="server" Text="HtIdEntrevistador"></asp:Label><br />
                                    <asp:TextBox ID="TextBox93" runat="server"></asp:TextBox><br />
                                </td>

                            </tr>


                        </table>
                    </div>
                </div>
                <div style="padding-left: 70%;">
                    <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" CssClass="boton" OnClick="ButtonAgregar_Click" Visible="false" />
                    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" CssClass="boton" OnClick="ButtonModificar_Click" Visible="false" />
                    <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" CssClass="boton" OnClick="ButtonEliminar_Click" Visible="false" />
                    <asp:Button ID="bt_Cancel" runat="server" Text="Cancelar" CssClass="boton" OnClick="bt_Cancel_Click" />
                </div>
            </asp:Panel>

            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
                TargetControlID="Button1" PopupControlID="Panel1" BackgroundCssClass="modalbackground">
            </ajaxToolkit:ModalPopupExtender>


        </ContentTemplate>



    </asp:UpdatePanel>

</asp:Content>
