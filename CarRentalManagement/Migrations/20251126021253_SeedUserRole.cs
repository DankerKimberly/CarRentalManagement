using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "225f1c16-b833-47e3-90c8-84374035cb73", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFBMBh9MvAmyoSJY99UQgs5snVcQeqT11Ec4ZpISCEeG0FRAgpYvz6pa7UNFwAz/Ww==", null, false, "10e66953-a42e-4559-8df0-aec1c191f3f8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(8765), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9247), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9477), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9480), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9483), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9486), new DateTime(2025, 11, 26, 10, 12, 51, 763, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4081), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4118), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4428), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4431), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4777), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4782), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4785), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4787), new DateTime(2025, 11, 26, 9, 30, 13, 10, DateTimeKind.Local).AddTicks(4788) });
        }
    }
}
