<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEditarArtista.aspx.cs" Inherits="Chinook.UI.WebForm.Mantenimientos.FrmEditarArtista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre "></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar" Width="160px" />
        </div>
    </form>
</body>
</html>
