<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Home" %>
<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>This is my content</h1>
    <a ID="button1" runat="server" class="waves-effect waves-light btn" onserverclick="ButtonClick">button</a>
</asp:Content>