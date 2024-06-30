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
        string key = "counter";

        public int Counter
        {
            get
            {
                int c = 0;

                object obj = Application[key];

                if (obj != null)
                {
                    c = (int)obj;
                }

                return c;
            }
            set
            {
                Application[key] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Counter);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Counter += 2;

            Label1.Text = Convert.ToString(Counter);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application.Lock();

            int counter = 0;

            object obj = Application["key"];

            if(obj != null)
            {
                counter = (int)obj;
            }

            counter += 10;

            Application["key"] = counter;

            Label2.Text = Convert.ToString(counter);

            Application.UnLock();
        }
    }
}