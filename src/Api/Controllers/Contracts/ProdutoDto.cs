using Av2Poo.Api.Core.Application.ProductAgg.Contracts;

namespace Av2Poo.Api.Controllers.Contracts
{
    public class ProdutoDto : IProdutoView
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Status { get; set; }
    }
}