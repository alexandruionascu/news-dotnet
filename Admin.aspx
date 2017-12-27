<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Project News</title>
     <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
     <link rel="stylesheet" runat="server" href="~/CSS/materialize.css">
     
     <link href="~/CSS/font-nunito.css" rel="stylesheet"> 
     <link href="~/CSS/news-master.css" rel="stylesheet"> 
     <link href="~/CSS/admin.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

    <div class="container" runat="server">
        <div class="row">
            <div class="box col s4 offset-s4 z-depth-4 card-panel">

                <div class="row">
                  <div class="input-field col s12 center">
                    <img src="IMG/default_avatar.png" width="100" class="circle responsive-img valign profile-image-login">
                    <p class="center login-form-text">Welcome back, Admin</p>
                  </div>
                </div>
                <div id="Eroare" onserverclick="Login_Click" runat="server"></div>
                <form class="col s12">
                  <div class="row">
                    <div class="input-field col s12">
                      <i class="material-icons prefix">account_circle</i>
                      <input id="username" runat="server"  type="text" class="validate">
                      <label for="username">Username</label>
                    </div>
                   </div>
                  <div class="row">
                    <div class="input-field col s12">
                      <i class="material-icons prefix">lock</i>
                      <input id="password" runat="server" type="password" class="validate">
                      <label for="password">Password</label>              
                    </div>
                  </div>
                  
                  <div class="row">
                    <div class="input-field col s12">
                        <button class="btn waves-effect waves-light col s12" type="submit" id="loginButton" onserverclick="Login_Click" runat="server" name="action">Login</button>            
                    </div>
                  </div>
                </form>
            </div>
        </div>
    </div>

    </form>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="JS/materialize.js"></script>
</body>
</html>
