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
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string sql = "SELECT * from Users";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * from Admin";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView2.DataSource = reader;
            GridView2.DataBind();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * from Details";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView3.DataSource = reader;
            GridView3.DataBind();
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}