namespace OnlineApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                {
                    CourseId = c.Int(nullable: false, identity: true),
                    CourseName = c.String(),
                    CourseDept = c.String(),
                   ProfName = c.String(),
                })
                .PrimaryKey(t => t.CourseId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
