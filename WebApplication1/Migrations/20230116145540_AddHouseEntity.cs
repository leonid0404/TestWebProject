using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddHouseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HouseId",
                table: "People",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Floors = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_HouseId",
                table: "People",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Houses_HouseId",
                table: "People",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Houses_HouseId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_People_HouseId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "People");
        }
    }
}
