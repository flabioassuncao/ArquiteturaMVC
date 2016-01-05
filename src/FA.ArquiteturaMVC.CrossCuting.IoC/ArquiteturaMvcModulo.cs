using FA.ArquiteturaMVC.Application;
using FA.ArquiteturaMVC.Application.Interfaces;
using FA.ArquiteturaMVC.Domain.Interfaces.Repository;
using FA.ArquiteturaMVC.Domain.Interfaces.Service;
using FA.ArquiteturaMVC.Domain.Services;
using FA.ArquiteturaMVC.Infra.Data.Repositories;
using Ninject.Modules;
using System;

namespace FA.ArquiteturaMVC.CrossCuting.IoC
{
    public class ArquiteturaMvcModulo : NinjectModule
    {
        public override void Load()
        {
            //Application
            Bind<IClienteAppService>().To<ClienteAppService>();

            //Domain
            Bind<IClienteService>().To<ClienteService>();

            //Data
            Bind<IClienteRepository>().To<ClienteRepository>();
        }
    }
}
