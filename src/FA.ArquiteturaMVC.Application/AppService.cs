using FA.ArquiteturaMVC.Infra.Data.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace FA.ArquiteturaMVC.Application
{
    public class AppService
    {
        //Depois que configurar a classe UnitOfWork, configurar esses dois metodos
        private IUnitOfWork _uow;

        public void BeginTransaction()
        {
            _uow = ServiceLocator.Current.GetInstance<IUnitOfWork>();
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }

    }
}
