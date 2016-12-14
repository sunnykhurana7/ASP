using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalQuestions
{
    public partial class ShowVariousUseOfControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string hobbies = DropDownList1.SelectedItem.ToString();
            string gender = null;
            string qualifications = null;
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }else
                if (RadioButton2.Checked)
                {
                    gender = "Female";
                }

            if (CheckBox1.Checked)
            {
                qualifications = "Graduation";
            }

            if (CheckBox2.Checked)
            {
                qualifications = "Post Graduation";
            }

            Label6.Text = "Username Is:-" + username + "\n" + "Hobbies is:-"  + hobbies + "Gender Is:- " + gender + "Qualifications is:-" + qualifications
                                    ;

        }
    }
}