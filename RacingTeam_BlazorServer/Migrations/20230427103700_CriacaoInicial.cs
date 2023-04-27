using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RacingTeam_BlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classificacoes",
                columns: table => new
                {
                    Id_Pontuacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classificacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacoes", x => x.Id_Pontuacao);
                });

            migrationBuilder.CreateTable(
                name: "Competicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    Id_piloto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Equipa = table.Column<int>(type: "int", nullable: false),
                    PaisRegiao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.Id_piloto);
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    Id_Resultado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Corrida = table.Column<int>(type: "int", nullable: false),
                    Id_Piloto = table.Column<int>(type: "int", nullable: false),
                    Posicao = table.Column<int>(type: "int", nullable: false),
                    VoltaMaisRapida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassificacaoGeralId_Pontuacao = table.Column<int>(type: "int", nullable: false),
                    PilotoId_piloto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.Id_Resultado);
                    table.ForeignKey(
                        name: "FK_Resultados_Classificacoes_ClassificacaoGeralId_Pontuacao",
                        column: x => x.ClassificacaoGeralId_Pontuacao,
                        principalTable: "Classificacoes",
                        principalColumn: "Id_Pontuacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resultados_Pilotos_PilotoId_piloto",
                        column: x => x.PilotoId_piloto,
                        principalTable: "Pilotos",
                        principalColumn: "Id_piloto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corridas",
                columns: table => new
                {
                    Id_corrida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_competicao = table.Column<int>(type: "int", nullable: false),
                    Id_circuito = table.Column<int>(type: "int", nullable: false),
                    NumeroVoltas = table.Column<int>(type: "int", nullable: false),
                    NumeroMinutos = table.Column<int>(type: "int", nullable: false),
                    Id_Resultado = table.Column<int>(type: "int", nullable: false),
                    CircuitoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corridas", x => x.Id_corrida);
                    table.ForeignKey(
                        name: "FK_Corridas_Circuitos_CircuitoId",
                        column: x => x.CircuitoId,
                        principalTable: "Circuitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corridas_Resultados_Id_Resultado",
                        column: x => x.Id_Resultado,
                        principalTable: "Resultados",
                        principalColumn: "Id_Resultado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorridaId_corrida = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carros_Corridas_CorridaId_corrida",
                        column: x => x.CorridaId_corrida,
                        principalTable: "Corridas",
                        principalColumn: "Id_corrida");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_CorridaId_corrida",
                table: "Carros",
                column: "CorridaId_corrida");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_CircuitoId",
                table: "Corridas",
                column: "CircuitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_Id_Resultado",
                table: "Corridas",
                column: "Id_Resultado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_ClassificacaoGeralId_Pontuacao",
                table: "Resultados",
                column: "ClassificacaoGeralId_Pontuacao");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_PilotoId_piloto",
                table: "Resultados",
                column: "PilotoId_piloto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Competicoes");

            migrationBuilder.DropTable(
                name: "Equipas");

            migrationBuilder.DropTable(
                name: "Corridas");

            migrationBuilder.DropTable(
                name: "Circuitos");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Classificacoes");

            migrationBuilder.DropTable(
                name: "Pilotos");
        }
    }
}
