using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTrack_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Shippingmissingattributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationAddress",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DestinationCity",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Shipping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Shipping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "Shipping",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SourceAddress",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SourceCity",
                table: "Shipping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Shipping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Shipping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationAddress",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "DestinationCity",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "SourceAddress",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "SourceCity",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Shipping");
        }
    }
}
