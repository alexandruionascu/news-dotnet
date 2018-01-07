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
        this.DataBind();
        // connect to the database
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        // call the retrieve method using reflections
        var method = typeof(SQLMonkey).GetMethod("retrieve");
        var generic = method.MakeGenericMethod(ModelType);
        // get the result
        var instances = generic.Invoke(monkey, new string[] { Collection }) as IEnumerable<object>;
        
        // add table's head
        var columns = ModelType.GetProperties().Select(x => x.Name);
        foreach (var column in columns)
        {
            var thead = new HtmlGenericControl("th")
            {
                InnerText = column
            };
            tableHead.Controls.Add(thead);
        }
        //add table's body
        foreach (var instance in instances)
        {
            var row = new Controls_MonkeyRow
            {
                ModelType = ModelType,
                Instance = instance
            };

            tableBody.Controls.Add(row);
        }
    }
}