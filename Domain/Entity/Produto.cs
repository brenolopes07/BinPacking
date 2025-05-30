using System.ComponentModel.DataAnnotations;

namespace testel2tecnologia.Domain.Entity
{
    public class Produto
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(128)]
        public required string ProdutoId { get; set; }
        public required double Altura { get; set; }
        public required double Largura { get; set; }
        public required double Comprimento { get; set; }

        public double Volume => Altura * Largura * Comprimento;

        public int PedidoId { get; set; }
        public  Pedido Pedido { get; set; } 

        public List<CaixaProduto> CaixaProdutos { get; set; } = new List<CaixaProduto>();


    }
}
