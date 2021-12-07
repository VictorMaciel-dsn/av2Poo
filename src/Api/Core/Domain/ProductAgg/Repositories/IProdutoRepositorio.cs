using System.Collections.Generic;
using Av2Poo.Api.Core.Domain.ProductAgg.Entities;

namespace Av2Poo.Api.Core.Domain.ProductAgg.Repositories
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        ICollection<Produto> Buscar(string nome);
        Produto ObterPeloId(string id);
    }
}