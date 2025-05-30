using testel2tecnologia.Domain.DTOs;
using testel2tecnologia.Domain.Entity;

namespace testel2tecnologia.Services.Interface
{
    public interface IPedidoService
    {
        Task<PedidoOutputDto> ProcessarPedidoAsync(PedidoInputDto pedidoDto);
    }
}
