using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Administradors",
                columns: new[] { "Id", "Email", "Password", "Perfil" },
                values: new object[] { -1, "adm@teste.com", "123456", "ADM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administradors",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
