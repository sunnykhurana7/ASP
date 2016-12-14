using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaintainingApplicationState
{
    public partial class ExampleOfPersistentCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get Current Value Of Cookie
            int counter = 0;
            if (Request.Cookies["counter"] != null)
                counter = Int32.Parse(Response.Cookies["counter"].Value);
            // Increment The Counter

            counter++;

            // Add The Persistent Cookie To The Browser
            Response.Cookies["counter"].Value = counter.ToString();
            // Add the Expiry Date When The Cookie Is Expired

            Response.Cookies["counter"].Expires = DateTime.Now.AddYears(2);


            // Display The Value Of Counter Values
            Label1.Text = counter.ToString();

        }
    }
}