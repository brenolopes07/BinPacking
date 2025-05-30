using Microsoft.AspNetCore.Mvc;
using testel2tecnologia.Domain.DTOs;
using testel2tecnologia.Services.Interface;

namespace testel2tecnologia.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost("processar")]
        public async Task<ActionResult<List<PedidoOutputDto>>> ProcessarPedidos([FromBody] PedidoListaInputDto input)
        {
            if (input == null || input.Pedidos == null || !input.Pedidos.Any())
            {
                return BadRequest("Nenhum pedido fornecido.");
            }

            try
            {
                var pedidosProcessados = new List<PedidoOutputDto>();

                foreach (var pedidoDto in input.Pedidos)
                {
                    var pedidoProcessado = await _pedidoService.ProcessarPedidoAsync(pedidoDto);
                    pedidosProcessados.Add(pedidoProcessado);
                }

                return Ok(pedidosProcessados);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao processar pedidos: {ex.Message}");
            }
        }
    }
}
