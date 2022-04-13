using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 5, "doktor", 4, new DateTime(2022, 2, 23, 15, 17, 55, 577, DateTimeKind.Local).AddTicks(2096) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 1, "kim", 4, new DateTime(2022, 2, 23, 15, 16, 51, 625, DateTimeKind.Local).AddTicks(1327) });
        }
    }
}
