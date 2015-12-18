using FA.ArquiteturaMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FA.ArquiteturaMVC.Domain.Entities;
using FA.ArquiteturaMVC.Application.ViewModels;
using FA.ArquiteturaMVC.Infra.Data.Repositories;
using AutoMapper;

namespace FA.ArquiteturaMVC.Application
{
    //ctrl+. em cima do IclienteAppService e cria os metodos

    public class ClienteAppService : IClienteAppService
    {
        //Antes de implementar os metodos deve ser criada a pasta AutoMapper

        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

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
            return ClienteToViewModel(_clienteRepository.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return ClienteToViewModel(_clienteRepository.ObterPorEmail(email));
        }

        public void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            _clienteRepository.Adicionar(cliente);
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return ClienteToViewModel(_clienteRepository.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos());
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            _clienteRepository.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel));
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
