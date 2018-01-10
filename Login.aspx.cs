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
        if (Session["user"] != null)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        if (username.Value == String.Empty)
        {
            Eroare.InnerText = "Nu ai introdus username-ul!";
            return;
        }

        if (password.Value == String.Empty)
        {
            Eroare.InnerText = "Nu ai introdus parola!";
            return;
        }

        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var user = monkey.retrieve<User>("users").FirstOrDefault(
            x => x.username == username.Value && x.password == password.Value
        );

        if (user == null)
        {
            Eroare.InnerText = "Parola gresita!";
            return;
        }

        Session["user"] = user.username;

        if (user.type == "admin")
        {
            Response.Redirect("Users.aspx");
            return;
        } 
        else if (user.type == "editor")
        {
            Response.Redirect("Articles.aspx");
        }

        Response.Redirect("Default.aspx");

    }
}