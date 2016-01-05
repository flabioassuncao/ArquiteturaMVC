using FA.ArquiteturaMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using FA.ArquiteturaMVC.Domain.Entities;
using FA.ArquiteturaMVC.Application.ViewModels;
using AutoMapper;
using FA.ArquiteturaMVC.Domain.Interfaces.Service;

namespace FA.ArquiteturaMVC.Application
{
    //ctrl+. em cima do IclienteAppService e cria os metodos

    public class ClienteAppService : AppService, IClienteAppService
    {
        //Antes de implementar os metodos deve ser criada a pasta AutoMapper

        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        private static ClienteViewModel ClienteToViewModel(Cliente cliente)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(cliente);
        }

        private static Cliente ViewModelToCliente(ClienteViewModel clienteViewModel)
        {
            return Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
        }



        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return ClienteToViewModel(_clienteService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return ClienteToViewModel(_clienteService.ObterPorEmail(email));
        }

        public void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            _clienteService.Adicionar(cliente);
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            //return ClienteToViewModel(_clienteRepository.ObterPorId(id));

            //Exemplo usando Dapper
            return ClienteToViewModel(_clienteService.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.ObterTodos());
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            _clienteService.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel));
        }

        public void Remover(Guid id)
        {
            _clienteService.Remover(id);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
