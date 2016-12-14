using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["unmae"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Session["uname"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon(); // cancels the current session
            Response.Redirect("~/Login.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Remove("uname"); // clear the paarticular sesssion id 
            //Session.Clear(); // Clear The Session Variables Only
            Response.Redirect("~/Login.aspx");
        }
    }
}