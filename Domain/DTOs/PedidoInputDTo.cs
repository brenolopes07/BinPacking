using System.Text.Json.Serialization;

namespace testel2tecnologia.Domain.DTOs
{
    public class PedidoListaInputDto
    {
        public List<PedidoInputDto> Pedidos { get; set; }
    }

    public class PedidoInputDto
    {
        public List<ProdutoInputDto> Produtos { get; set; }
    }

    public class ProdutoInputDto
    {
        public string ProdutoId { get; set; }
        public DimensoesInputDto Dimensoes { get; set; }
    }

    public class DimensoesInputDto
    {
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Comprimento { get; set; }
    }
}
