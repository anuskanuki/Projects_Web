using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigrationsConsole.Model;

namespace MigrationsConsole
{
    class Program
    {
        static MigrationContext db = new MigrationContext();

        static void Main(string[] args)
        {
            db.Users.ToList().ForEach(p => Console.WriteLine(p.Name));//initializing our database
            Console.ReadKey();
        }




    }
}
