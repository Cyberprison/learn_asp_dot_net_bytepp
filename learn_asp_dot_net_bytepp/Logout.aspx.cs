using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn_asp_dot_net_bytepp
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie httpCookie1 = new HttpCookie("login", String.Empty);

            HttpCookie httpCookie2 = new HttpCookie("sign", String.Empty);

            httpCookie1.Expires = DateTime.Now.AddDays(-1);

            httpCookie2.Expires = DateTime.Now.AddDays(-1);

            Response.Cookies.Add(httpCookie1);

            Response.Cookies.Add(httpCookie2);

            Response.Redirect("Login.aspx");
        }
    }
}