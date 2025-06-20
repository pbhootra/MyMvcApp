using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApplication3.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDairyEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DairyEntries",
                columns: new[] { "id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went with my friend", new DateTime(2025, 6, 17, 11, 33, 18, 928, DateTimeKind.Local).AddTicks(3912), "Outing" },
                    { 2, "Went with my friend", new DateTime(2025, 6, 17, 11, 33, 18, 928, DateTimeKind.Local).AddTicks(4423), "Shopping" },
                    { 3, "To  Home Town", new DateTime(2025, 6, 17, 11, 33, 18, 928, DateTimeKind.Local).AddTicks(4427), "Travelling" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
