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
        if(!IsPostBack)
        {
            this.DataBind();
        }

        if (Instance == null)
        {
            throw new Exception("No instance object attached to row!");
        }

        LoadRowData();
        LoadRowEditing();

        if (viewPanel.Visible)
        {
            editPanel.Visible = false;
        }
    }

    public void Edit_Click(object sender, EventArgs e)
    {
        
        editPanel.Visible = true;
        viewPanel.Visible = false;
    }

    private IEnumerable<HtmlGenericControl> GetTablesData(Panel parent)
    {
        var tr = parent.Controls.OfType<HtmlGenericControl>().First();
        return tr.Controls.OfType<HtmlGenericControl>();
    }

    public void Update_Click(object sender, EventArgs e)
    {
        var values = new List<string>();
        var tds = GetTablesData(editPanel);
        foreach (var td in tds)
        {
            var textbox = td.Controls.OfType<TextBox>().FirstOrDefault();
            if (textbox != null)
            {
                values.Add(textbox.Text);
            }

        }
       
        var propValuePairs  = getInstaceProperties().Zip(values, (p, v) => Tuple.Create(p, v));

        foreach (var pair in propValuePairs)
        {
            if (pair.Item2 == String.Empty)
            {
                continue;
            }

            var prop = ModelType.GetProperty(pair.Item1);
            object value = prop.GetValue(Instance, null);
            object valueToSet = pair.Item2;

            if (prop.PropertyType == typeof(int))
            {
                valueToSet = Convert.ToInt32(valueToSet);
            }
            else if (prop.PropertyType != typeof(string))
            {
                throw new Exception
                (
                    String.Format("Property type {0} in object model is not supported.")
                );
            }
            else
            {
                prop.SetValue(Instance, valueToSet, null);
            }
        }

        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        // call the update method using reflections
        var method = typeof(SQLMonkey).GetMethod("update");
        var generic = method.MakeGenericMethod(ModelType);
        generic.Invoke(monkey, new object[] { Instance, "users" });

        // set updated data to the view row
        var tdValuePairs = GetTablesData(viewPanel).Zip(values,
            (td, value) => Tuple.Create(td, value));

        foreach (var tdValuePair in tdValuePairs)
        {
            if (tdValuePair.Item2 == String.Empty)
            {
                continue;
            }

            tdValuePair.Item1.InnerText = tdValuePair.Item2;
        }
        viewPanel.Visible = true;
        editPanel.Visible = false;
    }

    public void Delete_Click(object sender, EventArgs e)
    {
        this.Visible = false;
    }



    private void LoadRowEditing()
    {
        var row = new HtmlGenericControl("tr");
        foreach (var value in getInstanceValues())
        {
            var input = new TextBox();
            input.Attributes["placeholder"] = value;
            var tableData = new HtmlGenericControl("td");
            tableData.Controls.Add(input);
            row.Controls.Add(tableData);
        }

         var td = new HtmlGenericControl("td");
         var anchor = new HtmlAnchor();
         anchor.ServerClick += Update_Click;
         anchor.Controls.Add(CreateIcon("check_circle"));
         td.Controls.Add(anchor);
         row.Controls.Add(td);
         editPanel.Controls.Add(row);
    }

    private void LoadRowData()
    {
        var row = new HtmlGenericControl("tr");
        foreach (var value in getInstanceValues())
        {
            row.Controls.Add(new HtmlGenericControl("td") { InnerText = value });
        }

        var td1 = new HtmlGenericControl("td");
        var a1 = new HtmlAnchor();
        a1.ServerClick += Edit_Click;

        var td2 = new HtmlGenericControl("td");
        var a2 = new HtmlAnchor();
        a2.ServerClick += Delete_Click;

        a1.Controls.Add(CreateIcon("mode_edit"));
        td1.Controls.Add(a1);

        a2.Controls.Add(CreateIcon("delete"));
        td2.Controls.Add(a2);

        row.Controls.Add(td1);
        row.Controls.Add(td2);

        viewPanel.Controls.Add(row);
    }

    private HtmlGenericControl CreateIcon(string iconName)
    {
        var icon = new HtmlGenericControl("i");
        icon.Attributes["class"] = "material-icons";
        icon.InnerText = iconName;
        return icon;
    }

    private IEnumerable<string> getInstaceProperties()
    {
        return ModelType.GetProperties().Select
        (
            x => x.Name
        );
    }

    private IEnumerable<string> getInstanceValues()
    {
        return ModelType.GetProperties().Select
        (
            x => Instance.GetType().GetProperty(x.Name).GetValue(Instance, null).ToString()
        );
    }
}