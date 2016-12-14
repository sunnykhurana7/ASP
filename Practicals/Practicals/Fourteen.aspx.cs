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
    public partial class Fourteen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Text = Session["names"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string message = TextBox3.Text;
            
            //make a connectiion
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\feedback.mdf;Integrated Security=True;User Instance=True");

            // Open a new sqlconnection
            conn.Open();

            // Pass The Command
            SqlCommand comm = new SqlCommand("insert into feed (name,email,message) values (@name,@email,@message)",conn);
            comm.Parameters.AddWithValue("@name",name);
            comm.Parameters.AddWithValue("@email",email);
            comm.Parameters.AddWithValue("@message",message);

            // To Execute The Query
            int result = comm.ExecuteNonQuery();
            Label5.Text = result + "record Updated";

        }
    }
}