namespace PropertyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exp : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CompanyId");
            DropColumn("dbo.AspNetUsers", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "CompanyId", c => c.Guid(nullable: false));
        }
    }
}
