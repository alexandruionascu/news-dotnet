using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Controls_MonkeyTable : System.Web.UI.UserControl
{
    public Type ModelType { get; set; }
    public string Collection { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var users = monkey.retrieve<User>("Users");
        foreach (var user in users)
        {
            var row = new Controls_MonkeyRow
            {
                ModelType = typeof(User),
                Instance = user
            };
            this.Controls.Add(row);
        }
    }
}