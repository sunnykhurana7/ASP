using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingApplicationPagesAndData
{
    public partial class CaCheLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // generate a random numbers
            Random rnd = new Random();
            Label1.Text = rnd.Next(10).ToString();
        }
    }
}