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

        LoadRowData();
        LoadRowEditing();
        if (viewPanel.Visible)
        {
            editPanel.Visible = false;
        }
    }

    public void Edit_Click(object sender, EventArgs e)
    {
        viewPanel.Visible = false;
        editPanel.Visible = true;
    }

    public void Update_Click(object sender, EventArgs e)
    {
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
            var tableData = new HtmlGenericControl("td");
            var input = new HtmlGenericControl("input");
            input.Attributes["placeholder"] = value;
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
        return ModelType.GetProperties().Select(
            x => x.Name
        );
    }

    private IEnumerable<string> getInstanceValues()
    {
        return ModelType.GetProperties().Select(
            x => Instance.GetType().GetProperty(x.Name).GetValue(Instance, null).ToString()
        );
    }
}