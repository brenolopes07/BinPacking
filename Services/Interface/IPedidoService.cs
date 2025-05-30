using testel2tecnologia.Domain.DTOs;

namespace testel2tecnologia.Services.Interface
{
    public interface IPedidoService
    {
        Task<PedidoOutputDto> ProcessarPedidoAsync(PedidoInputDto pedidoDto);
    }
}
