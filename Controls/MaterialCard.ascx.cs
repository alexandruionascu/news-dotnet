using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MaterialCard : System.Web.UI.UserControl
{
    public string PictureUrl { get; set; }
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Text { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        profilePicture.Attributes["src"] = PictureUrl;
        title.Text = Title;
        subTitle.Text = SubTitle;
        text.Text = Text;
    }
}