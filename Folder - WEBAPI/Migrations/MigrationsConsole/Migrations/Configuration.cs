namespace MigrationsConsole.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MigrationsConsole.Model.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MigrationsConsole.Model.MigrationContext";
        }

        protected override void Seed(MigrationsConsole.Model.MigrationContext context)
        {
            context.Users.AddOrUpdate(x => x.Name, new Model.User()
            {
                Name = "Anuska",
                Login = "nuki",
                Password = "123",
                Email = "nuki@me.com",
                Level = Model.Level.Admin
            });
        }
    }
}
