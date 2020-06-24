namespace OnlineApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paydetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayDetails",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Uid = c.Int(nullable: false),
                        Cid = c.Int(nullable: false),
                        Status = c.String(),
                        ScheduleDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PayDetails");
        }
    }
}
