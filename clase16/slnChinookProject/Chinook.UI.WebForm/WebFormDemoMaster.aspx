<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMain.Master" AutoEventWireup="true" CodeBehind="WebFormDemoMaster.aspx.cs" Inherits="Chinook.UI.WebForm.WebFormDemoMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="./Content/tema/img/ciberteclogo.png" />
    <table class="table-custom">
        <thead>
           <tr>
              <th>ID</th>
              <th>NOMBRE</th>
              <th>MONTO</th>
           </tr>
        </thead>
        <tbody>
            <tr>
                <td>10001</td>
                <td>javier</td>
                <td>120.50</td>
            </tr>
            <tr>
                <td>10002</td>
                <td>Pedro</td>
                <td>130</td>
            </tr>
            <tr>
                <td>10003</td>
                <td>Manual</td>
                <td>1200.50</td>
            </tr>
            <tr>
                <td>10003</td>
                <td>Manual</td>
                <td>1200.50</td>
            </tr>
            <tr>
                <td>10003</td>
                <td>Manual</td>
                <td>1200.50</td>
            </tr>
        </tbody>
    </table>
</asp:Content>
