<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DashboardMaster.master" CodeFile="Articles.aspx.cs" Inherits="Articles" %>
<%@ Register TagPrefix="uc" TagName="MonkeyTable" Src="~/Controls/MonkeyTable.ascx" %>

<asp:Content ContentPlaceHolderID="DashboardContent" Runat="Server">
    <style>
        td {
            max-width: 50px;
        }
    </style>
    <h1>Articles</h1>
    <uc:MonkeyTable ID="articlesTable" runat="server" ModelType="<%# typeof(Article) %>" Collection="articles" />
 
</asp:Content>