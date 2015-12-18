using FA.ArquiteturaMVC.Domain.Entities;
using FA.ArquiteturaMVC.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.ArquiteturaMVC.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }
    }
}
