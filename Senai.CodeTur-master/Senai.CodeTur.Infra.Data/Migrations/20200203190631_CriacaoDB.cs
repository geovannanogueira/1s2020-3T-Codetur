using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    public partial class CriacaoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    IdPacote = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "VARCHAR(128)", nullable: false),
                    Imagem = table.Column<string>(type: "TEXT", nullable: true),
                    Descrição = table.Column<string>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    Pais = table.Column<string>(type: "VARCHAR(128)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Oferta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.IdPacote);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Tipo = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Pacotes",
                columns: new[] { "IdPacote", "Ativo", "DataFinal", "DateTime", "Descrição", "Imagem", "Oferta", "Pais", "Titulo" },
                values: new object[] { 1, true, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instituto de Tecnologia de Massachusetts", "https://www.estudarfora.org.br/app/uploads/2018/01/mestrado-no-MIT.jpg", false, "Massachusetts, Estados Unidos", "Intercâmbio" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Email", "Senha", "Tipo" },
                values: new object[] { 1, "fernando.guerra@sp.senai.br", "senai132", "Administrador" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
