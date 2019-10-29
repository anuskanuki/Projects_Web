using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CorreiosWebApi.Models
{
    public class EnderecoContextDB : DbContext
    {
        public DbSet<Endereco> Enderecos { get; set; }
    }
}