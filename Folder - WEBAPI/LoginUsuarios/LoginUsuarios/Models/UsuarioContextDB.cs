using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LoginUsuarios.Models
{
    public class UsuarioContextDB : DbContext
    {
        public UsuarioContextDB(DbConfiguration<>)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
