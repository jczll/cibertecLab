<%@ Page Title="" Language="C#" MasterPageFile="~/BynaryMaster.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="Chinook.UI.WebForm.Ventas.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="navbar-form navbar-left" role="search">
        <div class="form-group">
            <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px" placeholder="Buscar x Nombre"></asp:TextBox>
            <input type="date" />
        </div>
        <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" CssClass="btn btn-success"/>
        <br />
        <br />
        <hr style="height: -15px; width: 734px" />
        <br />
        <asp:DataList ID="dlTracks" runat="server" RepeatColumns="2">
            <HeaderTemplate>
                Lista de tracks
            </HeaderTemplate>
            <ItemTemplate>
                <div class="dataListItem">
                   <table class="table">
                      <tr>
                         <td>Nombre</td>
                         <td><%#Eval("TrackName") %></td>
                      </tr>
                      <tr>
                         <td>Artista</td>
                         <td><%#Eval("ArtistName") %></td>
                      </tr>
                      <tr>
                         <td>titulo</td>
                         <td><%#Eval("Title") %></td>
                      </tr>
                      <tr>
                         <td>Media</td>
                         <td><%#Eval("MediaTypeName") %></td>
                      </tr>
                      <tr>
                         <td>Composer</td>
                         <td><%#Eval("Composer") %></td>
                      </tr>
                       <tr>
                           <td colspan="2">
                               <button class="btn btn-danger" style="float:right;padding:0px">Descargar</button>
                           </td>
                       </tr>
                   </table>
                </div>
            </ItemTemplate>
            <FooterTemplate>

            </FooterTemplate>
        </asp:DataList>
    </div>
</asp:Content>
