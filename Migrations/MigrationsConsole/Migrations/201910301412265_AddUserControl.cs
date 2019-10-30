namespace MigrationsConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserControl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "UserCreation", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "UserAlteration", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "AlterationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AlterationDate");
            DropColumn("dbo.Users", "CreationDate");
            DropColumn("dbo.Users", "UserAlteration");
            DropColumn("dbo.Users", "UserCreation");
            DropColumn("dbo.Users", "Active");
        }
    }
}
