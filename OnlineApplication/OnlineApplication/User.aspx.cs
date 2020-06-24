using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineApplication
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");
        protected void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = TextUser.Text;
                string pass = TextPassword.Text;
                con.Open();
                string qry = "select * from USERS where username ='" + uid + "' and userpassword='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Label1.Text = "Login Sucess......!!";
                    Response.Redirect("Courses.aspx");
                }
                else
                {
                    Label1.Text = "UserId & Password Is not correct Try again..!!";
                    

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Enter_Reg(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Enter_Forgpass(object sender, EventArgs e)
        {
            Response.Redirect("Forgps.aspx");
        }
    }
}