using System;
using System.Collections.Generic;

namespace FA.ArquiteturaMVC.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteID = Guid.NewGuid();
            Enderecos = new List<Endereco>();
        }
        
        public Guid ClienteID  { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}