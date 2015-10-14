<%@ Page Title="Boleta" Language="C#" MasterPageFile="~/UI.Master" AutoEventWireup="true" CodeBehind="HtBoletaUI.aspx.cs" Inherits="Planeacion.Interface.HtBoletaUI" %>

<%@ MasterType VirtualPath="~/UI.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <%--      <div style="overflow: auto;">
                <div class="datagrid">
                    <asp:GridView ID="GridView1" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>--%>
            <div style="padding-left: 70%;">
                <br />
                <br />
                <asp:Button ID="bt_Nuevo" runat="server" Text="Nueva Boleta" CssClass="boton" OnClick="bt_Nuevo_Click" />
                <asp:Button ID="Button1" runat="server" Text="Nueva Boleta" Style="display: none;" />
            </div>

            <%--  Style="display: none;" --%>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label94" runat="server" Text="Boleta" Style="font-size: xx-large; font-weight: 700; color: #3366FF"></asp:Label>
                <asp:Panel ID="Paneldiv" runat="server" ScrollBars="Auto">
                    <div class="datagrid">
                        <ajaxToolkit:Accordion ID="MyAccordion" runat="server"
                            HeaderCssClass="accordionHeader"
                            SelectedIndex="0"
                            FadeTransitions="true"
                            FramesPerSecond="40"
                            TransitionDuration="250"
                            AutoSize="None" Width="100%" Height="100%">

                            <Panes>
                                <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Datos de Negocio</a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%-- Inicia datos de negocio--%>
                                        <table>

                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label1" runat="server" Text="IdDistrito"></asp:Label><br />

                                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label2" runat="server" Text="Consecutivo"></asp:Label><br />

                                                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="20"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label3" runat="server" Text="NumActividad"></asp:Label><br />

                                                    <asp:TextBox ID="TextBox3" runat="server" MaxLength="20"></asp:TextBox><br />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label4" runat="server" Text="IdMes"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label5" runat="server" Text="Ango"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label6" runat="server" Text="NumIdentificacionNegocio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox6" runat="server" MaxLength="20"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label7" runat="server" Text="NomNegocio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox7" runat="server" MaxLength="200"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label8" runat="server" Text="NomLegal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox8" runat="server" MaxLength="200"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label9" runat="server" Text="NumRazonSocial"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label10" runat="server" Text="DirNegocio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox10" runat="server" MaxLength="400"></asp:TextBox><br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label11" runat="server" Text="Tel1Negocio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers" TargetControlID="TextBox11" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label12" runat="server" Text="Ext1Negocio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Numbers" TargetControlID="TextBox12" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label13" runat="server" Text="Email"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox13" runat="server" MaxLength="50" TextMode="Email"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label16" runat="server" Text="CantidadTrabajadoresMujeres"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox16" runat="server" CssClass="trabajadores"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Numbers" TargetControlID="TextBox16" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label15" runat="server" Text="CantidadTrabajadoresHombres"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox15" runat="server"  CssClass="trabajadores"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" FilterType="Numbers" TargetControlID="TextBox15" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label14" runat="server" Text="CantidadTrabajadores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox14" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Numbers" TargetControlID="TextBox14" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label17" runat="server" Text="DescCIIUProductoPrincipal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox17" runat="server" MaxLength="400"></asp:TextBox><br />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label18" runat="server" Text="NumCiiu4"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox><br />
                                                </td>
                                            </tr>
                                        </table>

                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Datos Informante</a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%-- Inicia datos Informante--%>

                                        <table>
                                            <tr>

                                                <td>
                                                    <asp:Label ID="Label19" runat="server" Text="NombreInformante"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox19" runat="server" MaxLength="50"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label20" runat="server" Text="CargoDelInformante"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox20" runat="server" MaxLength="50"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label21" runat="server" Text="TelefonoInformante"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" FilterType="Numbers" TargetControlID="TextBox21" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label22" runat="server" Text="EmailInformante"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox22" runat="server" TextMode="Email" MaxLength="50"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label23" runat="server" Text="IdResultadoEntrevista"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox><br />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label24" runat="server" Text="Observaciones"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox24" runat="server" MaxLength="400"></asp:TextBox><br />
                                                </td>
                                            </tr>

                                        </table>

                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Datos Empleado</a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%-- Inicia datos de Empleado--%>


                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label25" runat="server" Text="IdEmpleado"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox><br />
                                                </td>

                                                <td>

                                                    <asp:Label ID="Label26" runat="server" Text="HoraInicio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox26" Format="hh:mm:ss" />
                                                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TextBox26" Mask="99:99:99" MaskType="Time" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label27" runat="server" Text="HoraFinal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox27" Format="hh:mm:ss" />
                                                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender2" runat="server" TargetControlID="TextBox27" Mask="99:99:99" MaskType="Time" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label28" runat="server" Text="DuracionEntrevista"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox28" runat="server" MaxLength="5"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server" TargetControlID="TextBox28" FilterType="Numbers" />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label29" runat="server" Text="FechaEntrevista"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox29" Format="HH:mm:ss" />
                                                    <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender3" runat="server" TargetControlID="TextBox29" Mask="99:99:99" MaskType="Time" />

                                                </td>
                                            </tr>
                                            <tr>

                                                <asp:Label ID="Label30" runat="server" Text="FechaUltimaModificacion" Visible="false"></asp:Label><br />
                                                <asp:TextBox ID="TextBox30" runat="server" Visible="false"></asp:TextBox><br />


                                                <td>
                                                    <asp:Label ID="Label31" runat="server" Text="IntentosEntrevista"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender8" runat="server" TargetControlID="TextBox31" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                        </table>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane4" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Monedas</a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%-- Inicia datos de Monedas--%>

                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label33" runat="server" Text="IdTipoMoneda"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox><br />
                                                </td>
                                                <td>
                                                    <asp:Label ID="Label32" runat="server" Text="TipoDeCambio"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender9" runat="server" TargetControlID="TextBox32" FilterType="Custom" ValidChars="0123456789.,"/>

                                                </td>

                                            </tr>
                                        </table>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane5" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Totales empleados </a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%-- Inicia datos Totales Empleados --%>

                                        <table>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label34" runat="server" Text="TotalDirectivosMujer" ></asp:Label><br />
                                                    <asp:TextBox ID="TextBox34" runat="server" CssClass="directivos"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender10" runat="server" TargetControlID="TextBox34" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label35" runat="server" Text="TotalDirectivosHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox35" runat="server" CssClass="directivos"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender11" runat="server" TargetControlID="TextBox35" FilterType="Numbers" />
                                                     
                                                </td>

                                                <td>
                                                    <asp:Label ID="Label36" runat="server" Text="TotalDirectivos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox36" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender12" runat="server" TargetControlID="TextBox36" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label37" runat="server" Text="TotalProfesionalesMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox37" runat="server" CssClass="Profesionales"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender13" runat="server" TargetControlID="TextBox37" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label38" runat="server" Text="TotalProfesionalesHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox38" runat="server" CssClass="Profesionales"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender14" runat="server" TargetControlID="TextBox38" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label39" runat="server" Text="TotalProfesionales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox39" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender15" runat="server" TargetControlID="TextBox39" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label40" runat="server" Text="TotalTecnicosMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox40" runat="server" CssClass="tecnicos"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender16" runat="server" TargetControlID="TextBox40" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label41" runat="server" Text="TotalTecnicosHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox41" runat="server" CssClass="tecnicos"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender17" runat="server" TargetControlID="TextBox41" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label42" runat="server" Text="TotalTecnicos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox42" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender18" runat="server" TargetControlID="TextBox42" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label43" runat="server" Text="TotalApoyoAdminMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox43" runat="server" CssClass="admin"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender19" runat="server" TargetControlID="TextBox43" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label44" runat="server" Text="TotalApoyoAdminHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox44" runat="server" CssClass="admin"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender20" runat="server" TargetControlID="TextBox44" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label45" runat="server" Text="TotalApoyoAdmin"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox45" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender21" runat="server" TargetControlID="TextBox45" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label46" runat="server" Text="TotalServiciosMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox46" runat="server" CssClass="servicio"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender22" runat="server" TargetControlID="TextBox46" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label47" runat="server" Text="TotalServiciosHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox47" runat="server" CssClass="servicio"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender23" runat="server" TargetControlID="TextBox47" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label48" runat="server" Text="TotalServicios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox48" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender24" runat="server" TargetControlID="TextBox48" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label49" runat="server" Text="TotalAgricultoresMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox49" runat="server" CssClass="agri"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender25" runat="server" TargetControlID="TextBox49" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label50" runat="server" Text="TotalAgricultoresHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox50" runat="server" CssClass="agri"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender26" runat="server" TargetControlID="TextBox50" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label51" runat="server" Text="TotalAgricultores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox51" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender27" runat="server" TargetControlID="TextBox51" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label52" runat="server" Text="TotalOperariosMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox52" runat="server" CssClass="ope"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender28" runat="server" TargetControlID="TextBox52" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label53" runat="server" Text="TotalOperariosHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox53" runat="server" CssClass="ope"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender29" runat="server" TargetControlID="TextBox53" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label54" runat="server" Text="TotalOperarios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox54" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender30" runat="server" TargetControlID="TextBox54" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label55" runat="server" Text="TotalOperadoresMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox55" runat="server" CssClass="opera"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender31" runat="server" TargetControlID="TextBox55" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label56" runat="server" Text="TotalOperadoresHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox56" runat="server" CssClass="opera"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender32" runat="server" TargetControlID="TextBox56" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label57" runat="server" Text="TotalOperadores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox57" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender33" runat="server" TargetControlID="TextBox57" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label58" runat="server" Text="TotalOcupElementalesMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox58" runat="server" CssClass="ele"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender34" runat="server" TargetControlID="TextBox58" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label59" runat="server" Text="TotalOcupElementalesHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox59" runat="server" CssClass="ele"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender35" runat="server" TargetControlID="TextBox59" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label60" runat="server" Text="TotalOcupElementales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox60" runat="server" ReadOnly="true"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender36" runat="server" TargetControlID="TextBox60" FilterType="Numbers" />

                                                </td>
                                            </tr>

                                        </table>

                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane6" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Salarios </a>
                                        </div>
                                    </Header>
                                    <Content>

                                        <%--  Salarios --%>

                                        <table>
                                            <tr>

                                                <td>
                                                    <asp:Label ID="Label61" runat="server" Text="SalarioBaseTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox61" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender37" runat="server" TargetControlID="TextBox61" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label62" runat="server" Text="SalEspecieTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox62" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender38" runat="server" TargetControlID="TextBox62" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label63" runat="server" Text="PagoHrsExtraTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox63" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender39" runat="server" TargetControlID="TextBox63" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label64" runat="server" Text="AguinaldoTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox64" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender40" runat="server" TargetControlID="TextBox64" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label65" runat="server" Text="SalEscolarTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox65" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender41" runat="server" TargetControlID="TextBox65" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label66" runat="server" Text="RemuneracionesTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox66" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender42" runat="server" TargetControlID="TextBox66" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                        </table>
                                        <%-- Totales --%>
                                    </Content>
                                </ajaxToolkit:AccordionPane>
                                <ajaxToolkit:AccordionPane ID="AccordionPane7" runat="server">
                                    <Header>
                                        <div style="background-color: #2E4d7B; border: solid 1px #000000;">
                                            <a href="#" onclick="return false;" class="accordionLink">Totales </a>
                                        </div>
                                    </Header>
                                    <Content>


                                        <table>
                                            <tr>

                                                <td>
                                                    <asp:Label ID="Label67" runat="server" Text="TotalCostoDirectivos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox67" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender43" runat="server" TargetControlID="TextBox67" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label68" runat="server" Text="TotalCostoProfecionales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox68" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender44" runat="server" TargetControlID="TextBox68" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label69" runat="server" Text="TotalCostoTecnicos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox69" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender45" runat="server" TargetControlID="TextBox69" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label70" runat="server" Text="TotalCostoApoyoAdmin"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox70" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender46" runat="server" TargetControlID="TextBox70" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>

                                                <td>
                                                    <asp:Label ID="Label71" runat="server" Text="TotalCostoServicios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox71" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender47" runat="server" TargetControlID="TextBox71" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label72" runat="server" Text="TotalCostoAgricultores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox72" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender48" runat="server" TargetControlID="TextBox72" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label73" runat="server" Text="TotalCostoOperarios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox73" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender49" runat="server" TargetControlID="TextBox73" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label74" runat="server" Text="TotalCostoOperadores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox74" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender50" runat="server" TargetControlID="TextBox74" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label75" runat="server" Text="TotalCostoOcupElementales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox75" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender51" runat="server" TargetControlID="TextBox75" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label76" runat="server" Text="TotalCosto"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox76" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender52" runat="server" TargetControlID="TextBox76" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label77" runat="server" Text="DeducccionTotal"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox77" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender53" runat="server" TargetControlID="TextBox77" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label78" runat="server" Text="TotalHorasDerectivos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox78" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender54" runat="server" TargetControlID="TextBox78" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label79" runat="server" Text="TotalHorasProfecionales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox79" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender55" runat="server" TargetControlID="TextBox79" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label80" runat="server" Text="TotalHorasTecnicos"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox80" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender56" runat="server" TargetControlID="TextBox80" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label81" runat="server" Text="TotalHorasApoyoAdmin"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox81" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender57" runat="server" TargetControlID="TextBox81" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label82" runat="server" Text="TotalHorasServicios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox82" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender58" runat="server" TargetControlID="TextBox82" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label83" runat="server" Text="TotalHorasAgricultores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox83" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender59" runat="server" TargetControlID="TextBox83" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label84" runat="server" Text="TotalHorasOperarios"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox84" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender60" runat="server" TargetControlID="TextBox84" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label85" runat="server" Text="TotalHorasOperadores"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox85" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender61" runat="server" TargetControlID="TextBox85" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label86" runat="server" Text="TotalHorasOcupElementales"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox86" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender62" runat="server" TargetControlID="TextBox86" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label87" runat="server" Text="TotalHorasOrdinarias"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox87" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender63" runat="server" TargetControlID="TextBox87" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label88" runat="server" Text="TotalHorasExtra"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox88" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender64" runat="server" TargetControlID="TextBox88" FilterType="Numbers" />

                                                </td>

                                                <td>
                                                    <asp:Label ID="Label89" runat="server" Text="TotalHoras"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox89" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender65" runat="server" TargetControlID="TextBox89" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label90" runat="server" Text="TotalOutsourcing"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox90" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender66" runat="server" TargetControlID="TextBox90" FilterType="Numbers" />

                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label91" runat="server" Text="TotalOutsourcingMujer"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox91" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender67" runat="server" TargetControlID="TextBox91" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label92" runat="server" Text="TotalOutsourcingHombre"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox92" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender68" runat="server" TargetControlID="TextBox92" FilterType="Numbers" />

                                                </td>
                                                <td>
                                                    <asp:Label ID="Label93" runat="server" Text="IdEntrevistador"></asp:Label><br />
                                                    <asp:TextBox ID="TextBox93" runat="server"></asp:TextBox><br />
                                                    <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender69" runat="server" TargetControlID="TextBox93" FilterType="Numbers" />

                                                </td>

                                            </tr>


                                        </table>
                                    </Content>
                                </ajaxToolkit:AccordionPane>

                            </Panes>
                        </ajaxToolkit:Accordion>
                    </div>
                </asp:Panel>
                <div style="height: 50px;">
                    <asp:Button ID="ButtonAgregar" runat="server" Text="Agregar" CssClass="boton" Style="float: right;" OnClick="ButtonAgregar_Click" Visible="false" />
                    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" CssClass="boton" Style="float: right;" OnClick="ButtonModificar_Click" Visible="false" />
                    <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" CssClass="boton" Style="float: right;" OnClick="ButtonEliminar_Click" Visible="false" />
                    <asp:Button ID="bt_Cancel" runat="server" Text="Cancelar" CssClass="boton" Style="float: right;" OnClick="bt_Cancel_Click" />
                </div>
            </asp:Panel>

            <%--            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
                TargetControlID="Button1" PopupControlID="Panel1" BackgroundCssClass="modalbackground">
            </ajaxToolkit:ModalPopupExtender>--%>
        </ContentTemplate>



    </asp:UpdatePanel>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js "></script>
    <script>
        // we used jQuery 'keyup' to trigger the computation as the user type
        $('.trabajadores').keyup(function () {

            // initialize the sum (total price) to zero
            var sum = 0;

            // we use jQuery each() to loop through all the textbox with 'price' class
            // and compute the sum for each loop
            $('.trabajadores').each(function () {
                sum += Number($(this).val());
            });

            // set the computed value to 'totalPrice' textbox
            $('#<%= TextBox14.ClientID %>').val(sum);

        });

        $('.directivos').keyup(function () {

            var sum = 0;

       
            $('.directivos').each(function () {
                sum += Number($(this).val());
            });

          
            $('#<%= TextBox36.ClientID %>').val(sum);

        });

        $('.Profesionales').keyup(function () {

            var sum = 0;


            $('.Profesionales').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox39.ClientID %>').val(sum);

          });
     

        $('.tecnicos').keyup(function () {

            var sum = 0;


            $('.tecnicos').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox42.ClientID %>').val(sum);

        });
        $('.admin').keyup(function () {

            var sum = 0;


            $('.admin').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox45.ClientID %>').val(sum);

         });

        $('.servicio').keyup(function () {

            var sum = 0;


            $('.servicio').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox48.ClientID %>').val(sum);

          });
        $('.agri').keyup(function () {

            var sum = 0;


            $('.agri').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox51.ClientID %>').val(sum);

        });
        $('.ope').keyup(function () {

            var sum = 0;


            $('.ope').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox54.ClientID %>').val(sum);

        });

        $('.opera').keyup(function () {

            var sum = 0;


            $('.opera').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox57.ClientID %>').val(sum);

        });

        $('.ele').keyup(function () {

            var sum = 0;


            $('.ele').each(function () {
                sum += Number($(this).val());
            });


            $('#<%= TextBox60.ClientID %>').val(sum);

          });
    
    
</script>

</asp:Content>
