using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroImoveis.Model
{
    public class BibliotecaContextDB : DbContext
    {
        public BibliotecaContextDB(DbContextOptions<BibliotecaContextDB> options) : base (options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
    }
}
