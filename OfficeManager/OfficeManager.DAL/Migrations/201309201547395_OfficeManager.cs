namespace OfficeManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficeManager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        LoginId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Logins", t => t.LoginId, cascadeDelete: true)
                .Index(t => t.LoginId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        LoginId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Create = c.DateTime(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LoginId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "LoginId" });
            DropForeignKey("dbo.Users", "LoginId", "dbo.Logins");
            DropTable("dbo.Logins");
            DropTable("dbo.Users");
        }
    }
}
