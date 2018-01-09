<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ArticleCard.ascx.cs" Inherits="Controls_ArticleCard" %>
    <div class="col s12 m6 l4">
      <div class="card">
        <div class="card-image">
          <img src="<%# PictureUrl %>" style="max-height: 300px">
          <span class="card-title"><%# Title %></span>
          <a class="btn-floating halfway-fab waves-effect waves-light red"><i class="material-icons">pageview</i></a>
        </div>
        <div class="card-content">
          <p class="truncate"><%# Text %></p>
        </div>
      </div>
    </div>