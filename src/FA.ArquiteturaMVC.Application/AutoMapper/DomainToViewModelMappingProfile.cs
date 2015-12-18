using AutoMapper;
using FA.ArquiteturaMVC.Application.ViewModels;
using FA.ArquiteturaMVC.Domain.Entities;

namespace FA.ArquiteturaMVC.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}
