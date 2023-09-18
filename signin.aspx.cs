using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var SName = TextBox1.Text;
            var SPassword =TextBox2.Text;
            var connectionString = SqlHelper.GetConnectionString();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

              
                string query = "SELECT COUNT(*) FROM StudentData WHERE StudentName = @Name AND Password = @Password";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", SName);
                    cmd.Parameters.AddWithValue("@Password", SPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        Label3.Text = "User Found";
                        Response.Redirect("page3.aspx"); 
                    }
                    else
                    {
                        Label3.Text = "First You Need To Register";
                        //Response.Redirect("login.aspx");
                    }
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label4.Text = "LOGGED OUT";
        }
    }
}