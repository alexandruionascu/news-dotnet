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

    public string SubTitle { get; set; }
    public string Text { get; set; }
    public string Title { get; set; }
    public string PictureUrl { get; set; }
    public string Tag { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.DataBind();
        }
    }
}