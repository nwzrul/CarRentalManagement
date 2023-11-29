using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "86f98ce3-8b28-49f5-9982-bb81b0f6611d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMNBRpHt/koIj+feNVurmkmrsYGi1qvDJ+z1mBjK7Fhcr0F5n5MBAyWz/fGgjiqutw==", null, false, "9f9aa027-8ebf-409b-a2a3-2f74533c8432", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9219), new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9232), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9234), new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9235), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9799), "Nissan", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 11, 24, 11, 51, 9, 548, DateTimeKind.Local).AddTicks(9801), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(158), "Skyline R30", "System" },
                    { 2, "System", new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(160), new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(160), "Leopard", "System" },
                    { 3, "System", new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(162), new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(162), "Celsior", "System" },
                    { 4, "System", new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(164), new DateTime(2023, 11, 24, 11, 51, 9, 549, DateTimeKind.Local).AddTicks(165), "Chaser JZX100", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
