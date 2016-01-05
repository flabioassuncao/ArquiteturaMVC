using FA.ArquiteturaMVC.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FA.ArquiteturaMVC.Domain.Interfaces.Service
{
    public interface IClienteService : IDisposable
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
        void Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}
