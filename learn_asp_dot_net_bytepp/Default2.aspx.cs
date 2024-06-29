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
            HttpCookie httpCookie = Request.Cookies["textBox1"];

            if (httpCookie != null)
            {
                Label1.Text = httpCookie.Value;
            }
        }
    }
}