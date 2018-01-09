<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MonkeyTable.ascx.cs" Inherits="Controls_MonkeyTable" %>
<%@ Register TagPrefix="uc" TagName="MonkeyRow" Src="~/Controls/MonkeyRow.ascx" %>

<script type="text/javascript">
    window.onload = function () {
        
        $(document).ready(function () {
            $('.modal').modal();
           // $('#modal1').modal('open');
        });
       
    }

</script>


<div class="fixed-action-btn"
    style="font-weight: 700; position:relative; float: right; bottom:0; top: 0; left: 0; right:0; padding: 1em">
    Add new entry
    <a href="#modal1" class="btn-floating modal-trigger" style="background-color: #A2A2A2">
        <i class="large material-icons">add</i>
    </a>
</div>

<table>
    <thead runat="server" id="tableHead" />
    <tbody runat="server" id="tableBody" />
</table>

<!-- Modal Structure -->
<div id="modal1" class="modal">
    <asp:Panel CssClass="modal-content" runat="server" ID="addPanel">
        <h4>Add new entry</h4>
        <p>A bunch of text</p>
    </asp:Panel>
    
    <div class="modal-footer">
      <asp:Button runat="server" ID="submitButton" CssClass="modal-action modal-close waves-effect btn-flat" Text="Submit" OnClick="Submit_Click" />
    </div>
</div>