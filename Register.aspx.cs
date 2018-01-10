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
            picture = pictureInput.Value,
            type = "reader",
            id = count + 1
        };

        if(user.username == String.Empty)
        {
            registerButton.InnerText = "Nu ai introdus numele de utilizator!";
            return;
        }

        if (password.Value != confirmpassword.Value)
        {
            registerButton.InnerText = "Parolele sunt diferite!";
            return;
        }

        if (user.email == String.Empty)
        {
            registerButton.InnerText = "Nu ai introdus email-ul!";
            return;
        }

        monkey.insert<User>(user, "Users");
        Response.Redirect("Default.aspx");
    }
}