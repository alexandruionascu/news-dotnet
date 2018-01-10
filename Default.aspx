<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Home" %>
<%@ Register TagPrefix="uc" TagName="ArticleCard" Src="~/Controls/ArticleCard.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="container">
        <div class="row">
            <div class="col s4 offset-s8">
              <div class="row center-align valign-wrapper">
                <div class="input-field col s8">
                  <i class="material-icons prefix">search</i>
                  <input runat="server" placeholder="Search" id="search" type="text" class="validate">
                </div>
                 <asp:Button runat="server" ID="commentButton" OnClick="searchButton_Click" Text="Search" class="btn waves-effect waves-light" />
              </div>
            </div>
    </div>
        <asp:Panel runat="server"  id="articlesPanel"  />
</div>
</asp:Content>