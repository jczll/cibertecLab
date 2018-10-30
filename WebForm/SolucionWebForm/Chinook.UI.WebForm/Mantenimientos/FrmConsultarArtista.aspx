<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmConsultarArtista.aspx.cs" Inherits="Chinook.UI.WebForm.Mantenimientos.FrmConsultarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label2" runat="server" Text="ARTISTA : "></asp:Label>
    <asp:TextBox ID="txtFiltroByName" runat="server"></asp:TextBox>
    <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" />
    <hr style="height: -15px; width: 734px" />
    <asp:GridView ID="GrdListado" runat="server">
    </asp:GridView>
    <asp:Button ID="BtnNuevo" runat="server" Font-Bold="True" ForeColor="#CC3300" OnClick="BtnNuevo_Click" Text="Nuevo" Width="121px" />
    <br />

</asp:Content>
