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
        var columns = typeof(User).GetProperties().Select(x => x.Name);
        foreach (var column in columns)
        {
            var thead = new HtmlGenericControl("th");
            thead.InnerText = column;
            tableHead.Controls.Add(thead);
        }
        foreach (var user in users)
        {
            var row = new Controls_MonkeyRow
            {
                ModelType = typeof(User),
                Instance = user
            };

            tableBody.Controls.Add(row);
        }
    }
}