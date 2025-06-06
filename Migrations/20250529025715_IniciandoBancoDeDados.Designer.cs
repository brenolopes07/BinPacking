﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testel2tecnologia.Data;

#nullable disable

namespace testel2tecnologia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250529025715_IniciandoBancoDeDados")]
    partial class IniciandoBancoDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Caixa", b =>
                {
                    b.Property<int>("CaixaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaixaId"));

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaixaId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.CaixaProduto", b =>
                {
                    b.Property<int>("CaixaId")
                        .HasColumnType("int");

                    b.Property<string>("ProdutoId")
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("CaixaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CaixaProduto");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Produto", b =>
                {
                    b.Property<string>("ProdutoId")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<double>("Comprimento")
                        .HasColumnType("float");

                    b.Property<double>("Largura")
                        .HasColumnType("float");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Caixa", b =>
                {
                    b.HasOne("testel2tecnologia.Domain.Entity.Pedido", "Pedido")
                        .WithMany("Caixas")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.CaixaProduto", b =>
                {
                    b.HasOne("testel2tecnologia.Domain.Entity.Caixa", "Caixa")
                        .WithMany("CaixaProdutos")
                        .HasForeignKey("CaixaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("testel2tecnologia.Domain.Entity.Produto", "Produto")
                        .WithMany("CaixaProdutos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caixa");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Produto", b =>
                {
                    b.HasOne("testel2tecnologia.Domain.Entity.Pedido", "Pedido")
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Caixa", b =>
                {
                    b.Navigation("CaixaProdutos");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Pedido", b =>
                {
                    b.Navigation("Caixas");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("testel2tecnologia.Domain.Entity.Produto", b =>
                {
                    b.Navigation("CaixaProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
