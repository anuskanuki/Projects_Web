namespace MigrationsConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCPFUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Cpf", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Cpf");
        }
    }
}
