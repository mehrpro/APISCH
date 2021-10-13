using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISCH.Migrations
{
    public partial class DBCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ImportExports",
                columns: new[] { "ID", "ImportExportType", "IsActive", "RegisterTime", "TagID" },
                values: new object[] { 1L, true, true, new DateTime(2021, 10, 13, 18, 26, 29, 692, DateTimeKind.Local).AddTicks(1193), "110A02EF1250" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 1L);
        }
    }
}
