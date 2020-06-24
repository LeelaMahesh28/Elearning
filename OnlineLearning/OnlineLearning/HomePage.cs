using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearning
{
    class HomePage
    {

        public void Startup()
        {
            Console.WriteLine("SELECT\n1 for Admin\n2 for Existing User\n3 for New User\n4 Exit");
            char c;
            Console.WriteLine("Enter your choice");
            c = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(c))
            {
                case '1':
                    Console.WriteLine("Welcome Admin");
                    AdminLogin name = new AdminLogin();
                    name.Login();
                    HomePage q = new HomePage();
                    q.AdminSwitch();
                    break;

                case '2':
                    Console.WriteLine("Welcome User");
                    User user = new User();
                    user.UserLogin();
                    HomePage s = new HomePage();
                    s.UserSwitch();
                    break;

                case '3':
                    Console.WriteLine("Welcome User");
                    User ur = new User();
                    ur.InsertUser();
                    break;

                case '4':
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
            }

            HomePage n = new HomePage();
            n.Startup();

        }
        public void UserSwitch()
        {
            Console.WriteLine("SELECT\n1 View the course details\n2 Register the course\n3 Pay for the course\n4 Mainmenu\n5.Exit");
            char c;
            Console.WriteLine("Enter your choice");
            c = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(c))
            {
                case '1':
                    Courses co = new Courses();
                    co.Coursedetails();
                    break;

                case '2':
                    Courses course = new Courses();
                    course.SearchCourse();
                    
                    break;

                case '3':
                    Payment payment = new Payment();
                    payment.Pay();
                    break;

                case '4':
                    HomePage t = new HomePage();
                    t.Startup();
                    break;

                case '5':
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            HomePage q = new HomePage();
            q.UserSwitch();
        }
        public void AdminSwitch()
        {
            Console.WriteLine("SELECT\n1 View the user details\n2 View the user registered course\n3 Paid details of the user\n4 Delete the user\n5 Mainmenu\n6 Exit");
            char c;
            Console.WriteLine("Enter your choice");
            c = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(c))
            {
                case '1':
                    Console.WriteLine("USER DETAILS");
                    User us = new User();
                    us.ReadUser();
                    break;

                case '2':
                    Console.WriteLine("USER REGISTERED COURSE DETAILS");
                    AdminLogin sq = new AdminLogin();
                    sq.userdetails();
                    break;

                case '3':
                    Console.WriteLine("USER--> PAYMENT DETAILS");
                    AdminLogin sqr = new AdminLogin();
                    sqr.PayDetails();
                    break;

                case '4':
                    AdminLogin aq = new AdminLogin();
                    aq.DeleteUser();
                    break;

                case '5':
                    HomePage t = new HomePage();
                    t.Startup();
                    break;

                case '6':
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            HomePage q = new HomePage();
            q.AdminSwitch();
        }

    }
}
