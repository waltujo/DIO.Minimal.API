using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class renameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradors",
                table: "Administradors");

            migrationBuilder.RenameTable(
                name: "Administradors",
                newName: "Administradores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Administradores",
                table: "Administradores");

            migrationBuilder.RenameTable(
                name: "Administradores",
                newName: "Administradors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Administradors",
                table: "Administradors",
                column: "Id");
        }
    }
}
