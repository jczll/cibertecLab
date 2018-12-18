<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemple.Master" AutoEventWireup="true" CodeBehind="FrmConsultarArtista.aspx.cs" Inherits="Chinook.UI.WebForm.Mantenimientos.FrmConsultarArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="navbar-form navbar-left" role="search">
         <div class="form-group">
             <asp:Label ID="Label2" runat="server" Text="ARTISTA : "></asp:Label>
             <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px" placeholder="Buscar x Nombre"></asp:TextBox>
        </div>
        <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click"  CssClass="btn btn-success"/>
        <hr style="height: -15px; width: 734px" />
        <asp:GridView ID="GrdListado" runat="server" 
                      CssClass="table table-striped table-bordered table-hover" 
                      AutoGenerateColumns="false"
                      AllowPaging="true" PageSize="7"
                      OnPageIndexChanging="GrdListado_PageIndexChanging"
            >
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="Codigo" />
                <asp:BoundField DataField="Name" HeaderText="Nombre" />
                <asp:HyperLinkField 
                    HeaderText="Editar" 
                    Text="Editar" 
                    DataNavigateUrlFormatString="frmArtistEdit.aspx?id={0}" 
                    DataNavigateUrlFields="ArtistId"
                />
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <a href="FrmEditarArtista.aspx?id=<%#Eval("ArtistId")%>" style="cursor:pointer">
                           <img src="~/Content/tema/binary/assets/img/edit-icon.png"
                               class="img-editar"
                               runat ="server"
                           />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="BtnNuevo" runat="server" Font-Bold="True" ForeColor="white" OnClick="BtnNuevo_Click" Text="Nuevo" Width="121px" CssClass="btn btn-danger"/>
        <br />
    </div>
</asp:Content>
