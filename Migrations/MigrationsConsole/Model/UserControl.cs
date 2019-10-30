using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsConsole.Model
{
    public class UserControl
    {

        public bool Active { get; set; } = true;
        public int UserCreation { get; set; } = 0;
        public int UserAlteration { get; set; } = 0;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime AlterationDate { get; set; } = DateTime.Now;




    }
}
