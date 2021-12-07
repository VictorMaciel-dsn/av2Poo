using Av2Poo.Api.Core.Application.ProductAgg.Contracts;
using Av2Poo.Api.Core.Application.ProductAgg.Parsers;
using Av2Poo.Api.Core.Domain.ProductAgg.Entities;

namespace Av2Poo.Api.Controllers.Parsers
{
    public class ProdutoParseFactory : IProdutoParseFactory
    {
        private readonly ProdutoReportParser _produtoReportParser;

        public ProdutoParseFactory(ProdutoReportParser produtoReportParser)
        {
            _produtoReportParser = produtoReportParser;
        }
        
        public IParser<Produto, IProdutoView> GetProdutoParse()
        {
            return new ProdutoParser();
        }

        public IParser<Produto, IProdutoView> GetProdutoReportParse()
        {
            return _produtoReportParser;
        }
    }
}