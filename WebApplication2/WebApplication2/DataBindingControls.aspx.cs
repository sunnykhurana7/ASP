using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;




namespace WebApplication2
{
    public partial class DataBindingControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from DemoTable",conn);

            SqlDataReader rdr = comm.ExecuteReader();
            //SqlDataReader rdr1 = comm.ExecuteReader();

            //GridView1.DataSource = rdr;
            //GridView1.DataBind();


           // DetailsView1.DataSource = rdr;
            //DetailsView1.DataBind();



            DataList1.DataSource = rdr;
            DataList1.DataBind();
        }   

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conter = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            conter.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from DemoTable",conter);
            DataSet ds = new DataSet();

            da.Fill(ds,"DemoTable");
            ds.WriteXml(Request.PhysicalPath + "e.xml",XmlWriteMode.WriteSchema);

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}