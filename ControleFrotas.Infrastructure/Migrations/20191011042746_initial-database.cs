using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFrotas.Infrastructure.Migrations
{
    public partial class initialdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: false),
                    CPF = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Vencimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Cor = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Renavam = table.Column<string>(nullable: false),
                    QuantidadePortas = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    NumeroChassi = table.Column<string>(nullable: false),
                    TipoCombustivel = table.Column<int>(nullable: false),
                    Abastecimento = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CNHs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    Registro = table.Column<int>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Validade = table.Column<DateTime>(nullable: false),
                    ColaboradorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CNHs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CNHs_Colaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataSolicitacao = table.Column<DateTime>(nullable: false),
                    QuantidadePassageiros = table.Column<int>(nullable: false),
                    Destino = table.Column<string>(nullable: false),
                    FimDestino = table.Column<string>(nullable: true),
                    ColaboradorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Colaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abastecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Kilometragem = table.Column<int>(nullable: false),
                    Responsavel = table.Column<DateTime>(nullable: false),
                    Combustivel = table.Column<int>(nullable: false),
                    Litros = table.Column<double>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abastecimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abastecimentos_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manutencoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Responsavel = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manutencoes_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KmInicial = table.Column<int>(nullable: false),
                    KmFinal = table.Column<int>(nullable: false),
                    Destino = table.Column<string>(nullable: false),
                    Relatorio = table.Column<string>(nullable: true),
                    Saida = table.Column<DateTime>(nullable: false),
                    Retorno = table.Column<DateTime>(nullable: false),
                    Autorizacao = table.Column<string>(nullable: false),
                    ColaboradorId = table.Column<int>(nullable: false),
                    VeiculoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usos_Colaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usos_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pecas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Veiculo = table.Column<string>(nullable: true),
                    QuantidadeEstoque = table.Column<int>(nullable: false),
                    ManutencaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pecas_Manutencoes_ManutencaoId",
                        column: x => x.ManutencaoId,
                        principalTable: "Manutencoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abastecimentos_VeiculoId",
                table: "Abastecimentos",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_CNHs_ColaboradorId",
                table: "CNHs",
                column: "ColaboradorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manutencoes_VeiculoId",
                table: "Manutencoes",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pecas_ManutencaoId",
                table: "Pecas",
                column: "ManutencaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ColaboradorId",
                table: "Reservas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usos_ColaboradorId",
                table: "Usos",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usos_VeiculoId",
                table: "Usos",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abastecimentos");

            migrationBuilder.DropTable(
                name: "CNHs");

            migrationBuilder.DropTable(
                name: "Pecas");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Usos");

            migrationBuilder.DropTable(
                name: "Manutencoes");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
