<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmArtistEdit.aspx.cs" Inherits="Chinook.UI.WebForm.Mantenimientos.Artists.FrmArtistEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre :"></asp:Label>
    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
</asp:Content>
