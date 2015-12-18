using AutoMapper;
using FA.ArquiteturaMVC.Application.ViewModels;
using FA.ArquiteturaMVC.Domain.Entities;

namespace FA.ArquiteturaMVC.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
        }
    }
}
