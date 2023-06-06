namespace PropertyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cft1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Adress = c.String(),
                        Guid = c.Guid(nullable: false),
                        Status = c.Int(nullable: false),
                        Logo = c.String(),
                        Country = c.String(),
                        UserId = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Guid = c.Guid(nullable: false),
                        FullName = c.String(),
                        IdentityID = c.Int(nullable: false),
                        Phone1 = c.Int(nullable: false),
                        Phone2 = c.Int(nullable: false),
                        Email = c.String(),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RealEstateKinds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArName = c.String(),
                        EngName = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RealEstates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FREKId = c.Int(nullable: false),
                        Guid = c.Guid(nullable: false),
                        CoGuid = c.Guid(nullable: false),
                        UnitCount = c.Int(nullable: false),
                        Location = c.String(),
                        Code = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentKinds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArName = c.String(),
                        EngName = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnitKinds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArName = c.String(),
                        EngName = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FUnitKindId = c.Int(nullable: false),
                        Guid = c.Guid(nullable: false),
                        FRealEstGuid = c.Guid(nullable: false),
                        NickName = c.String(),
                        AreaSize = c.Single(nullable: false),
                        Room = c.String(),
                        Bathroom = c.String(),
                        Kitchen = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Units");
            DropTable("dbo.UnitKinds");
            DropTable("dbo.RentKinds");
            DropTable("dbo.RealEstates");
            DropTable("dbo.RealEstateKinds");
            DropTable("dbo.Owners");
            DropTable("dbo.Companies");
        }
    }
}
