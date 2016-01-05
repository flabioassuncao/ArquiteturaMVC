using System;
using FA.ArquiteturaMVC.Infra.Data.Interfaces;
using FA.ArquiteturaMVC.Infra.Data.Context;
using Microsoft.Practices.ServiceLocation;

namespace FA.ArquiteturaMVC.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly ArquiteturaMVCContext _dbContext;
        private readonly IContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>();
        private bool _disposed;

        public UnitOfWork()
        {
            _dbContext = _contextManager.GetContext();
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
