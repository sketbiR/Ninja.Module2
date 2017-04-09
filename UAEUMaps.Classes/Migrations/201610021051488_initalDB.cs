namespace UAEUMaps.Classes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initalDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "ASPNET_CUSTOM.CATEGORY", newName: "Categories");
            RenameTable(name: "ASPNET_CUSTOM.MARKER", newName: "Markers");
            RenameTable(name: "ASPNET_CUSTOM.ACCESSLIST", newName: "AccessLists");
        }
        
        public override void Down()
        {
            RenameTable(name: "ASPNET_CUSTOM.AccessLists", newName: "ACCESSLIST");
            RenameTable(name: "ASPNET_CUSTOM.Markers", newName: "MARKER");
            RenameTable(name: "ASPNET_CUSTOM.Categories", newName: "CATEGORY");
        }
    }
}
