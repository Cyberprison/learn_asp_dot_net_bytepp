using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn_asp_dot_net_bytepp
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["TextBox1"];
            string age = Request.Form["TextBox2"];

            if(string.IsNullOrEmpty(name) != true && string.IsNullOrEmpty(age) != true)
            {
                Label1.Text = name;
                Label2.Text = age;
                Label3.Text = "";
            }
            else
            {
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "error";
            }
        }
    }
}