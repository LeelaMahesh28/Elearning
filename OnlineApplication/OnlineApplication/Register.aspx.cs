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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        protected void Enter_Signup(object sender, EventArgs e)
        {
            cmd.Connection = con;
           
            cmd.CommandText = "Insert into Users values (@userid,@username,@userpassword)";
            cmd.Parameters.AddWithValue("@userid", TextId.Text);
            cmd.Parameters.AddWithValue("@username", TextUser.Text);
            cmd.Parameters.AddWithValue("@userpassword", TextPassword.Text);
            
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Succesfully Registered";
        }

        protected void Enter_Back(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }
    }
}