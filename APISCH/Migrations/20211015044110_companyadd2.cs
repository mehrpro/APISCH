using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISCH.Migrations
{
    public partial class companyadd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "c6dee22d-6ac3-4355-a5d4-c530c319ed31");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "ID", "CompanyTitle" },
                values: new object[,]
                {
                    { 2, "ZarinTaj" },
                    { 3, "SepehrCable" }
                });

            migrationBuilder.UpdateData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 1L,
                column: "RegisterTime",
                value: new DateTime(2021, 10, 15, 8, 11, 9, 736, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.InsertData(
                table: "ImportExports",
                columns: new[] { "ID", "ImportExportType", "IsActive", "RegisterTime", "TagID" },
                values: new object[] { 2L, false, true, new DateTime(2021, 10, 15, 8, 11, 9, 736, DateTimeKind.Local).AddTicks(2358), "1125A0252DF123" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Age", "CompanyID_FK", "FName", "IsActive", "LName", "PhoneNumber", "RegisterTime" },
                values: new object[] { "16ceaa26-6969-416b-a920-9efb5692cf13", (byte)35, 1, "Farshid", true, "Mohammadi", "9186620474", new DateTime(2021, 10, 15, 8, 11, 9, 738, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Age", "CompanyID_FK", "FName", "IsActive", "LName", "PhoneNumber", "RegisterTime" },
                values: new object[] { "2341d9e5-c3f4-4e93-981e-02434d1a6377", (byte)10, 2, "Sara", true, "Mohammadi", "9372515252", new DateTime(2021, 10, 15, 8, 11, 9, 738, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Age", "CompanyID_FK", "FName", "IsActive", "LName", "PhoneNumber", "RegisterTime" },
                values: new object[] { "dd756033-1364-4a58-9fc1-c67bf40037ea", (byte)6, 2, "Sepehr", true, "Mohammadi", "9382362525", new DateTime(2021, 10, 15, 8, 11, 9, 738, DateTimeKind.Local).AddTicks(8460) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImportExports",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "16ceaa26-6969-416b-a920-9efb5692cf13");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "2341d9e5-c3f4-4e93-981e-02434d1a6377");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: "dd756033-1364-4a58-9fc1-c67bf40037ea");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "ID",
                keyValue: 2);

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
        }
    }
}
