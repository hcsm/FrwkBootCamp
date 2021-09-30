using System;

namespace FrwkBootCamp.Domain.Models
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
