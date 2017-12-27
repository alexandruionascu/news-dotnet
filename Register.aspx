<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="Register" %>
<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">


    <div class="container">
        <div class="row">
            <div class="">

                <div class="row">
                  <div class="input-field col s12 center">
                    <img src="IMG/default_avatar.png" width="100" class="circle responsive-img valign profile-image-login">
                    <p class="center login-form-text">Register</p>
                  </div>
                </div>
                <form class="col s12">
                  <div class="row">
                    <div class="input-field col s12">
                      <i class="material-icons prefix">account_circle</i>
                      <input id="username" runat="server" type="text" class="validate">
                      <label for="username">Username</label>
                    </div>
                   </div>
                    <div class="row">
                    <div class="input-field col s12">
                      <i class="material-icons prefix">email</i>
                      <input id="email" runat="server"  type="text" class="validate">
                      <label for="email">Email</label>
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
                      <i class="material-icons prefix">lock</i>
                      <input id="confirmpassword" runat="server" type="password" class="validate">
                      <label for="confirmpassword">Confirm password</label>              
                    </div>
                  </div>
                  
                  <div class="row">
                    <div class="input-field col s12">
                        <button class="btn waves-effect waves-light col s12" id="registerButton" type="submit" onserverclick="Register_Click" runat="server" name="action">Register</button>            
                    </div>
                  </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>