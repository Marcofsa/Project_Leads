using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeadProject_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "Email", "Name", "Phone", "Price", "Status", "Suburb" },
                values: new object[,]
                {
                    { 1, "Painters", new DateTime(2025, 3, 19, 11, 37, 49, 175, DateTimeKind.Utc).AddTicks(1523), "Need to paint 2 aluminum windows and a sliding glass door", "bill@example.com", "Bill", "123456789", 62.00m, 0, "Yanderra 2574" },
                    { 2, "Interior Painters", new DateTime(2025, 3, 19, 11, 37, 49, 175, DateTimeKind.Utc).AddTicks(3035), "Internal walls 3 colours", "craig@example.com", "Craig", "987654321", 49.00m, 0, "Woolooware 2230" }
                });
        }
    }
}
