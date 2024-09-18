namespace MetaNetPDV.Domain
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int MercadoriaId { get; set; }
        public int Quantidade { get; set; }
        public decimal SubTotal { get; set; }
        public string Descricao { get; set; } 
    }
}
