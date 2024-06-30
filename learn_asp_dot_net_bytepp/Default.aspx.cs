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
            TextBox TextBox1 = new TextBox()
            {
                Text = "Hello"
            };

            PlaceHolder1.Controls.Add(TextBox1);
        }
    }
}