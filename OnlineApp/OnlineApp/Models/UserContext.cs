using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("onlinee") { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseDetails> CourseDetails { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<PayDetail> PayDetails { get; set; }
        public DbSet<QRCodeModel> QrCodeModels { get; set; }

    }
}
