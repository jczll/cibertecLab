<%@ Page Title="" Language="C#" MasterPageFile="~/BynaryMaster.Master" AutoEventWireup="true" CodeBehind="FrmConsultarTracksVenditos.aspx.cs" Inherits="Chinook.UI.WebForm.Mantenimientos.Tracks.FrmConsultarTracksVenditos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
        <div class="navbar-form navbar-left" role="search">
        <div class="form-group">
            <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px" placeholder="Buscar x Track"></asp:TextBox>
        </div>
        <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" CssClass="btn btn-success"/>
        <br />
        <br />
        <hr style="height: -15px; width: 734px" />
        <asp:GridView ID="GrdListado" runat="server" CssClass="table table-striped table-bordered table-hover">            
        </asp:GridView>
        <br />
    </div>
</asp:Content>
