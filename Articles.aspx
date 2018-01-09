<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DashboardMaster.master" CodeFile="Articles.aspx.cs" Inherits="Articles" %>
<%@ Register TagPrefix="uc" TagName="Card" Src="~/Controls/MaterialCard.ascx" %>
<asp:Content ContentPlaceHolderID="DashboardContent" Runat="Server">
    <h1>Articles</h1>
    <uc:Card runat="server" Title="Alex Boss" SubTitle="Ce smecher" Text="Acesta e textu meu." Tag="user" PictureUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/AAEAAQAAAAAAAAVEAAAAJGZjNGJkYTNiLTVlZjYtNDU2OC04OWY5LTg1ZmZiODNiZGMyOA.jpg" />
</asp:Content>