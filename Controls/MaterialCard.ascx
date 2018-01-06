<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MaterialCard.ascx.cs" Inherits="MaterialCard" %>
<style>
    .no-margin {
        margin: 0;
    }
</style>
<div class="z-depth-1" style="min-width: 300px; max-width:500px; padding: 0em 1.5em 1.5em 0.5em; min-height: 50px; background: white">
    <div class="z-depth-1" style="display: inline-block; background:purple; position: relative; bottom: 1em; left: 1.5em">
        <asp:label style="font-size: 1.5em; padding: 1em; color:white" runat="server" id="tag" />
    </div>
    <div class="row no-margin">
        <div class="col s2">
            <img id="profilePicture" runat="server" style="width: 100%; height: auto; border-radius: 50%" src="<%# PictureUrl %>" />
        </div>
        
        <div class="col s10">
            <div class="row no-margin">
                <asp:label id="title" runat="server"><%# Title %></asp:label>
            </div>

            <div class="row no-margin">
                <asp:label id="subTitle" runat="server"><%# SubTitle %></asp:label>
            </div>

            <div class="row no-margin">
                <asp:label id="text" runat="server"><%# Text %></asp:label>
            </div>
        </div>
    </div>
</div>