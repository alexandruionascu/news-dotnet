<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DashboardMaster.master" CodeFile="Comments.aspx.cs" Inherits="Comments" %>
<%@ Register TagPrefix="uc" TagName="MonkeyTable" Src="~/Controls/MonkeyTable.ascx" %>

<asp:Content ContentPlaceHolderID="DashboardContent" Runat="Server">
    <style>
        td {
            max-width: 50px;
        }
    </style>
    <h1>Comments</h1>
    <uc:MonkeyTable runat="server" ModelType="<%# typeof(Comment) %>" Collection="comments" />
</asp:Content>