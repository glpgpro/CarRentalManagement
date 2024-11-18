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
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5072), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5349), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5352), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5559), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5560), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5563), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5565), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 11, 18, 17, 6, 46, 620, DateTimeKind.Local).AddTicks(5567), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 54, 22, 590, DateTimeKind.Local).AddTicks(5270), new DateTime(2024, 11, 18, 16, 54, 22, 590, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 54, 22, 590, DateTimeKind.Local).AddTicks(5329), new DateTime(2024, 11, 18, 16, 54, 22, 590, DateTimeKind.Local).AddTicks(5330) });
        }
    }
}
