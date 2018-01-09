using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    public string ArticleTitle { get; set; }
    public string Picture { get; set; }
    public string Text { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var articles = monkey.retrieve<Article>("articles");
        foreach (var article in articles)
        {
            var card = (Controls_ArticleCard)Page.LoadControl("Controls/ArticleCard.ascx");
            card.Title = article.title;
            card.PictureUrl = article.picture;
            card.Text = article.text;

            articlesPanel.Controls.Add(card);
        }
    }
}