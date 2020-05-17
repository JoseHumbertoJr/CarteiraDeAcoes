using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarteiraDeAcoes.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acaos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acaos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acaos");
        }
    }
}
