using System.Text.Json.Serialization;

public class PedidoOutputDto
{
    [JsonPropertyName("pedido_id")]
    public int PedidoId { get; set; }

    [JsonPropertyName("caixas")]
    public List<CaixaOutputDto> Caixas { get; set; }
}

public class CaixaOutputDto
{
    [JsonPropertyName("caixa_id")]
    public string CaixaId { get; set; }  
    [JsonPropertyName("produtos")]
    public List<string> Produtos { get; set; }
}