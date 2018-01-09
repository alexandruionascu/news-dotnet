<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Home" %>
<%@ Register TagPrefix="uc" TagName="ArticleCard" Src="~/Controls/ArticleCard.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="container">
        <div class="row">
            <div class="col s8">
                <h4>News</h4>
            </div>
            <div class="col s4">
              <div class="row">
                <div class="input-field col s4">
                  <input placeholder="Search" id="search" type="text" class="validate">
                </div>
              </div>
            </div>
        <div class="row">
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
            <uc:ArticleCard runat="server" PictureUrl="https://upload.wikimedia.org/wikipedia/commons/5/58/Sunset_2007-1.jpg" Title="Boss" Text="Soarele rasare"/>
       </div>
    </div>
</div>
</asp:Content>