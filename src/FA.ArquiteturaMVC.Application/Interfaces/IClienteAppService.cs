using FA.ArquiteturaMVC.Application.ViewModels;
using FA.ArquiteturaMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.ArquiteturaMVC.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel ObterPorCPF(string cpf);
        ClienteViewModel ObterPorEmail(string email);

        void Adicionar(ClienteEnderecoViewModel cliente);
        ClienteViewModel ObterPorId(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        void Atualizar(ClienteViewModel cliente);
        void Remover(Guid id);
    }
}
