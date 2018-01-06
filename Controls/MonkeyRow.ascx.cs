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
        if (Instance == null)
        {
            throw new Exception("No instance object attached to row!");
        }

        var values = ModelType.GetProperties().Select(
            x => Instance.GetType().GetProperty(x.Name).GetValue(Instance, null).ToString()
        );

        var row = new HtmlTableRow();
        foreach (var value in values)
        {
            var td = new HtmlTableCell();
            td.InnerText = value;
            row.Controls.Add(td);
        }

        this.Controls.Add(row);
    }
    
}