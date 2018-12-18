<%@ Page Title="" Language="C#" MasterPageFile="~/MasterTemple.Master" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="WebFormTemple.Ventas.Busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
     <div class="navbar-form navbar-left" role="search">
         <div class="form-group">
             <asp:Label ID="Label2" runat="server" Text="TRACKS : "></asp:Label>
             <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px" placeholder="Buscar x Nombre"></asp:TextBox>
        </div>
        <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" OnClick="BtnConsultar_Click"  CssClass="btn btn-success"/>
        <hr style="height: -15px; width: 734px" />
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
                               <a class="btn btn-default" href="Carrito.aspx?id=<%#Eval("TrackId")  %>">
                                  Comprar
                               </a>
                           </td>
                       </tr>
                   </table>
                </div>
            </ItemTemplate>
            <FooterTemplate>

            </FooterTemplate>
        </asp:DataList>
        <br />
    </div>
</asp:Content>
