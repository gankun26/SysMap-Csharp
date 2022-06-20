namespace SysmapApi.Models
{
    public class VendaProduto
    {
        public int VendaProdutoId { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorFinal { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataExclusao { get; set; }
        public int CriadoPorUsuId { get; set; }
        public int AlteradoPorUsuId { get; set; }
        public int ExcluidoPorUsuId { get; set; }
        public bool IndAtivo { get; set; }
    }
}
