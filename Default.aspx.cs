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
        var articles = monkey.retrieve<Article>("articles").OrderBy(x => x.date);

        var selectedCategory = Request.QueryString["category"];


        if (selectedCategory != null)
        {
            LoadCategory(articles.Where(x => x.category == selectedCategory), (string)selectedCategory);
            return;
        }
        var search = Request.QueryString["search"];

        if (search != null)
        {
            LoadCategory(articles.Where
                (
                x => x.text.ToLower().Contains((string)search.ToLower())
                || x.title.ToLower().Contains((string)search.ToLower())
                || x.author.ToLower().Contains((string)search.ToLower())
                ),
                "Search result"
             );

            return;
        }
        var categories = articles.Select(x => x.category).Distinct();

        foreach (var category in categories)
        {
            LoadCategory(articles.Where(x => x.category == category), category);
        }
    }

    private void LoadCategory(IEnumerable<Article> articles, string category)
    {
        var row = new HtmlGenericControl("div");
        row.Attributes["class"] = "row";
        articlesPanel.Controls.Add(new LiteralControl(String.Format("<h2>{0}</h2>", category)));
        foreach (var article in articles)
        {
            var card = (Controls_ArticleCard)Page.LoadControl("Controls/ArticleCard.ascx");
            card.Title = article.title;
            card.PictureUrl = article.picture;
            card.Text = article.text;

            row.Controls.Add(card);
        }

        articlesPanel.Controls.Add(row);
    }

    protected void searchButton_Click(object sender, EventArgs e)
    {
        Response.Redirect(String.Format("Default.aspx?search={0}", search.Value));
    }
}