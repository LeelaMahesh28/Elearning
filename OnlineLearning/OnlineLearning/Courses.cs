using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OnlineLearning
{
    //Declaring variables
    public class Courses
    {
        private int _courseid;
        private string _coursename;
        private string _coursedepartment;
        private string _professorname;
        private int cid;
        private string cname;
        private string cdept;
        public Courses(int courseid, string coursename, string coursedepartment, string professorname)
        {
            this._courseid = courseid;
            this._coursename = coursename;
            this._coursedepartment = coursedepartment;
            this._professorname = professorname;
        }

        public Courses()
        { }

        public string Courses(int v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }

        SqlConnection con = null;
        SqlCommand cmd = null;
        
        

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }


        public Boolean Coursedetails()
        {
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select* from COURSES";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine("Cid" + "   " + "CName" + "    " + "Cdept" + "     " + "ProfName");
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + "   " + rdr[1] + "    " + rdr[2]+"     "+rdr[3]);
                sucessFlag = true;

            }
            return sucessFlag;
        }
            /*public string Courses(int v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }*/

        public int Courseid
        {
            get { return this._courseid; }
            set { this._courseid = value; }
        }

        public string Coursename
        {
            get { return this._coursename; }
            set { this._coursename = value; }
        }
        public string Coursedepartment
        {
            get { return this._coursedepartment; }
            set { this._coursedepartment = value; }
        }
        public string professorname
        {
            get { return this._professorname; }
            set { this._professorname = value; }
        }
        public override string ToString()
        {
            string Coursedetails = null;
            foreach (var s in _coursename)
            {
                Coursedetails = Coursedetails + s.ToString();

            }

            return string.Format(this._courseid + " " + this._coursename + " " + this._coursedepartment + " " + this._professorname);
        }
        public Boolean SearchCourse()
        {
            //Register the course
            Dictionary<int, Courses> cdetails = new Dictionary<int, Courses>();
            {
                cdetails.Add(101, new Courses(Courseid = 101, Coursename = "Azure", Coursedepartment = "Cloud", professorname = "Ravi"));
                cdetails.Add(201, new Courses(Courseid = 201, Coursename = "Neural Networks", Coursedepartment = "ML", professorname = "Bala"));
                cdetails.Add(301, new Courses(Courseid = 301, Coursename = "DS", Coursedepartment = "C", professorname = "Geetha"));
            }
            Console.WriteLine("Enter the user id");
              int usid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the user Name");
             string usname = Console.ReadLine();
            Console.WriteLine("Enter the course id");
            cid = Convert.ToInt32(Console.ReadLine());
            if (cid == 101)
            {
                Console.WriteLine(cdetails[101]);
                cname = "Azure";
                cdept = "Cloud";
                Console.WriteLine("Registered successfully");

            }
            else if (cid == 201)
            {
                Console.WriteLine(cdetails[201]);
                cname = "Neural Networks";
                cdept = "ML";
                Console.WriteLine("Registered successfully");

            }
            else if (cid == 301)
            {
                Console.WriteLine(cdetails[301]);
                cname = "DS";
                cdept = "C";
                Console.WriteLine("Registered successfully");

            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Boolean sucessFlag = false;

            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO ADMIN(userid,username,usercourse,coursedept) VALUES(@usid,@usname,@cname,@cdept);";
            cmd.Parameters.AddWithValue("@usid", usid);
            cmd.Parameters.AddWithValue("@usname", usname);
            cmd.Parameters.AddWithValue("@cname", cname);
            cmd.Parameters.AddWithValue("@cdept", cdept);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {

                sucessFlag = true;
                return sucessFlag;
            }
            return sucessFlag;

        }
        



    }


        

    }

