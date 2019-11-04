using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroImoveis.Model
{
    public class Proprietario
    {
        [Key]
        public int Id{ get; set; }

        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}
