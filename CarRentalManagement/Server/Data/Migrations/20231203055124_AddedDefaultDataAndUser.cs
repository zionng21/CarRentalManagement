﻿using System;
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8c03a205-5431-4d2c-8cac-abc0d4a9cf92", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPYVxNa+efaAgmPBA76tWAXNk5Y2yuqsqJ4WWB7wS8mByJKC542uSVu3LEKYcCrJsw==", null, false, "9d7edc89-73b0-420b-8cf2-090b74a6f584", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 13, 51, 24, 378, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 12, 3, 13, 51, 24, 378, DateTimeKind.Local).AddTicks(9731), "Black", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 13, 51, 24, 378, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 12, 3, 13, 51, 24, 378, DateTimeKind.Local).AddTicks(9735), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(101), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(103), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(105), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(309), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(311), "X5", "System" },
                    { 3, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(313), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 12, 3, 13, 51, 24, 379, DateTimeKind.Local).AddTicks(316), "Rav4", "System" }
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
