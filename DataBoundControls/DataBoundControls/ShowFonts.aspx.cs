using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Text;

namespace DataBoundControls
{
    public partial class ShowFonts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InstalledFontCollection fonts = new InstalledFontCollection();
                GridView1.DataSource = fonts;
                GridView1.DataBind();
            }
        }
    }
}