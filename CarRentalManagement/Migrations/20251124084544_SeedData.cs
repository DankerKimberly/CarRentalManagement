using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6069), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6109), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6113), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6114), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6549), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6551), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6554), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6555), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6732), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6733), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6736), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6737), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6739), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6740), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6742), new DateTime(2025, 11, 24, 16, 45, 41, 747, DateTimeKind.Local).AddTicks(6743), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
