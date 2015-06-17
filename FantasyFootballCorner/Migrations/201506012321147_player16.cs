namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StatCategory", "isQBStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isRBStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isWRStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isTEStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isKStat", c => c.Boolean(nullable: false));
            AddColumn("dbo.StatCategory", "isDEFStat", c => c.Boolean(nullable: false));
            AlterColumn("dbo.StatCategory", "id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StatCategory", "id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.StatCategory", "isDEFStat");
            DropColumn("dbo.StatCategory", "isKStat");
            DropColumn("dbo.StatCategory", "isTEStat");
            DropColumn("dbo.StatCategory", "isWRStat");
            DropColumn("dbo.StatCategory", "isRBStat");
            DropColumn("dbo.StatCategory", "isQBStat");
        }
    }
}
