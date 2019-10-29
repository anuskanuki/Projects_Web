namespace ListingPeople.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PeopleContext : DbContext
    {
        // Your context has been configured to use a 'PeopleContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ListingPeople.Models.PeopleContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PeopleContext' 
        // connection string in the application configuration file.
        public PeopleContext()
            : base("name=PeopleContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<People> Peoples { get; set; }
    }

  
}