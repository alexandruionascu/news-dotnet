﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void ButtonClick(Object sender, EventArgs e)
    {
        var user = new User("Users");
        user.username = "Bos";
        user.password = "123";
        this.button1.InnerText = user.generateInsertQuery();
    }
}