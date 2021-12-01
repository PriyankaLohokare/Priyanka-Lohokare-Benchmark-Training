using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //means if page is first time calling then only add value
        if (!Page.IsPostBack)
        {
            ddstate.Items.Add("Maharashtra");
            ddstate.Items.Add("Goa");
            ddstate.Items.Add("Madhya Pradesh");
            ddstate.Items.Add("Gujrat");
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Selected State Is " + ddstate.SelectedItem;
        Response.Redirect("default2.aspx?data=" + ddstate.SelectedItem);

    }

    protected void ddstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Text= "Selected State Is " + ddstate.SelectedItem;
        
    }
}