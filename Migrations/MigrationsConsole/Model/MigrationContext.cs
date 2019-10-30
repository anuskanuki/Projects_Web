using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MigrationsConsole.Model
{
    public class MigrationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}