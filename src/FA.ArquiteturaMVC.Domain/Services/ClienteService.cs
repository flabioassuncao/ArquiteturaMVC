using FA.ArquiteturaMVC.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using FA.ArquiteturaMVC.Domain.Entities;
using FA.ArquiteturaMVC.Domain.Interfaces.Repository;

namespace FA.ArquiteturaMVC.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _clienteRepository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorIdReadOnly(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }
    }
}
