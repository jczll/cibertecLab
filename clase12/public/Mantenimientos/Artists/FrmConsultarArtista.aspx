<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Site.Master" CodeBehind="FrmConsultarArtista.aspx.cs" Inherits="Chinook.UI.WebForm.FrmConsultarArtista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label2" runat="server" Text="ARTISTA : "></asp:Label>
    <asp:TextBox ID="txtFiltroByName" runat="server"></asp:TextBox>
    <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" />
    <hr style="height: -15px; width: 734px" />
    <asp:Button ID="Button2" runat="server" OnClick="btnNuevo_Click" Text="Nuevo" />
    <asp:GridView ID="GrdListado" runat="server">
    </asp:GridView>
    <br />
</asp:Content>

