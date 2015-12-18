using FA.ArquiteturaMVC.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FA.ArquiteturaMVC.Infra.Data.Context;
using System.Data.Entity;
using System.Linq;

namespace FA.ArquiteturaMVC.Infra.Data.Repositories
{
    //Nessa parte basta implementar a interface para gerar o codigo. (ctrl+. em cima do IRepository)

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected ArquiteturaMVCContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new ArquiteturaMVCContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            SaveChanges();
        }

        public virtual void Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual TEntity ObterPorIdReadOnly(Guid id)
        {
            using (var db = new ArquiteturaMVCContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Set<TEntity>().Find(id);
            }
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
            SaveChanges();
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
