﻿using System.Collections.Generic;

namespace Av2Poo.Api.Core.Domain.EstoqueAgg.Entities
{
    public class Estoque
    {
        public Estoque(IEnumerable<EstoqueItem> itens)
        {
            Itens = new List<EstoqueItem>(itens);
        }
        
        public ICollection<EstoqueItem> Itens { get; private set; }
    }
}