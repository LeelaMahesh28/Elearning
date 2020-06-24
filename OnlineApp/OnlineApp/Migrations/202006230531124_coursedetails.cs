namespace OnlineApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coursedetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseDetails",
                c => new
                {
                    RegId = c.Int(nullable: false, identity: true),
                    Usid = c.Int(nullable: false),
                    Coid = c.Int(nullable: false),
                    CoName = c.String(),
                    CoDept = c.String(),
                })
                .PrimaryKey(t => t.RegId);
        }
        
        public override void Down()
        {
            DropTable("dbo.CourseDetails");
        }
    }
}
