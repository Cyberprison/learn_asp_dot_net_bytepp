using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn_asp_dot_net_bytepp
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie1 = Request.Cookies["login"];

            HttpCookie httpCookie2 = Request.Cookies["sign"];

            if (httpCookie1 != null && httpCookie2 != null)
            {
                if (httpCookie2.Value == SignGenerator.GetSign(httpCookie1.Value + "key"))
                {
                    Label1.Text = httpCookie1.Value;

                    return;
                }
            }

            Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Response.Redirect("Logout.aspx");
        }
    }
}