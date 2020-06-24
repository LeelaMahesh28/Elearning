using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineApplication
{
    public partial class RegCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private string cname;
        private string cdept;

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextCid.Text=="101")
            {
                 cname = "Azure";
                 cdept = "Cloud";
            }
            else if (TextCid.Text == "201")
            {
                cname = "Neutral Networks";
                 cdept = "ML";
            }
            else if (TextCid.Text == "301")
            {
                 cname = "DS";
                 cdept = "C";
            }
            else
            {
                Label1.Text = "Invalid Course Id";
            }
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO ADMIN values(@userid,@username,@usercourse,@coursedept) ;";
            cmd.Parameters.AddWithValue("@userid", TextUid.Text);
            cmd.Parameters.AddWithValue("@username", TextName.Text);
            cmd.Parameters.AddWithValue("@usercourse", cname);
            cmd.Parameters.AddWithValue("@coursedept", cdept);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            Label2.Text = "Course registered successfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses.aspx");
        }
    }
}