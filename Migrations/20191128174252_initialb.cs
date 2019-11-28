using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsliPehlivan_HW5.Migrations
{
    public partial class initialb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Role" },
                values: new object[] { new DateTime(2019, 11, 28, 20, 42, 51, 920, DateTimeKind.Local).AddTicks(788), "Öğrenci" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Role" },
                values: new object[] { new DateTime(2019, 11, 28, 20, 7, 33, 907, DateTimeKind.Local).AddTicks(9552), "Student" });
        }
    }
}
