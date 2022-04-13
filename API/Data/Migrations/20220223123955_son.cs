using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 25, "doktor2", 4, new DateTime(2022, 2, 23, 15, 39, 55, 491, DateTimeKind.Local).AddTicks(572) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 28, "doktor2", 4, new DateTime(2022, 2, 23, 15, 39, 12, 633, DateTimeKind.Local).AddTicks(556) });
        }
    }
}
