
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OnlineLearning
{
    public class Payment
    {
        //Declaring variables
        private int _cid;
        private string _totamnt;
        private string will;
        public string status;
        public DateTime date;

        public Payment(int cid, string totamnt)
        {
            this._cid = cid;
            this._totamnt = totamnt;
        }

        public Payment()
        { }
        SqlConnection con = null;
        SqlCommand cmd = null;
        

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["online"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public int Cid
        {
            get { return this._cid; }
            set { this._cid = value; }
        }

        public string Payment(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        public string TotAmnt
        {
            get { return this._totamnt; }
            set { this._totamnt = value; }
        }

        /*public string Payment(int v1, string v2)
        {
            throw new NotImplementedException();
        }*/

        
        public object UserId { get; private set; }
        public int CoId { get; private set; }
        public object Uid { get; private set; }

        public override string ToString()
        {

            string Pay = null;
            foreach (var s in _totamnt)
            {
                Pay = Pay + s.ToString();

            }

            return string.Format(this._cid + " " + this._totamnt + "");
        }
        public Boolean Pay()
        {
            //Payment for the course
            Dictionary<int, int> pay = new Dictionary<int, int>();
            pay.Add(101, 400);
            pay.Add(201, 450);
            pay.Add(301, 300);

            Console.WriteLine("Enter the UserId");
            UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Course Id");
            CoId = Convert.ToInt32(Console.ReadLine());
            if (CoId == 101)
            {
                Console.WriteLine("Amount to pay is " + pay[101]);
                Console.WriteLine("Type yes to pay and no to exit " + pay[101]);
                will = Console.ReadLine();
                if (will == "yes")
                {
                    Console.WriteLine("Paid successfull");
                    status = "paid";
                }
                else
                {
                    Console.WriteLine("Payment Cancelled");
                }
            }
            else if (CoId == 201)
            {
                Console.WriteLine("Amount to pay is " + pay[201]);
                Console.WriteLine("Type yes to pay and no to exit " + pay[101]);
                will = Console.ReadLine();
                if (will == "yes")
                {
                    Console.WriteLine("Paid successfull");
                    status = "paid";
                }
                else
                {
                    Console.WriteLine("Payment Cancelled");
                    status = "not paid";

                }
            }
            else if (CoId == 301)
            {
                Console.WriteLine("Amount to pay is " + pay[301]);
                Console.WriteLine("Type yes to pay and no to exit " + pay[101]);
                will = Console.ReadLine();
                if (will == "yes")
                {
                    Console.WriteLine("Paid successfull");
                    status = "paid";
                }
                else
                {
                    Console.WriteLine("Payment Cancelled");
                }
            }
            Console.WriteLine("To Schedule your test:\nEnter yes or no");
            string r = Console.ReadLine();
            {
                if (r == "yes")
                {
                    if (status == "paid")
                    {
                        Console.WriteLine("Schedule your exam " + UserId + "for your course " + CoId);
                        Console.WriteLine("Enter a date\nIn the format:MM/DD/YYYY\n");
                        DateTime a = Convert.ToDateTime(Console.ReadLine());
                        DateTime b = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        TimeSpan elapsed = b.Subtract(a);
                        double daysAgo = elapsed.TotalDays;

                        if (daysAgo < 0)
                        {
                            Console.WriteLine("User " + UserId + "you can take your exam on " + a);
                            date = a;
                        }
                        else
                        {
                            Console.WriteLine("Cannot schedule for previous days ->" + a);
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pay to schedule test");
                        
                    }
                    }
                    else
                    {
                        Console.WriteLine("Schedule test later");
                    }
                }
            Boolean sucessFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO DETAILS(userid,courseid,paymentstatus,scheduleddate) VALUES(@UserId,@CoId,@status,@date);";
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@CoId", CoId);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@date", date);
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
    

