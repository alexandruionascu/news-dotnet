using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["alex"] != null)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var user = username.Value;
        var pass = password.Value;
        if(user == String.Empty)
        {
            Eroare.InnerText = "Nu ai introdus username-ul!";
        }
        if (pass == String.Empty)
        {
            Eroare.InnerText = "Nu ai introdus parola!";
        }
        if (user == "alex" && pass == "123456")
        {
            Session[user] = true;
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            Eroare.InnerText = "Logare esuata!";
        }
        // var username = username.Value;
        //var select = monkey.retrieve<User>("Users").Where();

    }
}