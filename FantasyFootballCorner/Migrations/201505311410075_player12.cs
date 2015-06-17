namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        teamAbbre = c.String(nullable: false, maxLength: 128),
                        geoName = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.teamAbbre);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Team");
        }
    }
}
