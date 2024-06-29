using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn_asp_dot_net_bytepp
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Person person = new Person(TextBox1.Text, Convert.ToInt32(TextBox2.Text));

            ViewState["person"] = person;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Person person = ViewState["person"] as Person;

            if (person != null)
            {
                Label1.Text = person.Name;
                Label2.Text = Convert.ToString(person.Age);
            }
            else
            {
                Label1.Text = "null";
                Label2.Text = "null";
            }
        }
    }
}