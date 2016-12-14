using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SessionManagement
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            Application["counter"] = 0;

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
           /* 
            if (Session["uname"] != null)
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
            Session["important message"] = "jagan institute of management studies";
            */

            Application.Lock();
            int count = (int)Application["counter"];
            Application["sessioncount"] = count + 2;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            int count = (int)Application["counter"];
            Application["sessioncount"] = count - 1;
            Application.UnLock();
        }
    }
}
