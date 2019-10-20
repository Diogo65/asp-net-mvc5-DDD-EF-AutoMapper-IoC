using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetmoModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
