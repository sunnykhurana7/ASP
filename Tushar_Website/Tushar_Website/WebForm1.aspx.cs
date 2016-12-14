using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace Tushar_Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String first_button = TextBox1.Text;
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into dummy (name) values (@name) ", conn);
            comm.Parameters.AddWithValue("@name",first_button);
            
            int insert = comm.ExecuteNonQuery();
            if (insert == 1)
            {
                TextBox2.Text = "done";
            }
        }
    }
}