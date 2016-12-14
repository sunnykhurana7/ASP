using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


namespace DataAdopterUsageALL
{
    public partial class DummyContentUsingDataAdopter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DemoContent.mdf;Integrated Security=True;User Instance=True");
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from Student",conn);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Student");
            DataTable dt = ds.Tables["Student"];

            DataView dv = new DataView(dt);
            GridView1.DataSource = dv;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(TextBox1.Text);
            String name = TextBox2.Text;
            String phno = TextBox3.Text;

            SqlConnection conti = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DemoContent.mdf;Integrated Security=True;User Instance=True");
            conti.Open();
            SqlDataAdapter ads = new SqlDataAdapter("Select * from Student",conti);
            SqlCommand comm = new SqlCommand("insert into Student (StudentNo,StudentName,StudentPhoneNo) values (@sno,@sname,@spno) ",conti);

            comm.Parameters.AddWithValue("@sno",number);
            comm.Parameters.AddWithValue("@sname",name);
            comm.Parameters.AddWithValue("@spno",phno);

            ads.InsertCommand = comm;
            int a = ads.InsertCommand.ExecuteNonQuery();
            Label4.Text = a + "Record Inserted";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int studentnumber = Convert.ToInt32(TextBox1.Text);    
            SqlConnection confi = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DemoContent.mdf;Integrated Security=True;User Instance=True");
            confi.Open();
            SqlDataAdapter das = new SqlDataAdapter("Select * from Student ",confi);
            SqlCommand comi = new SqlCommand("Delete from Student where StudentNo = @sno",confi);

            comi.Parameters.AddWithValue("@sno",studentnumber);
            das.DeleteCommand = comi;
            int a = das.DeleteCommand.ExecuteNonQuery();
            Label4.Text = a + "Record Delete Successfully";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int studentnu = Convert.ToInt32(TextBox1.Text);
            String name = TextBox2.Text;
            String phno = TextBox3.Text;

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\DemoContent.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlDataAdapter daaa = new SqlDataAdapter("Select * from  Student",con);
            SqlCommand comma = new SqlCommand("update Student set StudentName = @sname,StudentPhoneNo = @sphno where StudentNo = @sno" , con);
            comma.Parameters.AddWithValue("@sno",studentnu);
            comma.Parameters.AddWithValue("@sname",name);
            comma.Parameters.AddWithValue("@sphno",phno);
            daaa.UpdateCommand = comma;
            int result = daaa.UpdateCommand.ExecuteNonQuery();
            Label4.Text = result + "Record Update Successfully";
        }
    }
}