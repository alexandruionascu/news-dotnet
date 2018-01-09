<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Read.aspx.cs" Inherits="Read" %>

<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="center-align"><%= ArticleTitle %></h1>
    <div class="container" style="padding: 3em">
      <p>
          <%# Text %>
      </p>
      <img class="materialboxed" style="margin: 0 auto; padding: 3em" width="70%" src="<%# PictureUrl %>">
    </div>
</asp:Content>