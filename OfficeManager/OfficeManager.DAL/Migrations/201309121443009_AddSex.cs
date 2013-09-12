namespace OfficeManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSex : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Sex");
        }
    }
}
