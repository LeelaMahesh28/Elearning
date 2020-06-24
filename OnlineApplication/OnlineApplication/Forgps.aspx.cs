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
    public partial class Forgps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");
        
        protected void Enter_Reset(object sender, EventArgs e)
        {
           
                con.Open();
                
                SqlCommand cmd = new SqlCommand("update users Set userpassword=@userpassword where userid=@userid ", con);  
                cmd.Parameters.AddWithValue("@userid", TextId.Text);
                cmd.Parameters.AddWithValue("@userpassword", TextPassword.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            Label1.Text="Password changed Successfully......!";
                con.Close();
            }
        }
    }
