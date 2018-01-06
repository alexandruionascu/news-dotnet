using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MaterialCard : System.Web.UI.UserControl
{
    public string PictureUrl { get; set; }
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Text { get; set; }
    public string Tag { get; set; }
    public Type ModelType { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.DataBind();
        }
        
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var method = typeof(SQLMonkey).GetMethod("retrieve");
        var generic = method.MakeGenericMethod(ModelType);
        var users = generic.Invoke(monkey, new string[] {"users"}) as IEnumerable<User>;
        tag.Text = users.Count().ToString();
    }
}