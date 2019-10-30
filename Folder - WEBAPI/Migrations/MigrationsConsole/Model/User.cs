using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MigrationsConsole.Model
{
    public class User : UserControl
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CampoNovo { get; set; }

        public Level Level { get; set; } = Level.User;

    }
}