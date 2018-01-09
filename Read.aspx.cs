using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Read : System.Web.UI.Page
{
    public string ArticleTitle { get; set; }
    public string Text { get; set; }
    public string PictureUrl { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var articleTitle = Request.QueryString["article"];
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var article = monkey.retrieve<Article>("articles")
            .First(x => x.title == articleTitle);
        ArticleTitle = article.title;
        Text = article.text;
        PictureUrl = article.picture;
        this.DataBind();
        
    }
}