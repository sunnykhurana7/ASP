using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagementComplete
{
    public partial class SessionGet1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // To Set The Strings
            Label1.Text = Session["message"].ToString();
        }
    }
}