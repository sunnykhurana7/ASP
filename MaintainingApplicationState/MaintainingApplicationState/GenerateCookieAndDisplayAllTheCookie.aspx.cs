using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;




namespace MaintainingApplicationState
{
    public partial class GenerateCookieAndDisplayAllTheCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Generate The Cookie
            Response.Cookies["message"].Value = "sunny Khurana";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            ArrayList colcookies = new ArrayList();
            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                colcookies.Add(Request.Cookies[i]);
                GridView1.DataSource = colcookies;
                GridView1.DataBind();
            }
        }
    }
}