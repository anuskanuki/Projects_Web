namespace MigrationsConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioDarMortal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DarMortal", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DarMortal");
        }
    }
}
