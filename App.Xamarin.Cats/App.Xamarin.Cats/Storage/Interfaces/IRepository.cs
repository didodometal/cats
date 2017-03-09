using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Xamarin.Cats.Storage.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> Buscar(Func<TEntity, bool> predicate);
        Task<TEntity> ObterPorId(string id);
        Task<IEnumerable<TEntity>> ObterTodos();
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Excluir(TEntity obj);
    }
}
