namespace PropertyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterUserTanle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CompanyId", c => c.Guid(nullable: false));
            AddColumn("dbo.AspNetUsers", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Status");
            DropColumn("dbo.AspNetUsers", "CompanyId");
        }
    }
}
