using BL;
using DataModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using smw_serviceDL;


namespace project
{
    public partial class login : System.Web.UI.Page
    {

        BussinessService bl = new BussinessService();
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserRegistrationDetails userInfo = new UserRegistrationDetails();
            userInfo.Name = name.Text;
            userInfo.Email = mail.Text;
            userInfo.Password = setpassword.Text;
            userInfo.Edu =edu.SelectedValue;
            userInfo.gender =gender.SelectedValue;
            userInfo.ImageName =   SessionHelper.name + Path.GetExtension(image.FileName);
            userInfo.ImagePath = ".//upload" + SessionHelper.name;



            var res = bl.RegisterUser(userInfo);

            if (res.Status)
            {
                Response.Redirect("page3.aspx");
            }
            else
            {
                Response.Write(res.Msg);
            }


        }
        static bool IsValidEmail(string email)
        {

            string pattern = @"^[a-zA-Z._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$";


            Regex regex = new Regex(pattern);


            return regex.IsMatch(email);
        }

        protected void name_TextChanged(object sender, EventArgs e)
        {

        }


        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void imgupload_Click(object sender, EventArgs e)
        {
            SessionHelper.name = name.Text;

            if (image.HasFile)
            {

                string path = Server.MapPath("~/upload/");



                string fileName = Path.GetFileName(image.FileName);
                string newfileName = (string)SessionHelper.name + Path.GetExtension(fileName); ;


                image.SaveAs(Path.Combine(path, newfileName));


                Label11.Text = "File upload succesfully.";
            }
            else
            {

                Label11.Text = "Please select a file to upload.";
            }
        }

        protected void setpassword_TextChanged(object sender, EventArgs e)
        {


        }

        protected void confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}