<%@ Page Title="" Language="C#" MasterPageFile="~/UI.Master" AutoEventWireup="true" CodeBehind="HTReportesUI.aspx.cs" Inherits="Planeacion.Interface.HTReportesUI" %>
<%@ MasterType VirtualPath="~/UI.Master" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
    
     <p>
        Reportes:&nbsp;
        <asp:DropDownList ID="DropDownListReport" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownListReport_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <div align="center">
        <div style="background-color:rgba(255, 255, 255, 0.75); margin-left:15%;margin-right:15%; height:600px">
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Heigh="100%" BackColor="White" ></rsweb:ReportViewer>
            </div>
    </div>
    <p>
        &nbsp;</p>
        </ContentTemplate></asp:UpdatePanel>
</asp:Content>
