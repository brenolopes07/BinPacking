using Microsoft.EntityFrameworkCore;
using testel2tecnologia.Domain.Entity;

namespace testel2tecnologia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Caixa> Caixas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Pedido
            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(p => p.PedidoId);

                entity.HasMany(p => p.Produtos)
                      .WithOne(p => p.Pedido)
                      .HasForeignKey(p => p.PedidoId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(p => p.Caixas)
                      .WithOne(c => c.Pedido)
                      .HasForeignKey(c => c.PedidoId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            
            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.ProdutoId).HasMaxLength(128);

                
                entity.HasOne(p => p.Pedido)
                      .WithMany(p => p.Produtos)
                      .HasForeignKey(p => p.PedidoId);

                
                entity.HasMany(p => p.CaixaProdutos)
                      .WithOne(cp => cp.Produto)
                      .HasForeignKey(cp => cp.Id);
            });

            
            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.HasKey(c => c.CaixaId);

                
                entity.HasOne(c => c.Pedido)
                      .WithMany(p => p.Caixas)
                      .HasForeignKey(c => c.PedidoId);

                
                entity.HasMany(c => c.CaixaProdutos)
                      .WithOne(cp => cp.Caixa)
                      .HasForeignKey(cp => cp.CaixaId);
            });

            
            modelBuilder.Entity<CaixaProduto>(entity =>
            {
                entity.HasKey(cp => new { cp.CaixaId, cp.Id }); 

                entity.HasOne(cp => cp.Caixa)
                      .WithMany(c => c.CaixaProdutos)
                      .HasForeignKey(cp => cp.CaixaId);

                entity.HasOne(cp => cp.Produto)
                      .WithMany(p => p.CaixaProdutos)
                      .HasForeignKey(cp => cp.Id);
            });
        }

    }
}
