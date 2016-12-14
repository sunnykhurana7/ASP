using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;




namespace XstensibleMarkupLanguuage
{
    public partial class ReadXmlLanguage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/App_Data/Firstfile.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}