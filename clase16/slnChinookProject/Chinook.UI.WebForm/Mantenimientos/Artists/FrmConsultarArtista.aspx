<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/BynaryMaster.Master" CodeBehind="FrmConsultarArtista.aspx.cs" Inherits="Chinook.UI.WebForm.FrmConsultarArtista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="navbar-form navbar-left" role="search">
        <div class="form-group">
            <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px" placeholder="Buscar x Nombre"></asp:TextBox>
        </div>
        <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" CssClass="btn btn-success"/>
        <br />
        <br />
        <hr style="height: -15px; width: 734px" />
        <asp:Button ID="Button2" runat="server" OnClick="btnNuevo_Click" Text="Nuevo" CssClass="btn btn-danger" />
        <asp:GridView ID="GrdListado" runat="server" 
            CssClass="table table-striped table-bordered table-hover" 
            AutogenerateColumns="false"
            AllowPaging="true" PageSize="5"
            OnPageIndexChanging="GrdListado_PageIndexChanging"
            >            
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="Codigo" />
                <asp:BoundField DataField="Name" HeaderText="Nombre" />
                <%--Control que permite en elance con el Link, cuando son mas de un parametro deber estar separada por comas --%>
                <%--DataNavigateUrlFormatString="frmArtistEdit.aspx?id={0}&nombre{1}" 
                    DataNavigateUrlFields="ArtistId,name"--%>
            <%--<asp:HyperLinkField 
                    HeaderText="Editar" 
                    Text="Editar" 
                    DataNavigateUrlFormatString="frmArtistEdit.aspx?id={0}" 
                    DataNavigateUrlFields="ArtistId"
                />--%>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <a href="FrmArtistEdit.aspx?id=<%#Eval("ArtistId")%>" style="cursor:pointer">
                           <img src="~/Content/tema/binary/assets/img/edit-icon.png"
                               class="img-editar"
                               runat ="server"
                           />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>

