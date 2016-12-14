using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Practicals
{
    public partial class Eighteen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string pass = TextBox2.Text;

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\feedback.mdf;Integrated Security=True;User Instance=True");
            // Open A New connection
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from login where username = @username and password = @password",conn);
            comm.Parameters.AddWithValue("@username",name);
            comm.Parameters.AddWithValue("@password",pass);

            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                Session["names"] = name;
                Response.Redirect("~/Fourteen.aspx");
            }
            else
            {   
                    
            }
        }
    }
}