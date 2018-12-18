<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemple.Master" AutoEventWireup="true" CodeBehind="FrmEditarArtista.aspx.cs" Inherits="WebFormTemple.Mantenimientos.FrmEditarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:HiddenField ID="HFId" runat="server" />
    <asp:Label ID="Label1" runat="server" Text="Nombre :"></asp:Label>
    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-success" />
</asp:Content>
