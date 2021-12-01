using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString.Count > 0)
        {
            string s = Request.QueryString["data"];
            Label1.Text = "you selected state in previous page is " + s;

        }

    }
}