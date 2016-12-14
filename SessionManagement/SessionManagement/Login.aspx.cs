using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;




namespace SessionManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label4.Text = Session["important message"].ToString();
           // Label5.Text = Session["when end"].ToString();
            TextBox3.Text = Application["sessioncount"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            String password = TextBox2.Text;
                
            if((username == "sunny") && (password == "sunny")){
                Session["uname"] = username;
                //Session.Add("uname", username);
                Response.Redirect("~/Home.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label3.Text = Session.SessionID;
        }
    }
}