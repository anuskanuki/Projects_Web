namespace PropertiesSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PropertiesSystem.Models.PropretiesContextDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PropertiesSystem.Models.PropretiesContextDb";
        }

        protected override void Seed(PropertiesSystem.Models.PropretiesContextDb context)
        {

            context.Owners.AddOrUpdate(x => x.Name, new Models.Owner()
            {
                Name = "Anuska",
                Email = "anuska.rehn@gmail.com"
            });

        }
    }
}
