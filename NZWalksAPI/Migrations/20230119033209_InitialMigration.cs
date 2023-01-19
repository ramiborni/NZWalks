using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    area = table.Column<double>(type: "float", nullable: false),
                    latitude = table.Column<double>(type: "float", nullable: false),
                    longtitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "walkDifficulty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_walkDifficulty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "walks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<double>(type: "float", nullable: false),
                    regionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    walkDifficultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_walks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_walks_regions_regionId",
                        column: x => x.regionId,
                        principalTable: "regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_walks_walkDifficulty_walkDifficultyId",
                        column: x => x.walkDifficultyId,
                        principalTable: "walkDifficulty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_walks_regionId",
                table: "walks",
                column: "regionId");

            migrationBuilder.CreateIndex(
                name: "IX_walks_walkDifficultyId",
                table: "walks",
                column: "walkDifficultyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "walks");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "walkDifficulty");
        }
    }
}
