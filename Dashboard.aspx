<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Panou de control</h1>

            <p runat="server" id ="bunVenit"></p>
             <div class="row">
                    <div class="input-field col s12">
                        <button type="submit" id="loginButton" onserverclick="Logout_Click" runat="server" name="action">Logout</button>            
                    </div>
                  </div>
        </div>
    </form>
</body>
</html>
