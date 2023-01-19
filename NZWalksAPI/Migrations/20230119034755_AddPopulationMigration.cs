using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPopulationMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "population",
                table: "regions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "population",
                table: "regions");
        }
    }
}
