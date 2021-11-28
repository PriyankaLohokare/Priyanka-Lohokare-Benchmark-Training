using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(TextUser.Text=="")
        {
            LblErrUser.Text = "Please Enter user Name";
        }
        else if(TextPass.Text=="")
        {
            LblErrPass.Text = "Please Enter Password";

        }
        else
        {
            DAL d = new DAL();
            string username=TextUser.Text;
            string pass=TextPass.Text;
            if (d.Login(username,pass))
            {

                Response.Redirect("WelcomePage.aspx");
            }
                else
                {
                    LblErr.Text = "Invalid Username and Password";
                }

            }
        }
    }
