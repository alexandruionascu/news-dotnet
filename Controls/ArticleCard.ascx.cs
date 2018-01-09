using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_ArticleCard : System.Web.UI.UserControl
{
    public string PictureUrl { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.DataBind();
    }
}