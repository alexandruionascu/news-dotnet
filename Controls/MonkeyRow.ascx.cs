using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Controls_MonkeyRow : System.Web.UI.UserControl
{
    public Type ModelType { get; set; }
    public object Instance { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.DataBind();
        
        if (Instance == null)
        {
            throw new Exception("No instance object attached to row!");
        }

        var values = ModelType.GetProperties().Select(
            x => Instance.GetType().GetProperty(x.Name).GetValue(Instance, null).ToString()
        );

        var row = new HtmlGenericControl("tr");
        foreach (var value in values)
        {
            var td = new HtmlGenericControl("td")
            {
                InnerText = value
            };
            row.Controls.Add(td);
        }

        var td1 = new HtmlGenericControl("td");
        var a1 = new HtmlAnchor();
        a1.ServerClick += Delete_Click;
        var icon = new LiteralControl
        {
            Text = "<i class='material-icons'>mode_edit</i>"
        };

        a1.Controls.Add(icon);
        td1.Controls.Add(a1);
        row.Controls.Add(td1);
        this.Controls.Add(row);

    }

    public void Delete_Click(object sender, EventArgs e)
    {
        this.Visible = false;
    }
}