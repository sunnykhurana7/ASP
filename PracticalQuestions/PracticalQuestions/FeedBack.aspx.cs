using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PracticalQuestions
{
    public partial class FeedBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, email, subject, message = null;
            name = TextBox1.Text;
            email = TextBox2.Text;
            subject = TextBox3.Text;
            message = TextBox4.Text;


            // Make A connection
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            // Make A Sqlcommand
            SqlCommand comm = new SqlCommand("insert into feedback (name,email,subject,,message) values (@name,@email,@subject,@message) ",conn);
            comm.Parameters.AddWithValue("@name",name);
            comm.Parameters.AddWithValue("@email",email);
            comm.Parameters.AddWithValue("@subject", subject);
            comm.Parameters.AddWithValue("@message",message);

            int result = comm.ExecuteNonQuery();
            Label6.Text = result + "Record Send";

        }
    }
}