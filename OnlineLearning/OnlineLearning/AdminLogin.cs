using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OnlineLearning
{
    public class AdminLogin
    {
        //Declaring variables
        private int _userid;
        private string _username;
        private string _usercourse;
        private string _department;
        //public string userrname = "srii";
        public AdminLogin(int userid, string username, string usercourse, string department)
        {
            this._userid = userid;
            this._username = username;
            this._usercourse = usercourse;
            this._department = department;
        }
        public AdminLogin()
        {

        }
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }

        public string AdminLogin(int v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            //Admin login
            Console.WriteLine("Enter Admin name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter passcode");
            string password = Console.ReadLine();
            if (username == "admin" && password == "admin123")
            {
                Console.WriteLine("Logged in Successfully");
                
            }
            else
            {
                Console.WriteLine("Invalid Credentials");
                AdminLogin sd = new AdminLogin();
                sd.Login();

            }

        }
        public Boolean userdetails()
        {
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from ADMIN";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("UId" + "   " + "Username" + "    " + "Coursename" + "    " + "CourseDept");
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + "   " + rdr[1] + "    " + rdr[2]+"    "+rdr[3]);
                sucessFlag = true;

            }
            return sucessFlag;
        }
        public Boolean PayDetails()

        {
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from DETAILS";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("UId" + "   " + "CId" + "    " + "PayStatus" + "    " + "ScheduleDate");
            while (rdr.Read())
            {

                Console.WriteLine(rdr[0] + "   " + rdr[1] + "    " + rdr[2] + "    " + rdr[3]);
                sucessFlag = true;

            }
            return sucessFlag;
        }
        public Object DeleteUser()
        {
            Console.WriteLine("Enter the user Id to be deleted");
            int urid = Convert.ToInt32(Console.ReadLine());
            Boolean successflag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE USERS WHERE userid = @urid;";
            cmd.Parameters.AddWithValue("@urid", urid);

            con.Open();

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                successflag = true;
                return successflag;

            }
            
            return successflag;
        }
        public int Userid
        {
            get { return this._userid; }
            set { this._userid = value; }
        }

        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }
        public string Usercourse
        {
            get { return this._usercourse; }
            set { this._usercourse = value; }
        }

        public string Department
        {
            get { return this._department; }
            set { this._department = value; }

        }
        public override string ToString()
        {
            string userdetails = null;
            foreach (var s in _username)
            {
                userdetails = userdetails + s.ToString();

            }

            return string.Format(this._userid + " " + this._username + " " + this._usercourse + " " + this._department);

        }
    }
}

