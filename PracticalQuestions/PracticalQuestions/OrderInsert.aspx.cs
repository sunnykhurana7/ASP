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
    public partial class OrderInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string product;
            int quantity, price, discount;


            product = TextBox1.Text;
            quantity = Convert.ToInt32(TextBox2.Text);
            price = Convert.ToInt32(TextBox3.Text);
            discount = Convert.ToInt32(TextBox4.Text);


            // make a connection
            SqlConnection connn = new SqlConnection("");

            // Make A command
            SqlCommand comm = new SqlCommand("insert into order (product,quantity,price,discount) values (@prod,@quant,@price,@discount) ",connn);
            comm.Parameters.AddWithValue("@prod",product);
            comm.Parameters.AddWithValue("@quant",quantity);
            comm.Parameters.AddWithValue("@price",price);
            comm.Parameters.AddWithValue("@discount",discount);

            int result = comm.ExecuteNonQuery();
            
        }
    }
}