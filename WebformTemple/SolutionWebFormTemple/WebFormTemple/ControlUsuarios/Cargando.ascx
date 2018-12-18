<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cargando.ascx.cs" Inherits="WebFormTemple.ControlUsuarios.Cargando" %>
<asp:UpdateProgress ID="UpdateProgress1" runat="server">
    <ProgressTemplate>
        <div class="Modal-progress">
             <div class="modal-progress-center">
                  <img src="../Content/tema/binary/assets/img/loading.gif"  runat="server" />
                  <div style="text-align:center;">
                      <asp:Literal ID="LitCargando" runat="server" text="Cargando...">
  
                      </asp:Literal>
                  </div>
             </div>
        </div>
    </ProgressTemplate>
</asp:UpdateProgress>
