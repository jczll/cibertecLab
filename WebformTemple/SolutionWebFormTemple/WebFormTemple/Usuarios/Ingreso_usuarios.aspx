<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemple.Master" AutoEventWireup="true" CodeBehind="Ingreso_usuarios.aspx.cs" Inherits="WebFormTemple.Usuarios.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <h1>Ingreso al Sistema</h1>
    <img src="../Content/tema/binary/assets/img/find_user.png"  alt="logo softpad1" width="60px"/>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Usuario : " CssClass="form-control"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtLogin" runat="server" CssClass="form-control"></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password : " CssClass="form-control"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BtnLogin" runat="server" Text="Ingresar" 
                    onClick="BtnLogin_Click" CssClass="btn btn-danger"
                />
            </td>
        </tr>
    </table>
</asp:Content>
