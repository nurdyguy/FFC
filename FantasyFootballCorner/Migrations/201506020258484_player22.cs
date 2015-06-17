namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StatCategory", "abbr", c => c.String());
            AddColumn("dbo.StatCategory", "name", c => c.String());
            AddColumn("dbo.StatCategory", "shortName", c => c.String());
            AddColumn("dbo.StatCategory", "isQBStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isRBStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isWRStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isTEStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isKStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isDEFStat", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StatCategory", "isDEFStat");
            DropColumn("dbo.StatCategory", "isKStat");
            DropColumn("dbo.StatCategory", "isTEStat");
            DropColumn("dbo.StatCategory", "isWRStat");
            DropColumn("dbo.StatCategory", "isRBStat");
            DropColumn("dbo.StatCategory", "isQBStat");
            DropColumn("dbo.StatCategory", "shortName");
            DropColumn("dbo.StatCategory", "name");
            DropColumn("dbo.StatCategory", "abbr");
        }
    }
}
