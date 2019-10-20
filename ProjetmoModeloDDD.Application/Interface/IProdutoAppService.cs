using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetmoModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);

    }
}
