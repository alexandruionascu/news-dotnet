using System;
using System.Linq;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var count = monkey.retrieve<User>("Users").Count();
        var user = new User
        {
            username = username.Value,
            password = password.Value,
            email = email.Value,
            type = "reader",
            id = count + 1
        };

        monkey.insert<User>(user, "Users");
        registerButton.InnerText = "Sucessfuly registered";       
    }
}