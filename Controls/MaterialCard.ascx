<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MaterialCard.ascx.cs" Inherits="MaterialCard" %>
<style>
    .no-margin {
        margin: 0;
    }
</style>
<div class="z-depth-1" style="min-width: 300px; max-width:500px; padding: 1.5em 1.5em 1.5em 0.5em; min-height: 50px; background: white">
    <div class="row no-margin">
        <div class="col s2">
            <img id="profilePicture" runat="server" style="
                                                width: 100%;
                                                height: auto;
                                                border-radius: 50%"
             src="https://media.licdn.com/mpr/mpr/shrinknp_200_200/AAEAAQAAAAAAAAVEAAAAJGZjNGJkYTNiLTVlZjYtNDU2OC04OWY5LTg1ZmZiODNiZGMyOA.jpg" />
        </div>
        
        <div class="col s10">
            <div class="row no-margin">
                <asp:label id="title" runat="server" />
            </div>

            <div class="row no-margin">
                <asp:label id="subTitle" runat="server" />
            </div>

            <div class="row no-margin">
                <asp:label id="text" runat="server" />
            </div>
        </div>
    </div>
</div>