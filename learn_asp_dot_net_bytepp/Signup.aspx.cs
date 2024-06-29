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
    public partial class Signup : System.Web.UI.Page
    {
        SqlConnection sqlConnection = null;

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

            if (dictionary.Keys.Contains(TextBox1.Text) != true)
            {
                sqlCommand = new SqlCommand(
                    "insert into [Users] " +
                    "(Login, Password)" +
                    "values (@Login, @Password)",
                    sqlConnection
                );

                sqlCommand.Parameters.AddWithValue("Login", TextBox1.Text);
                sqlCommand.Parameters.AddWithValue("Password", TextBox2.Text);

                await sqlCommand.ExecuteNonQueryAsync();

                Response.Redirect("Login.aspx", false);
            }
            else
            {
                string script = "alert('this is have')";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBox", script, true);
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