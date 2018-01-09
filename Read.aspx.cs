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
    public int ArticleID { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            postCommentPanel.Visible = false;

        var articleTitle = Request.QueryString["article"];
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var article = monkey.retrieve<Article>("articles")
            .First(x => x.title == articleTitle);
        ArticleTitle = article.title;
        Text = article.text;
        PictureUrl = article.picture;
        ArticleID = article.id;

        var comments = monkey.retrieve<Comment>("comments").Where(x => x.articleID == ArticleID);
        foreach (var comment in comments)
        {

            var card = (MaterialCard)Page.LoadControl("Controls/MaterialCard.ascx");
            card.Text = comment.text;
            var user = monkey.retrieve<User>("users").First(x => x.username == comment.author);
            card.SubTitle = user.username;
            card.PictureUrl = user.picture;
            card.Tag = user.type;
            this.commentsPanel.Controls.Add(card);

        }
        this.DataBind();
        
    }

    protected void commentButton_Click(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var comment = new Comment
        {
            id = monkey.retrieve<Comment>("comments").Count() + 1,
            author = (string)Session["user"],
            articleID = ArticleID,
            text = textarea1.InnerText
        };

        monkey.insert<Comment>(comment, "comments");
        Response.Redirect(Request.RawUrl);
    }
}