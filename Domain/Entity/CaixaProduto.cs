namespace testel2tecnologia.Domain.Entity
{
    public class CaixaProduto
    {
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }

        public int Id { get; set; }

        public string ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
