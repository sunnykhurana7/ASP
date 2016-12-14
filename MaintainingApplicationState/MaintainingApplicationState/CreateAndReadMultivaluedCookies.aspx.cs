using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaintainingApplicationState
{
    public partial class CreateAndReadMultivaluedCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Generate A Multivalued Cookies
            Response.Cookies["preferences"]["firstname"] = TextBox1.Text;
            Response.Cookies["preferences"]["lastname"] = TextBox2.Text;
            Response.Cookies["preferences"]["favoritecolor"] = TextBox3.Text;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Response.Cookies["preferences"] != null)
            {
                Label4.Text = Response.Cookies["preferences"]["firstname"];
                Label5.Text = Response.Cookies["preferences"]["lastname"];
                Label6.Text = Response.Cookies["preferences"]["favoritecolor"];
            }
        }
    }
}