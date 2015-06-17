namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NflStat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        statNum = c.Int(nullable: false),
                        statValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PlayerBackground",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        height = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        dob = c.DateTime(nullable: false),
                        college = c.String(),
                        highSchool = c.String(),
                        draftYear = c.Int(nullable: false),
                        picUrl = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Stat");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        statNum = c.Int(nullable: false),
                        statValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.PlayerBackground");
            DropTable("dbo.NflStat");
        }
    }
}
