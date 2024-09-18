using System;
using System.Collections.Generic;

namespace MetaNetPDV.Domain
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Total { get; set; }
        public List<ItemVenda> Itens { get; set; }
    }
}
