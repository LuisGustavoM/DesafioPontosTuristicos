using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("2e7bc293-3c0e-42f1-a6b8-4dd8718e800a"));

            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("46d868de-15c4-4dbf-a506-9c8b76e7425f"));

            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("5fd0a06f-da00-4c68-a80c-8c580e51f597"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHoraCadastro",
                table: "PontosTuristicos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "DataHoraCadastro", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("60bf0db9-0f3b-4b58-a61c-d4beb1f07a96"), "Rio de Janeiro", new DateTime(2022, 10, 23, 13, 27, 42, 739, DateTimeKind.Local).AddTicks(2330), "Principal ponto turístico do Rio de Janeiro", "RJ", "Cristo Redentor", "" });

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "DataHoraCadastro", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("72c4c3f8-fc6e-4a07-9d8e-da169507ec5a"), "Rio de Janeiro", new DateTime(2022, 10, 23, 13, 27, 42, 739, DateTimeKind.Local).AddTicks(2351), "Principal ponto turístico do Rio de Janeiro", "RJ", "Pão de Açúcar", "" });

            migrationBuilder.InsertData(
                table: "PontosTuristicos",
                columns: new[] { "Id", "Cidade", "DataHoraCadastro", "Descricao", "Estado", "Nome", "Referencia" },
                values: new object[] { new Guid("adc2579f-edd1-4fcc-ac66-f7caa8c4a52a"), "Foz do Iguaçu", new DateTime(2022, 10, 23, 13, 27, 42, 739, DateTimeKind.Local).AddTicks(2355), "Patrimonio Natural da Humanidade.", "PR", "Cataratas do Iguaçu", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("60bf0db9-0f3b-4b58-a61c-d4beb1f07a96"));

            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("72c4c3f8-fc6e-4a07-9d8e-da169507ec5a"));

            migrationBuilder.DeleteData(
                table: "PontosTuristicos",
                keyColumn: "Id",
                keyValue: new Guid("adc2579f-edd1-4fcc-ac66-f7caa8c4a52a"));

            migrationBuilder.DropColumn(
                name: "DataHoraCadastro",
                table: "PontosTuristicos");

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
    }
}
