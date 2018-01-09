<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Read.aspx.cs" Inherits="Read" %>
<%@ Register TagPrefix="uc" TagName="MaterialCard" Src="~/Controls/MaterialCard.ascx" %>
<%@ Register TagPrefix="uc" TagName="ArticleCard"  Src="~/Controls/ArticleCard.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">
    <h1 class="center-align"><%= ArticleTitle %></h1>
    <div class="container" style="padding: 3em">
      <p>
          <%# Text %>
      </p>
      <img class="materialboxed" style="margin: 0 auto; padding: 3em" width="70%" src="<%# PictureUrl %>">
    </div>

    <asp:Panel runat="server" ID="postCommentPanel" CssClass="container">
    <h5>Comments</h5>

    <div class="row" style="padding: 2em">
        <div class="input-field col s4">
          <textarea id="textarea1" runat="server" class="materialize-textarea"></textarea>
          <label for="textarea1">Write your comment.</label>
        <asp:Button runat="server" ID="commentButton" OnClick="commentButton_Click" Text="Post" class="btn waves-effect waves-light grey" />
        </div>
      </div>
    </asp:Panel>

    <asp:Panel runat="server" CssClass="container" ID="commentsPanel" />
</asp:Content>