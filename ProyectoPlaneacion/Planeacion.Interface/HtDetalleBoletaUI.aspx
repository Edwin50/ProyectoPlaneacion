<%@ Page Title="" Language="C#" MasterPageFile="~/UI.Master" AutoEventWireup="true" CodeBehind="HtDetalleBoletaUI.aspx.cs" Inherits="Planeacion.Interface.HtDetalleBoletaUI" %>

<%@ MasterType VirtualPath="~/UI.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            Boletas: 
            <div style="overflow: auto;">
                <div class="datagrid">
                    <asp:GridView ID="GridViewBoletas" runat="server" OnSelectedIndexChanged="GridViewBoletas_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            Detalles de la boleta Seleccionada: 
            <div style="overflow: auto;">
                <div class="datagrid">
                    <asp:GridView ID="GridViewDetalles" runat="server" OnSelectedIndexChanged="GridViewDetalles_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
        <ContentTemplate>


            <asp:Panel ID="Panel1" runat="server">

                <div style=" margin-right:10%;margin-left:10%;"> 
                    <asp:Label ID="LabelConsecutivo" runat="server" Text="" Visible="false"></asp:Label>
                    <asp:Label ID="LabelActividad" runat="server" Text="" Visible="false"></asp:Label>
                    <asp:Label ID="LabelMes" runat="server" Text="" Visible="false"></asp:Label>
                    <asp:Label ID="LabelAngo" runat="server" Text="" Visible="false"></asp:Label>
                    <%-- Es un contador  --%>
                    <asp:Label ID="LabelLinea" runat="server" Text="" Visible="false"></asp:Label>
                    <asp:Label ID="LabelCamino" runat="server" Text="" Visible="false"></asp:Label>
                    <table style="width: 100%;">
                        <tr>
                            <td>Cedula:
                                <asp:TextBox ID="TextBoxCedula" runat="server"></asp:TextBox>
                                <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server"  Mask="99-9999-9999" TargetControlID="TextBoxCedula" />
                            </td>

                            <td>Nombre:
                                <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Apellido:
                                <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                Cantidad:  <asp:TextBox ID="TextBoxCantidad" runat="server" TextMode="Number"></asp:TextBox>
                           <ajaxToolkit:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers" TargetControlID="TextBoxCantidad" />
                                               
                            </td>
                        </tr>
                        <tr>
                            <td>Contrato:
                                <asp:DropDownList ID="DropDownListContrato" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td>Genero:
                                <asp:DropDownList ID="DropDownListGenero" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Rubro:
                                <asp:DropDownList ID="DropDownListRubro" runat="server">
                                </asp:DropDownList>
                            </td>
                            <td>Grupo Ocupacional:
                                <asp:DropDownList ID="DropDownListGrupo0" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            
                            <td colspan="2">Observaciones:
                                <asp:TextBox ID="TextBoxObsevaciones" runat="server"></asp:TextBox>
                            </td>
                        </tr>

                    </table>

                </div>
                <div>
                    <asp:Button ID="ButtonCancelar" runat="server" Text="Limpiar" CssClass="boton" Style="float: right" OnClick="ButtonCancelar_Click" />
                    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" CssClass="boton" Style="float: right" OnClick="ButtonModificar_Click" />
                    <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" CssClass="boton" Style="float: right" OnClientClick="Confirm()" OnClick="ButtonEliminar_Click" />
                    <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" CssClass="boton" Style="float: right" OnClick="ButtonGuardar_Click" />
                </div>


            </asp:Panel>

        </ContentTemplate>
    </asp:UpdatePanel>

     <script type = "text/javascript">
         function Confirm() {
             var confirm_value = document.createElement("INPUT");
             confirm_value.type = "hidden";
             confirm_value.name = "confirm_value";
             if (confirm("Seguro que quiere eliminar el detalle?")) {
                 confirm_value.value = "Si";
             } else {
                 confirm_value.value = "No";
             }
             document.forms[0].appendChild(confirm_value);
         }
    </script>
</asp:Content>
