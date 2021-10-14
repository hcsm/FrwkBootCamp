using Microsoft.EntityFrameworkCore.Migrations;

namespace FrameBook.Infra.Data.Migrations
{
    public partial class MudançaEstadoUf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Profissional");

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "Profissional",
                fixedLength: true,
                maxLength: 2,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uf",
                table: "Profissional");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Profissional",
                type: "char(2) CHARACTER SET utf8mb4",
                fixedLength: true,
                maxLength: 2,
                nullable: true);
        }
    }
}
