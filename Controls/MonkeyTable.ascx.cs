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
            var row = (Controls_MonkeyRow)Page.LoadControl("Controls/MonkeyRow.ascx");

            row.ModelType = ModelType;
            row.Instance = instance;
            row.Collection = Collection;

            tableBody.Controls.Add(row);
        }

        //add entry panel
        var tr = new HtmlGenericControl("tr");
        foreach (var name in columns)
        {
            var input = new TextBox();
            input.Attributes["placeholder"] = name;
            var tableData = new HtmlGenericControl("td");
            tableData.Controls.Add(input);
            tr.Controls.Add(tableData);
        }

        addPanel.Controls.Add(tr);
    }

    public void Submit_Click(object sender, EventArgs e)
    {
        var tds = Controls_MonkeyRow.GetTablesData(addPanel);
        var values = new List<string>();
        foreach (var td in tds)
        {
            values.Add(td.Controls.OfType<TextBox>().First().Text);
        }
        var propValuePairs = ModelType.GetProperties()
            .Select(x => x.Name).Zip(values, (n, v) => Tuple.Create(n, v));
        var instance = Activator.CreateInstance(ModelType);
        Controls_MonkeyRow.GenerateInstance(propValuePairs, ModelType, instance);
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        // call the update method using reflections
        var method = typeof(SQLMonkey).GetMethod("insert");
        var generic = method.MakeGenericMethod(ModelType);
        generic.Invoke(monkey, new object[] { instance, Collection });
        Response.Redirect(Request.RawUrl);
    }
}