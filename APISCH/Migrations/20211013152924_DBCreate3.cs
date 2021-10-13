using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISCH.Migrations
{
    public partial class DBCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RegisterTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RegisterTime",
                value: new DateTime(2021, 10, 13, 18, 59, 24, 64, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Age", "FName", "IsActive", "LName", "PhoneNumber", "RegisterTime" },
                values: new object[] { "44fb0dc9-2ad5-42db-9691-503fb4334a64", (byte)35, "Farshid", true, "Mohammadi", "9186620474", new DateTime(2021, 10, 13, 18, 59, 24, 66, DateTimeKind.Local).AddTicks(4550) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.UpdateData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RegisterTime",
                value: new DateTime(2021, 10, 13, 18, 26, 29, 692, DateTimeKind.Local).AddTicks(1193));
        }
    }
}
