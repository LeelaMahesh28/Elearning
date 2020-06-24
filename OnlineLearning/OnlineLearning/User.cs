using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineLearning
{
    public class User
    {
        //Declaring variables
        private int _userid;
        private string _username;
        private string _userpassword;
       

        public User(int userid, string username, string userpassword)
        {
            this._userid = userid;
            this._username = username;
            this._userpassword = userpassword;
        }

        public User()
        { }
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }

        public string User(int v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void UserLogin()
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter passcode");
            string password = Console.ReadLine();
           
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select count(*) from USERS where username=@username and userpassword=@password;";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            con.Open();
            int count = (Int32)cmd.ExecuteScalar();
            if (count==1)
            {
                Console.WriteLine("Logged in Successfully");
            }
           else
            {
                Console.WriteLine("Invalid Credentials");
                User sw = new User();
                sw.UserLogin();
            }
        }
       

        public Boolean ReadUser()
        {
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from USERS";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("UId" + "   " + "Name" + "    " + "Password");
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + "   " + rdr[1] + "    " + rdr[2]);
                sucessFlag = true;

            }
            return sucessFlag;
        }

        public Boolean InsertUser()
        {
            Console.WriteLine("Enter the UserId");
            int UId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the UserName");
            string Uname = Console.ReadLine();
            Console.WriteLine("Enter the UserPassword");
            string Upass = Console.ReadLine();
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO USERS(UserID,UserName,UserPassword) VALUES(@UId,@Uname,@Upass);";
            cmd.Parameters.AddWithValue("@UId", UId);
            cmd.Parameters.AddWithValue("@Uname", Uname);
            cmd.Parameters.AddWithValue("@Upass", Upass);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {

                sucessFlag = true;
                return sucessFlag;
            }
            return sucessFlag;
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
        public string Userpassword
        {
            get { return this._userpassword; }
            set { this._userpassword = value; }
        }

        public override string ToString()
        {
            string userdetails = null;
            foreach (var s in _username)
            {
                userdetails = userdetails + s.ToString();

            }

            return string.Format(this._userid + " " + this._username + " " + this._userpassword);

        }
        
    }
}

