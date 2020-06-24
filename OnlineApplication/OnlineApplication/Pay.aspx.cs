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
    public partial class Pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string status;
        SqlConnection con = new SqlConnection(@"Data Source=10.0.1.7;Initial Catalog=OnlineLearning;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextCsId.Text=="101")
            {
                Label1.Text = "Amount to pay is 400";
                status = "paid";
                Label3.Text = "Paid successful";
            }
            else if (TextCsId.Text == "201")
            {
                Label1.Text = "Amount to pay is 450";
                status = "paid";
                Label3.Text = "Paid successful";
            }
            else if (TextCsId.Text == "301")
            {
                Label1.Text = "Amount to pay is 300";
                status = "paid";
                Label3.Text = "Paid successful";
            }
            else 
            {
                Label1.Text = "Invalid Course Id";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            status = "paid";
            cmd.Connection = con;
               
                cmd.CommandText = "INSERT INTO DETAILS values(@userid, @courseid, @paymentstatus, @scheduleddate); ";
                cmd.Parameters.AddWithValue("@userid", TextUsid.Text);
                cmd.Parameters.AddWithValue("@courseid", TextCsId.Text);
                cmd.Parameters.AddWithValue("@paymentstatus", @status);
                cmd.Parameters.AddWithValue("@scheduleddate", TextBox1.Text);
                
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                Label4.Text = "Exam Date scheduled successful";

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses.aspx");
        }
    }
}