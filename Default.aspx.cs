using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    public string ArticleTitle { get; set; }
    public string Picture { get; set; }
    public string Text { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var articles = monkey.retrieve<Article>("articles").OrderBy(x => x.date).Take(30);
        var categories = articles.Select(x => x.category).Distinct();

        foreach (var category in categories)
        {
            var row = new HtmlGenericControl("div");
            row.Attributes["class"] = "row";
            articlesPanel.Controls.Add(new LiteralControl(String.Format("<h2>{0}</h2>", category)));
            foreach (var article in articles.Where(x => x.category == category))
            {
                var card = (Controls_ArticleCard)Page.LoadControl("Controls/ArticleCard.ascx");
                card.Title = article.title;
                card.PictureUrl = article.picture;
                card.Text = article.text;

                row.Controls.Add(card);
            }

            articlesPanel.Controls.Add(row);
        }
    }

    protected void searchButton_Click(object sender, EventArgs e)
    {
        Console.Write(23);
        // refresh to search=input query
    }
}