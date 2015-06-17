namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Player", "playerStats_statId", "dbo.Stat");
            DropIndex("dbo.Player", new[] { "playerStats_statId" });
            CreateTable(
                "dbo.StatCategory",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        abbr = c.String(),
                        name = c.String(),
                        shortName = c.String(),
                    })
                .PrimaryKey(t => t.id);

            DropPrimaryKey("dbo.Stat", new[] { "statId" });
            DropColumn("dbo.Stat", "statId");

            AddColumn("dbo.Stat", "id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Stat", "statNum", c => c.Int(nullable: false));
            
            AddPrimaryKey("dbo.Stat", "id");
            DropColumn("dbo.Player", "playerStats_statId");
            
            DropColumn("dbo.Stat", "playerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stat", "playerId", c => c.Int(nullable: false));
            AddColumn("dbo.Stat", "statId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Player", "playerStats_statId", c => c.Int());
            DropPrimaryKey("dbo.Stat", new[] { "id" });
            AddPrimaryKey("dbo.Stat", "statId");
            DropColumn("dbo.Stat", "statNum");
            DropColumn("dbo.Stat", "id");
            DropTable("dbo.StatCategory");
            CreateIndex("dbo.Player", "playerStats_statId");
            AddForeignKey("dbo.Player", "playerStats_statId", "dbo.Stat", "statId");
        }
    }
}
