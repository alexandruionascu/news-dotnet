<%@ Page Language="C#" MasterPageFile="~/NewsMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Home" %>
<asp:Content ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="container">
        <div class="row">
            <div class="col s8">
                <h4>News</h4>
            </div>
            <form class="col s4">
              <div class="row">
                <div class="input-field col s4">
                  <input placeholder="Search" id="search" type="text" class="validate">
                </div>
            </form>

            
        </div>
        <div class="row">
            <div class="col s12 m4">
            
                <div class="card small">
                  <div class="card-image">
                    <img src="http://materializecss.com/images/sample-1.jpg">
                    <span class="card-title">Titlu 1</span>
                  </div>
                  <div class="card-content">
                    <p>I am a very simple card. I am good at containing small bits of information. I am convenient because I require little markup to use effectively.</p>
                  </div>


                  <div class="card-action">
                    <a href="#">Link 1</a>
                    <a href="#">Link 2</a>
                  </div>
                </div>
            </div>

            <div class="col s12 m4">
            
                <div class="card small">
                  <div class="card-image">
                    <img src="http://materializecss.com/images/sample-1.jpg">
                    <span class="card-title">Titlu 1</span>
                  </div>
                  <div class="card-content">
                    <p>I am a very simple card. I am good at containing small bits of information. I am convenient because I require little markup to use effectively.</p>
                  </div>


                  <div class="card-action">
                    <a href="#">Link 1</a>
                    <a href="#">Link 2</a>
                  </div>
                </div>
            </div>


            <div class="col s12 m4">
            
                <div class="card small">
                  <div class="card-image">
                    <img src="http://materializecss.com/images/sample-1.jpg">
                    <span class="card-title">Titlu 1</span>
                  </div>
                  <div class="card-content">
                    <p>I am a very simple card. I am good at containing small bits of information. I am convenient because I require little markup to use effectively.</p>
                  </div>


                  <div class="card-action">
                    <a href="#">Link 1</a>
                    <a href="#">Link 2</a>
                  </div>
                </div>
            </div>
       
        </div>



    </div>

    <a ID="button1" runat="server" class="waves-effect waves-light btn" onserverclick="ButtonClick">button</a>
</asp:Content>