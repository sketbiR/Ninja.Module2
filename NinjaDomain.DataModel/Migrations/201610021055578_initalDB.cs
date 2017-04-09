namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ASPNET_CUSTOM.Clans",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        ClanName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ASPNET_CUSTOM.Ninjas",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 500),
                        ServedInOniwabanValue = c.Decimal(nullable: false, precision: 10, scale: 0),
                        DateOfBirth = c.DateTime(nullable: false),
                        ClanId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ASPNET_CUSTOM.Clans", t => t.ClanId, cascadeDelete: true)
                .Index(t => t.ClanId);
            
            CreateTable(
                "ASPNET_CUSTOM.NinjaEquipments",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 500),
                        Type = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Ninja_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ASPNET_CUSTOM.Ninjas", t => t.Ninja_Id, cascadeDelete: true)
                .Index(t => t.Ninja_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ASPNET_CUSTOM.NinjaEquipments", "Ninja_Id", "ASPNET_CUSTOM.Ninjas");
            DropForeignKey("ASPNET_CUSTOM.Ninjas", "ClanId", "ASPNET_CUSTOM.Clans");
            DropIndex("ASPNET_CUSTOM.NinjaEquipments", new[] { "Ninja_Id" });
            DropIndex("ASPNET_CUSTOM.Ninjas", new[] { "ClanId" });
            DropTable("ASPNET_CUSTOM.NinjaEquipments");
            DropTable("ASPNET_CUSTOM.Ninjas");
            DropTable("ASPNET_CUSTOM.Clans");
        }
    }
}
