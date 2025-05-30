
namespace testel2tecnologia.Domain.Entity
{
    public class Caixa
    {
        public int CaixaId { get; set; }
        public String Tipo { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public List<CaixaProduto> CaixaProdutos { get; set; } = new List<CaixaProduto>();
    }
}
