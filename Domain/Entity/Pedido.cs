namespace testel2tecnologia.Domain.Entity
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public List<Caixa> Caixas { get; set; } = new List<Caixa>();
    }
}
