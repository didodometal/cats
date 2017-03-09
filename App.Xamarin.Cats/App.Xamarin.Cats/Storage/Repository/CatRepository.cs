using App.Xamarin.Cats.Model.Entities;
using App.Xamarin.Cats.Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using App.Xamarin.Cats.Services;
using System.Threading.Tasks;

namespace App.Xamarin.Cats.Storage.Repository
{
    public class CatRepository : AzureService<Cat>, IRepository<Cat>
    {
        
        public Cat Adicionar(Cat obj)
        {
            return obj;
        }

        public Cat Atualizar(Cat obj)
        {
            return obj;
        }

        public void Excluir(Cat obj)
        {
            
        }

        public async Task<IEnumerable<Cat>> Buscar(Func<Cat, bool> predicate)
        {
            var tb = await GetTable();
            return tb.Where(predicate);
        }

        public async Task<Cat> ObterPorId(string id)
        {
            var tb = await GetTable();
            return tb.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Cat>> ObterTodos()
        {
            var tb = await GetTable();
            return tb.ToList();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
