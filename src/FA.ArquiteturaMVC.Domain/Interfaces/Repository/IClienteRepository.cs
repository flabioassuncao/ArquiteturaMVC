using FA.ArquiteturaMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.ArquiteturaMVC.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
    }
}
