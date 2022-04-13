using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class seed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CREATED" },
                values: new object[] { "doktor5", new DateTime(2022, 2, 23, 15, 20, 34, 922, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 2, "doktor2", 4, new DateTime(2022, 2, 23, 15, 20, 34, 921, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 3, "doktor3", 4, new DateTime(2022, 2, 23, 15, 20, 34, 922, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookId", "CREATED" },
                values: new object[] { 4, "doktor4", 4, new DateTime(2022, 2, 23, 15, 20, 34, 922, DateTimeKind.Local).AddTicks(3180) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CREATED" },
                values: new object[] { "doktor", new DateTime(2022, 2, 23, 15, 17, 55, 577, DateTimeKind.Local).AddTicks(2096) });
        }
    }
}
