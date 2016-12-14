using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Practicals
{
    public partial class Seventeeen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String item = TextBox1.Text;
            String quan = DropDownList1.SelectedItem.ToString();
            String price = TextBox2.Text;

            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\feedback.mdf;Integrated Security=True;User Instance=True");
            // open a new connnection
            conn.Open();

            SqlCommand comm = new SqlCommand("insert into order (item,quantity,price) values (@item,@quantity,@price)", conn);
            comm.Parameters.AddWithValue("@item",item);
            comm.Parameters.AddWithValue("@quantity",quan);
            comm.Parameters.AddWithValue("@price",price);

            // Now Execute The Query
            int result = comm.ExecuteNonQuery();
            Label5.Text = "Order Send ! Thanks !";
        }
    }
}