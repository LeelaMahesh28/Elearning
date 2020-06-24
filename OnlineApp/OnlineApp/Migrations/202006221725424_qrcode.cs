namespace OnlineApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qrcode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QRCodeModels",
                c => new
                    {
                        QRCodeText = c.String(nullable: false, maxLength: 128),
                        QRCodeImagePath = c.String(),
                    })
                .PrimaryKey(t => t.QRCodeText);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QRCodeModels");
        }
    }
}
