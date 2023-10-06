using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTrack_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Nullablefk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipping_Customer_CustomerId",
                table: "Shipping");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Shipping",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipping_Customer_CustomerId",
                table: "Shipping",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipping_Customer_CustomerId",
                table: "Shipping");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Shipping",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipping_Customer_CustomerId",
                table: "Shipping",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
