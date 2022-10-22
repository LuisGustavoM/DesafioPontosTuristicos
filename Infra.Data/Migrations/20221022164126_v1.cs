using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PontosTuristicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PontosTuristicos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("2e7bc293-3c0e-42f1-a6b8-4dd8718e800a"), "Rio de Janeiro", "Principal ponto turístico do Rio de Janeiro", "RJ", "Cristo Redentor", "" });

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("46d868de-15c4-4dbf-a506-9c8b76e7425f"), "Foz do Iguaçu", "Patrimonio Natural da Humanidade.", "PR", "Cataratas do Iguaçu", "" });

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("5fd0a06f-da00-4c68-a80c-8c580e51f597"), "Rio de Janeiro", "Principal ponto turístico do Rio de Janeiro", "RJ", "Pão de Açúcar", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PontosTuristicos");
        }
    }
}
