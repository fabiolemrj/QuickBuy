

using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContext _quickBuyContext;

        public BaseRepositorio(QuickBuyContext quickBuyContext)
        {
            _quickBuyContext = quickBuyContext;
        }
        public void Adicionar(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Add(entity);
            _quickBuyContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Update(entity);
            _quickBuyContext.SaveChanges();
        }

        public void Dispose()
        {
            _quickBuyContext.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _quickBuyContext.Set<TEntity>().Find( id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _quickBuyContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _quickBuyContext.Set<TEntity>().Remove(entity);
            _quickBuyContext.SaveChanges();
        }
    }
}
