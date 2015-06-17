namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StatCategory", "id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.StatCategory", new[] { "StatCatId" });
            AddPrimaryKey("dbo.StatCategory", "id");
            DropColumn("dbo.StatCategory", "StatCatId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StatCategory", "StatCatId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.StatCategory", new[] { "id" });
            AddPrimaryKey("dbo.StatCategory", "StatCatId");
            DropColumn("dbo.StatCategory", "id");
        }
    }
}
