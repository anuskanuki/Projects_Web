namespace MigrationsConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoNovo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CampoNovo", c => c.String());
            DropColumn("dbo.Users", "Cpf");
            DropColumn("dbo.Users", "DarMortal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DarMortal", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Cpf", c => c.String());
            DropColumn("dbo.Users", "CampoNovo");
        }
    }
}
