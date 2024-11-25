using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9502a52-aadb-4d14-91ab-92ab393682db", "AQAAAAIAAYagAAAAENop1N8r15hMpM0HpohKwT53JuUf2qhzU+0sJGoxibCAHoMGdPtoGt999K2JvQlu5A==", "30548640-a507-4631-90a4-03c19a8d1530" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8802), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8806), new DateTime(2024, 11, 18, 17, 50, 45, 338, DateTimeKind.Local).AddTicks(8807) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5625cab-f81e-4220-96e2-1f0ac4ee6744", "AQAAAAIAAYagAAAAEFurzKb3+CX/CJ5vN8Zykh4yfSNUG3XWzDlnZmTzsiERyvFkSKOD+KZzPE5abGgrXg==", "93774bd8-df9b-488f-bd2f-65422ff65440" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2297), new DateTime(2024, 11, 18, 17, 48, 17, 159, DateTimeKind.Local).AddTicks(2298) });
        }
    }
}
