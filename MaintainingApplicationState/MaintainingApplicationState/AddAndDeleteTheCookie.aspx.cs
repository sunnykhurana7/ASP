using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaintainingApplicationState
{
    public partial class AddAndDeleteTheCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /// get all the cookie in the array
            string [] cookies = Request.Cookies.AllKeys;
            foreach (String cookie in cookies)
            {
                // Display in the bulletedlist
                BulletedList1.Items.Add("Deleting cookie:="+cookie);
                // Delete The Cookie
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Add The Cookies
            Response.Cookies["message"].Value = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Delete Cookies
            Response.Cookies[TextBox1.Text].Expires = DateTime.Now.AddDays(-1);
        }
    }
}