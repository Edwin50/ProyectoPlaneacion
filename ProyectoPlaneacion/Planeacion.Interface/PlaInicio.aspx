<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaInicio.aspx.cs" Inherits="Planeacion.Interface.PlaInicio" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-1.11.3.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/estilos.css" />
    <title>Login</title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="Login">
            <h1>Login Usuario</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Nombre Usuario" Width="100"></asp:Label>
                    <asp:TextBox ID="Txt_Nombre" runat="server" Width="200" CssClass="textLogins"></asp:TextBox>

                    <br />
                    <br />

                    <asp:Label ID="Label2" runat="server" Text="Contraseña de Usuario" Width="100"></asp:Label>
                    <asp:TextBox ID="Txt_Contraseña" runat="server" Width="200" TextMode="Password" MaxLength="10" CssClass="textLogins"></asp:TextBox>
                    <br />
                    <br />
                    <%--OkControlID="btnOkay" --%>
                    <asp:Button ID="bt_Registro" runat="server" Text="Registrate" CssClass="botonLogin2"/>
                    <asp:Button ID="bt_Login" runat="server" Text="Login" Width="80" OnClick="bt_Login_Click" CssClass="botonLogin2" />
                    <ajaxToolkit:ModalPopupExtender ID="ModalPopUp1" runat="server" CancelControlID="btnCancel" 
                        TargetControlID="bt_Registro" PopupControlID="Panel1"
                        PopupDragHandleControlID="PopupHeader" Drag="true" BackgroundCssClass="modalbackground" Y="200">
                    </ajaxToolkit:ModalPopupExtender>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>


        <%--  Style="display: none" --%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always" >
            <ContentTemplate>
                <asp:Panel ID="Panel1" runat="server" CssClass="modalpopup" DefaultButton="btnOkay"  Style="display: none">
                    <h1>Registrate</h1>

                    <asp:Label ID="Label3" runat="server" Text="Nombre" Width="100"></asp:Label>
                    <asp:TextBox ID="Txt_NombreRegistro" runat="server" Width="200" MaxLength="20" ></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="Label6" runat="server" Text="Contraseña" Width="100"></asp:Label>
                    <asp:TextBox ID="Txt_Contrasena" runat="server" Width="200" MaxLength="10" TextMode="Password"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="Label5" runat="server" Text="Confirmacion de Contraseña"></asp:Label>
                    <asp:TextBox ID="Txt_ContrasenaConfirm" runat="server" Width="200" MaxLength="10" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no son iguales"
                        ControlToCompare="Txt_Contrasena" ControlToValidate="Txt_ContrasenaConfirm" Display="Dynamic" Style="color: #FF0000">
                    </asp:CompareValidator>
                    <asp:Button ID="btnOkay" runat="server" Text="Guardar" OnClick="btnOkay_Click" CssClass="botonLogin2"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="botonLogin2" />
                    <br />
                    <br />
                </asp:Panel>


            </ContentTemplate>


        </asp:UpdatePanel>


    </form>
</body>
</html>
