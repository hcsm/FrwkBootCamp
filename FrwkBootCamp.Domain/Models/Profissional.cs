using System;
using System.Collections.Generic;

namespace FrameBook.Domain.Models
{
    public class Profissional : BaseEntity
    {
        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
