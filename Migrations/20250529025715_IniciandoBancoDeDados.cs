using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testel2tecnologia.Migrations
{
    /// <inheritdoc />
    public partial class IniciandoBancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "Caixas",
                columns: table => new
                {
                    CaixaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixas", x => x.CaixaId);
                    table.ForeignKey(
                        name: "FK_Caixas_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaixaProduto",
                columns: table => new
                {
                    CaixaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<string>(type: "nvarchar(128)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaixaProduto", x => new { x.CaixaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_CaixaProduto_Caixas_CaixaId",
                        column: x => x.CaixaId,
                        principalTable: "Caixas",
                        principalColumn: "CaixaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaixaProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaixaProduto_ProdutoId",
                table: "CaixaProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caixas_PedidoId",
                table: "Caixas",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaixaProduto");

            migrationBuilder.DropTable(
                name: "Caixas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
