using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISCH.Migrations
{
    public partial class companyadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "44fb0dc9-2ad5-42db-9691-503fb4334a64");

            migrationBuilder.AddColumn<int>(
                name: "CompanyID_FK",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "CompanyTitle" },
                values: new object[] { 1, "Golrang" });

            migrationBuilder.UpdateData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RegisterTime",
                value: new DateTime(2021, 10, 15, 7, 59, 52, 917, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Age", "CompanyID_FK", "FName", "IsActive", "LName", "PhoneNumber", "RegisterTime" },
                values: new object[] { "c6dee22d-6ac3-4355-a5d4-c530c319ed31", (byte)35, 1, "Farshid", true, "Mohammadi", "9186620474", new DateTime(2021, 10, 15, 7, 59, 52, 920, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CompanyID_FK",
                table: "Persons",
                column: "CompanyID_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Companies_CompanyID_FK",
                table: "Persons",
                column: "CompanyID_FK",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Companies_CompanyID_FK",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CompanyID_FK",
                table: "Persons");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "c6dee22d-6ac3-4355-a5d4-c530c319ed31");

            migrationBuilder.DropColumn(
                name: "CompanyID_FK",
                table: "Persons");

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
    }
}
