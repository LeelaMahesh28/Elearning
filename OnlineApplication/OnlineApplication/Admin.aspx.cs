using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineApplication
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Login(object sender, EventArgs e)
        {
            if(TextAdmin.Text=="admin"&& TextPassword.Text=="admin123")
            {
                Label1.Text = "Logged in Successfully";
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Label1.Text = "Invalid Credentials";
            }
        }
    }
}