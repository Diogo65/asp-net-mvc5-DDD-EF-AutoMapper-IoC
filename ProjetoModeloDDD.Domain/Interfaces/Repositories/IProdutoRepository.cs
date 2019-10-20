using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IDisposable, IRepositoryBase<Produto> 
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
