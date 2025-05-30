using testel2tecnologia.Domain.Entity;

namespace testel2tecnologia.Repository.Interface
{
    public interface IPedidoRepository
    {
        Task<Pedido> AddPedidoAsync(Pedido pedido);
        Task<Pedido> GetPedidoByIdAsync(int pedidoId);
    }
}
