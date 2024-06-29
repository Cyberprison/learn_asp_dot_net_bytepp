using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace learn_asp_dot_net_bytepp
{
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;

        protected async void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            SqlCommand sqlCommand = new SqlCommand(
                "select [Login], [Password] " +
                "from [Users]",
                sqlConnection
            );

            SqlDataReader sqlDataReader = null;

            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                while (await sqlDataReader.ReadAsync())
                {
                    dictionary.Add(Convert.ToString(sqlDataReader["Login"]), Convert.ToString(sqlDataReader["Password"]));
                }
            }
            catch
            {

            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
            }

            if (TextBox2.Text == dictionary[TextBox1.Text])
            {
                HttpCookie httpCookie1 = new HttpCookie("login", TextBox1.Text);

                HttpCookie httpCookie2 = new HttpCookie("sign", SignGenerator.GetSign(TextBox1.Text + "key"));

                Response.Cookies.Add(httpCookie1);

                Response.Cookies.Add(httpCookie2);

                Response.Redirect("UserPage.aspx", false);
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}