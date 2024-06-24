using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace learn_asp_dot_net_bytepp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Response.Write("General information" + "<br/>");
            Response.Write(
                Request.ApplicationPath +
                "<br/>" +
                Request.PhysicalApplicationPath +
                "<br/>" +
                Request.Browser.Platform +
                "<br/>" +
                Request.Browser.Type +
                "<br/>"
            );
            Response.Write("<br/>");

            Response.Write("Languages" + "<br/>");
            foreach(var lang in Request.UserLanguages)
            {
                Response.Write(lang + "<br/>");
            }
            Response.Write("<br/>");

            Response.Write("General Language: " + Request.UserLanguages[0] + "<br/>");
            Response.Write("<br/>");

            Response.Write("Query from local PC? - " + Request.IsLocal + "<br/>");
            Response.Write("<br/>");

            Response.Write("Http Headers: " + "<br/>");
            foreach(var header in Request.Headers)
            {
                Response.Write(header + "<br/>");
            }
            Response.Write("<br/>");
            */

            //Response.Write(Request.QueryString[0]);

            //?name=Vasya&sex=male
            //foreach(var element in Request.QueryString)
            //{
            //    Response.Write(element + " - " + Request.QueryString[Convert.ToString(element)] + "<br/>");
            //}

            //Response.WriteFile(Server.MapPath("NewFolder1/TextFile1.txt"));

            //Response.Redirect("WebForm1.aspx");

        }

    }
}