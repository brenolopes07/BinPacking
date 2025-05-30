using Microsoft.EntityFrameworkCore;
using testel2tecnologia.Data;
using testel2tecnologia.Domain.Entity;
using testel2tecnologia.Repository.Interface;

namespace testel2tecnologia.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Pedido> AddPedidoAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;

        }

        public async Task<Pedido> GetPedidoByIdAsync(int pedidoId)
        {
            return await _context.Pedidos
                .Include(p => p.Produtos)
                .Include(p => p.Caixas)
                   .ThenInclude(c => c.CaixaProdutos)
                .FirstOrDefaultAsync(p => p.PedidoId == pedidoId);
        }
    }
}
