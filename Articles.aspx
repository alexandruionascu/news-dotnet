<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DashboardMaster.master" CodeFile="Articles.aspx.cs" Inherits="Articles" %>
<%@ Register TagPrefix="uc" TagName="Card" Src="~/Controls/MaterialCard.ascx" %>
<asp:Content ContentPlaceHolderID="DashboardContent" Runat="Server">
    <h1>Articles</h1>
    <uc:Card runat="server" PictureUrl="http://fuuse.net/wp-content/uploads/2016/02/avatar-placeholder.png" />
</asp:Content>
