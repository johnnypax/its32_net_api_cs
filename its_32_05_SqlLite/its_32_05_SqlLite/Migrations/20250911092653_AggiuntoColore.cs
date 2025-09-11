using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace its_32_05_SqlLite.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntoColore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Colore",
                table: "Automobiles",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colore",
                table: "Automobiles");
        }
    }
}
