using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testel2tecnologia.Migrations
{
    /// <inheritdoc />
    public partial class SecundaryMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixaProduto_Produtos_ProdutoId",
                table: "CaixaProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaixaProduto",
                table: "CaixaProduto");

            migrationBuilder.DropIndex(
                name: "IX_CaixaProduto_ProdutoId",
                table: "CaixaProduto");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoId",
                table: "CaixaProduto",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CaixaProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaixaProduto",
                table: "CaixaProduto",
                columns: new[] { "CaixaId", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CaixaProduto_Id",
                table: "CaixaProduto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaixaProduto_Produtos_Id",
                table: "CaixaProduto",
                column: "Id",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaixaProduto_Produtos_Id",
                table: "CaixaProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CaixaProduto",
                table: "CaixaProduto");

            migrationBuilder.DropIndex(
                name: "IX_CaixaProduto_Id",
                table: "CaixaProduto");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CaixaProduto");

            migrationBuilder.AlterColumn<string>(
                name: "ProdutoId",
                table: "CaixaProduto",
                type: "nvarchar(128)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CaixaProduto",
                table: "CaixaProduto",
                columns: new[] { "CaixaId", "ProdutoId" });

            migrationBuilder.CreateIndex(
                name: "IX_CaixaProduto_ProdutoId",
                table: "CaixaProduto",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaixaProduto_Produtos_ProdutoId",
                table: "CaixaProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
