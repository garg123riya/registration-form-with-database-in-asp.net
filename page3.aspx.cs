using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Label2.Text = SessionHelper.name;
            Label4.Text = SessionHelper.mail;
          

            if (SessionHelper.gender != null)
            {
                Label6.Text = SessionHelper.gender;
            }
            else
            {
                Label6.Text = "No option selected.";
            }
            if (SessionHelper.education != null)
            {
                Label8.Text = SessionHelper.education;
            }
            else
            {
                Label8.Text = "No option selected.";
            }
*/
            var ds = new DataSet();
            var connectionString = SqlHelper.GetConnectionString();
            using (var connection = new SqlConnection(connectionString))

            {
                connection.Open();
                var cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from [dbo].[StudentData]";
                cmd.CommandType = System.Data.CommandType.Text;
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                    cmd.Parameters.Clear();
                    connection.Close();
                }

            }
            GridView1.DataSource = ds;
            this.Page.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("signin.aspx");
        }
    }
}