using testel2tecnologia.Domain.DTOs;
using testel2tecnologia.Domain.Entity;
using testel2tecnologia.Repository.Interface;
using testel2tecnologia.Services.Interface;

namespace testel2tecnologia.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidorepository;
        private readonly IPackingService _packingService;

        public PedidoService(IPedidoRepository pedidorepository, IPackingService packingService)
        {
            _pedidorepository = pedidorepository;
            _packingService = packingService;
        }

        public async Task<PedidoOutputDto> ProcessarPedidoAsync(PedidoInputDto pedidoDto)


        {
            var pedido = new Pedido
            {
                Produtos = pedidoDto.Produtos.Select(p => new Produto
                {
                    ProdutoId = p.ProdutoId,
                    Altura = p.Dimensoes.Altura,
                    Largura = p.Dimensoes.Largura,
                    Comprimento = p.Dimensoes.Comprimento
                }).ToList()
            };


            var pedidoSalvo = await _pedidorepository.AddPedidoAsync(pedido);



            if (pedidoSalvo == null)
            {
                throw new Exception("Erro ao processar o pedido.");
            }


            var caixasUsadas = _packingService.OrganizarProdutoEmCaixas(pedido.Produtos);

            pedidoSalvo.Caixas = caixasUsadas;

            var pedidoOutput = new PedidoOutputDto
            {
                PedidoId = pedidoSalvo.PedidoId,
                Caixas = pedidoSalvo.Caixas.Select(c => new CaixaOutputDto
                {
                    CaixaId = c.Tipo, 

                    Produtos = c.CaixaProdutos.Select(cp => cp.Produto.ProdutoId).ToList()
                }).ToList()
            };

            return pedidoOutput;

        }
    }
}
