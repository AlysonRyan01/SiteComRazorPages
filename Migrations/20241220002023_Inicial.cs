using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteComRazorPages.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Slug = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorTotal = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false, defaultValueSql: "0.00"),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    VendaFinalId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FormaPagamento = table.Column<string>(type: "NVARCHAR", maxLength: 80, nullable: false),
                    NomeCliente = table.Column<string>(type: "VARCHAR", maxLength: 280, nullable: false),
                    NumeroCartao = table.Column<string>(type: "VARCHAR", maxLength: 120, nullable: true),
                    CodigoCartao = table.Column<string>(type: "VARCHAR", maxLength: 120, nullable: true),
                    CpfCliente = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    VendaFinalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "NVARCHAR", maxLength: 120, nullable: false),
                    Imagem = table.Column<string>(type: "NVARCHAR", maxLength: 300, nullable: true),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false),
                    Fone = table.Column<string>(type: "VARCHAR", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR", maxLength: 200, nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR", maxLength: 20, nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR", maxLength: 280, nullable: false),
                    CarrinhoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Carrinho",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinho",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "NVARCHAR", maxLength: 280, nullable: false),
                    TipoProduto = table.Column<string>(type: "NVARCHAR", maxLength: 80, nullable: false),
                    Marca = table.Column<string>(type: "NVARCHAR", maxLength: 80, nullable: false),
                    Modelo = table.Column<string>(type: "NVARCHAR", maxLength: 120, nullable: false),
                    Serie = table.Column<string>(type: "NVARCHAR", maxLength: 280, nullable: false),
                    Preco = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Garantia = table.Column<string>(type: "NVARCHAR", maxLength: 80, nullable: false),
                    CarrinhoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Carrinho",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinho",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClienteCargo",
                columns: table => new
                {
                    CargoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteCargo", x => new { x.CargoId, x.ClienteId });
                    table.ForeignKey(
                        name: "FK_ClienteCargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteCargo_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaFinal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorTotal = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    CarrinhoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    PagamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    RelatorioVendasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaFinal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaFinal_Carrinho",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinho",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VendaFinal_Cliente",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VendaFinal_Pagamento",
                        column: x => x.PagamentoId,
                        principalTable: "Pagamento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProdutoImagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImagemUrl = table.Column<string>(type: "NVARCHAR", maxLength: 280, nullable: false),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoImagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoImagens_Produto",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatorioVendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorTotal = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    VendaFinalId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatorioVendas_VendaFinal",
                        column: x => x.VendaFinalId,
                        principalTable: "VendaFinal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CarrinhoId",
                table: "Cliente",
                column: "CarrinhoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClienteCargo_ClienteId",
                table: "ClienteCargo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CarrinhoId",
                table: "Produto",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoImagens_ProdutoId",
                table: "ProdutoImagens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioVendas_VendaFinalId",
                table: "RelatorioVendas",
                column: "VendaFinalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VendaFinal_CarrinhoId",
                table: "VendaFinal",
                column: "CarrinhoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VendaFinal_ClienteId",
                table: "VendaFinal",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaFinal_PagamentoId",
                table: "VendaFinal",
                column: "PagamentoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteCargo");

            migrationBuilder.DropTable(
                name: "ProdutoImagens");

            migrationBuilder.DropTable(
                name: "RelatorioVendas");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "VendaFinal");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Carrinho");
        }
    }
}
