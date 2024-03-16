using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegraContasAPagar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorCorrigido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultaPercentual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultaValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JurosDiaPercentual = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JurosDiaValor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegraContasAPagar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContasAPagar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorOriginal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorCorrigido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdRegraContasPagar = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasAPagar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContasAPagar_RegraContasAPagar_IdRegraContasPagar",
                        column: x => x.IdRegraContasPagar,
                        principalTable: "RegraContasAPagar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasAPagar_IdRegraContasPagar",
                table: "ContasAPagar",
                column: "IdRegraContasPagar",
                unique: true,
                filter: "[IdRegraContasPagar] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasAPagar");

            migrationBuilder.DropTable(
                name: "RegraContasAPagar");
        }
    }
}
