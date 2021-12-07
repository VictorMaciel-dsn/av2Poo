using Av2Poo.Api.Core.Application.ProductAgg.Contracts;

namespace Av2Poo.Api.Controllers.Contracts
{
    public class AtualizarProdutoDto : IAtualizarProduto
    {
        public string Nome { get; set; }
        public long Preco { get; set; }
    }
}