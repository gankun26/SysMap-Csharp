using System.ComponentModel.DataAnnotations;

namespace SysmapApi.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataExclusao { get; set; }
        public int CriadoPorUsuId { get; set; }
        public int AlteradoPorUsuId { get; set; }
        public int ExcluidoPorUsuId { get; set; }
        public bool IndAtivo { get; set; }
    }
}
