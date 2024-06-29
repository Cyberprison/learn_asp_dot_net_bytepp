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
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "1");
            dictionary.Add(2, "2");

            string temp = Request.QueryString["id"];

            if(!string.IsNullOrEmpty(temp))
            {
                Label1.Text = dictionary[Convert.ToInt32(temp)];
            }
            else
            {
                Label1.Text = "parametr id is empty";
            }
        }
    }
}