using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTrack_Backend.Migrations
{
    /// <inheritdoc />
    public partial class CargoTypeadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoType",
                table: "Shipping",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoType",
                table: "Shipping");
        }
    }
}
