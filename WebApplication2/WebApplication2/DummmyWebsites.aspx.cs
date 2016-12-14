using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication2
{
    public partial class DummmyWebsites : System.Web.UI.Page
    {

        SqlConnection conn = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conti = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            conti.Open();
            SqlCommand comi = new SqlCommand("select * from DemoTable", conti);
            SqlDataReader rdrs = comi.ExecuteReader();
            while (rdrs.Read())
            {
                DropDownList1.Items.Add(rdrs[0].ToString());
            }
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection connnn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            connnn.Open();

            String usernames = TextBox1.Text;
            String Password = TextBox2.Text;

            SqlCommand comm = new SqlCommand("insert into DemoTable (username,password) values (@uname,@passw)", connnn);
            comm.Parameters.AddWithValue("@uname",usernames);
            comm.Parameters.AddWithValue("@passw",Password);
            int result = comm.ExecuteNonQuery();


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload = function(){");
            sb.Append("alert('");
            sb.Append("1 Record Insert Successfully" + result);
            sb.Append("')};");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            SqlConnection condel1 = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            condel1.Open();

           
            // just make a object of the sqlcommand
            SqlCommand comm = new SqlCommand("select * from DemoTable",condel1);


            // Now make An Object of the sqlreader class to store the data and execute the command
            SqlDataReader rdr = comm.ExecuteReader();

            // Now attach the Reader With the Gridview control
            GridView1.DataSource = rdr;

            // Now bind it with the DataSource
            GridView1.DataBind();   
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            SqlConnection condel = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            condel.Open();
            SqlCommand comm = new SqlCommand("delete from DemoTable where username = @uname ", condel);

            comm.Parameters.AddWithValue("@uname", username);
            comm.ExecuteNonQuery();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/XMLFile1.xml"));

            GridView2.DataSource = ds;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String password = TextBox2.Text;
            String username = TextBox1.Text;

            // Code For Update The Value
            SqlConnection conti = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            // open the connection
            conti.Open();


            SqlCommand comm = new SqlCommand("update DemoTable set password = @pass where username = @uname" , conti);
            comm.Parameters.AddWithValue("@pass",password);
            comm.Parameters.AddWithValue("@uname",username);
            comm.ExecuteNonQuery();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection cona = null;
            SqlDataAdapter cond = null;
            DataSet ds = null;
            DataView dv = null;
            DataTable dt = null;

            cona = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            cona.Open();

            String sql = "select * from DemoTable";
            cond = new SqlDataAdapter(sql,cona);
            ds = new DataSet();

            cond.Fill(ds,"DemoTable");
            dt = ds.Tables["DemoTable"];

            dv = new DataView(dt);

            GridView3.DataSource = dv;
            GridView3.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection conf = null;
            SqlDataAdapter dataa = null;
            DataSet dss = null;
            DataView dv2 = null;
            DataTable dts = null;


            conf = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Demo.mdf;Integrated Security=True;User Instance=True");
            conf.Open();

            String sql = "Select * from DemoTable";
            dataa = new SqlDataAdapter(sql,conf);
            dss = new DataSet();

            dataa.Fill(dss, "DemoTable");
            dts = dss.Tables["DemoTable"];

            dv2 = new DataView(dts);


            GridView4.DataSource = dv2;
            GridView4.DataBind();

           
            dts = dss.Tables["DemoTable"];
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}